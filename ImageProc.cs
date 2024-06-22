using OpenCvSharp;
using System;

namespace BasicImageProcApp
{
    internal class ImageProc
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ImageProc()
        {

        }

        public void Dispose()
        {

        }

        /// <summary>
        /// 画像を読み込む
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public Mat LoadImage(string path)
        {
            Mat image = new Mat(path);

            return image;
        }

        /// <summary>
        /// 画像をリサイズする
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public Mat ResizeImage(Mat srcImage, double resizeRate)
        {
            Mat dstImage = new Mat();
            Cv2.Resize(srcImage, dstImage, new OpenCvSharp.Size(), resizeRate, resizeRate);

            return dstImage;
        }

        public int[,] CalculateRgbHistogram(Mat image, int bitWidth)
        {
            Mat[] channelImage = Cv2.Split(image);
            int[,] rgbHistogram = new int[(int)Channel.Num, (int)Math.Pow(2, bitWidth)];

            for (int ch = 0; ch < (int)Channel.Num; ch++)
            {
                for (int y = 0; y < channelImage[ch].Rows; y++)
                {
                    for (int x = 0; x < channelImage[ch].Cols; x++)
                    {
                        rgbHistogram[ch, channelImage[ch].At<byte>(y, x)]++;
                    }
                }
            }

            return rgbHistogram;
        }

        /// <summary>
        /// ガウシアンフィルタを実行する
        /// </summary>
        public Mat RunGaussianFilter(Mat inputImage, int kernelSize)
        {
            Mat outputImage = new Mat();
            Cv2.GaussianBlur(inputImage, outputImage, new Size(kernelSize, kernelSize), 0);

            return outputImage;
        }

        /// <summary>
        /// ガンマ補正を実行する
        /// </summary>
        public Mat RunGammaCorrect(Mat inputImage, double gammaValue)
        {
            Mat lut = new Mat(ImageParam.pixelValueMax + 1, 1, MatType.CV_8UC1);
            for (int i = 0; i < lut.Rows; i++)
            {
                lut.At<byte>(i, 1) = (byte)(Math.Pow((double)i / (double)ImageParam.pixelValueMax, 1 / gammaValue) * (double)ImageParam.pixelValueMax);
            }

            Mat outputImage = new Mat();
            Cv2.LUT(inputImage, lut, outputImage);

            return outputImage;
        }
    }
}
