using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicImageProcApp
{
    enum ErrorCode
    {
        Success = 0,
        Fail
    }

    enum Channel
    {
        B = 0,
        G,
        R,

        Num
    }

    public partial class MainWindow : Form
    {
        private Color[] ChartColor = new Color[(int)Channel.Num] { Color.Blue, Color.Green, Color.Red };

        private Mat inputImage;
        private Mat outputImage;

        private ImageProc imageProc;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // アプリケーションの終了イベントハンドラを追加
            System.Windows.Forms.Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            this.Initializer();
        }

        /// <summary>
        /// イニシャライザ
        /// </summary>
        public void Initializer()
        {
            ClearChart(InputImageChart);
            ClearChart(OutputImageChart);

            imageProc = new ImageProc();
        }

        /// <summary>
        /// 描画エリアをクリアする
        /// </summary>
        /// <param name="area"></param>
        private void ClearImageArea(PictureBox area)
        {
            area.Image = null;
        }

        /// <summary>
        /// チャートをクリアする
        /// </summary>
        private void ClearChart(Chart chart)
        {
            chart.ChartAreas.Clear();
            chart.Series.Clear();
            chart.Legends.Clear();
        }

        /// <summary>
        /// ファイナライザ
        /// </summary>
        public void Finalizer()
        {
            if (this.inputImage != null)
            {
                this.inputImage.Dispose();
                this.inputImage = null;
            }

            if (this.outputImage != null)
            {
                this.outputImage.Dispose();
                this.outputImage = null;
            }

            if (this.imageProc != null)
            {
                imageProc.Dispose();
                this.imageProc = null;
            }
        }

        /// <summary>
        /// メッセージを出力する
        /// </summary>
        /// <param name="message"></param>
        private void WriteMessage(TextBox area, string message)
        {
            area.Text += message;
        }

        /// <summary>
        /// ファイル選択ボタンのクリックイベント
        /// </summary>
        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            ErrorCode errorCode;
            string filePath;

            (errorCode, filePath) = SelectFile();
            if (errorCode != ErrorCode.Success)
            {
                WriteMessage(MessageArea, $"{nameof(SelectFileButton_Click)}: ファイル読み込みに失敗しました。\r\n");
                return;
            }

            this.inputImage = imageProc.LoadImage(filePath);
            if (this.inputImage.Type() != MatType.CV_8UC3)
            {
                WriteMessage(MessageArea, $"{nameof(SelectFileButton_Click)}: 入力画像は8ビットRGBデータである必要があります。\r\n");
            }

            int[,] rgbHistogram = imageProc.CalculateRgbHistogram(inputImage, ImageParam.bitWidth);

            ClearImageArea(InputImageArea);
            ClearImageArea(OutputImageArea);
            ClearChart(InputImageChart);
            ClearChart(OutputImageChart);

            errorCode = DispImage(this.InputImageArea, this.inputImage);
            if (errorCode != ErrorCode.Success)
            {
                WriteMessage(MessageArea, $"{nameof(SelectFileButton_Click)}: 画像の表示に失敗しました。\r\n");
                return;
            }

            errorCode = DispHistogram(InputImageChart, rgbHistogram);
            if (errorCode != ErrorCode.Success)
            {
                WriteMessage(MessageArea, $"{nameof(SelectFileButton_Click)}: ヒストグラムの表示に失敗しました。\r\n");
                return;
            }
        }

        /// <summary>
        /// ファイル選択
        /// </summary>
        private (ErrorCode, string) SelectFile()
        {
            string filePath = string.Empty;

            ErrorCode errorCode;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "ファイル選択";
                openFileDialog.Filter = "JPG画像|*.jpg|PNG画像|*.png|BMP画像|*.bmp";
                openFileDialog.InitialDirectory = @"C:\";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    errorCode = ErrorCode.Success;
                    filePath = openFileDialog.FileName;
                }
                else
                {
                    errorCode = ErrorCode.Fail;
                }
            }

            return (errorCode, filePath);
        }

        /// <summary>
        /// 画像を表示する
        /// </summary>
        private ErrorCode DispImage(PictureBox area, Mat image)
        {
            if (area == null)
            {
                return ErrorCode.Fail;
            }

            if (image == null)
            {
                return ErrorCode.Fail;
            }

            if (area.Image != null)
            {
                area.Image.Dispose();
            }

            double resizeRateH = (double)area.Size.Width / image.Cols;
            double resizeRateV = (double)area.Size.Height / image.Rows;

            double resizeRate;
            if ((image.Cols > area.Size.Width)
                || (image.Rows > area.Size.Height))
            {
                resizeRate = Math.Min(resizeRateH, resizeRateV);
            }
            else
            {
                resizeRate = 1.0;
            }

            Mat dispImage = imageProc.ResizeImage(image, resizeRate);
            area.Image = BitmapConverter.ToBitmap(dispImage);

            return ErrorCode.Success;
        }

        /// <summary>
        /// ヒストグラムを表示する
        /// </summary>
        /// <param name="oneChannelImage"></param>
        private ErrorCode DispHistogram(System.Windows.Forms.DataVisualization.Charting.Chart chart, int[,] rgbHistogram)
        {
            if (chart == null)
            {
                return ErrorCode.Fail;
            }

            if (rgbHistogram == null)
            {
                return ErrorCode.Fail;
            }

            ClearChart(chart);
            chart.ChartAreas.Add(new ChartArea());
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = Math.Pow(2, ImageParam.bitWidth) - 1;

            for (int ch = 0; ch < (int)Channel.Num; ch++)
            {
                Series series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.Color = ChartColor[ch];

                for (int i = 0; i < (int)Math.Pow(2, ImageParam.bitWidth); i++)
                {
                    series.Points.AddXY(i, rgbHistogram[ch, i]);
                }

                chart.Series.Add(series);
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// クリアボタンのクリックイベント
        /// </summary>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            MessageArea.ResetText();
        }

        /// <summary>
        /// アプリケーションの終了イベント
        /// </summary>
        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            this.Finalizer();

            // アプリケーションの終了イベントハンドラを削除
            System.Windows.Forms.Application.ApplicationExit -= new EventHandler(Application_ApplicationExit);
        }

        /// <summary>
        /// ガウシアンフィルタ実行ボタンのクリックイベント
        /// </summary>
        private void RunGaussianFilterButton_Click(object sender, EventArgs e)
        {
            int kernelSize = int.Parse(KernelSizeTextBox.Text);
            if ((kernelSize < 0)
                || ((kernelSize % 2) == 0))
            {
                WriteMessage(MessageArea, $"{nameof(RunGaussianFilterButton_Click)}: カーネルサイズは1以上の奇数である必要があります。\r\n");
                return;
            }

            if (inputImage == null)
            {
                WriteMessage(MessageArea, $"{nameof(RunGaussianFilterButton_Click)}: 入力画像が選択されていません。\r\n");
                return;
            }

            this.outputImage = imageProc.RunGaussianFilter(this.inputImage, kernelSize);

            DispImage(OutputImageArea, outputImage);

            int[,] rgbHistogram = imageProc.CalculateRgbHistogram(outputImage, ImageParam.bitWidth);
            DispHistogram(OutputImageChart, rgbHistogram);
        }

        private void RunGammaCorrectButton_Click(object sender, EventArgs e)
        {
            double gammaValue = double.Parse(GammaValueTextBox.Text);
            if (gammaValue <= 0)
            {
                WriteMessage(MessageArea, $"{nameof(RunGaussianFilterButton_Click)}: ガンマ値は0より大きい数である必要があります。\r\n");
                return;
            }

            if (inputImage == null)
            {
                WriteMessage(MessageArea, $"{nameof(RunGaussianFilterButton_Click)}: 入力画像が選択されていません。\r\n");
                return;
            }

            this.outputImage = imageProc.RunGammaCorrect(this.inputImage, gammaValue);

            DispImage(OutputImageArea, outputImage);

            int[,] rgbHistogram = imageProc.CalculateRgbHistogram(outputImage, ImageParam.bitWidth);
            DispHistogram(OutputImageChart, rgbHistogram);
        }
    }
}
