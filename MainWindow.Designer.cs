using System.Windows.Forms;

namespace BasicImageProcApp
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InputImageArea = new System.Windows.Forms.PictureBox();
            this.OutputImageArea = new System.Windows.Forms.PictureBox();
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.MessageArea = new System.Windows.Forms.TextBox();
            this.InputImageLabel = new System.Windows.Forms.Label();
            this.OutputImageLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.InputImageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OutputImageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RunGaussianFilterButton = new System.Windows.Forms.Button();
            this.KernelSizeLabel = new System.Windows.Forms.Label();
            this.KernelSizeTextBox = new System.Windows.Forms.TextBox();
            this.GammaValueLabel = new System.Windows.Forms.Label();
            this.GammaValueTextBox = new System.Windows.Forms.TextBox();
            this.RunGammaCorrectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InputImageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // InputImageArea
            // 
            this.InputImageArea.BackColor = System.Drawing.SystemColors.Control;
            this.InputImageArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputImageArea.Location = new System.Drawing.Point(27, 51);
            this.InputImageArea.Name = "InputImageArea";
            this.InputImageArea.Size = new System.Drawing.Size(420, 420);
            this.InputImageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InputImageArea.TabIndex = 0;
            this.InputImageArea.TabStop = false;
            // 
            // OutputImageArea
            // 
            this.OutputImageArea.BackColor = System.Drawing.SystemColors.Control;
            this.OutputImageArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputImageArea.Location = new System.Drawing.Point(484, 51);
            this.OutputImageArea.Name = "OutputImageArea";
            this.OutputImageArea.Size = new System.Drawing.Size(420, 420);
            this.OutputImageArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.OutputImageArea.TabIndex = 1;
            this.OutputImageArea.TabStop = false;
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(937, 51);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(120, 25);
            this.SelectFileButton.TabIndex = 2;
            this.SelectFileButton.Text = "ファイル選択";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // MessageArea
            // 
            this.MessageArea.BackColor = System.Drawing.SystemColors.Control;
            this.MessageArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessageArea.Location = new System.Drawing.Point(27, 709);
            this.MessageArea.Multiline = true;
            this.MessageArea.Name = "MessageArea";
            this.MessageArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.MessageArea.Size = new System.Drawing.Size(877, 100);
            this.MessageArea.TabIndex = 10;
            // 
            // InputImageLabel
            // 
            this.InputImageLabel.AutoSize = true;
            this.InputImageLabel.Location = new System.Drawing.Point(24, 33);
            this.InputImageLabel.Name = "InputImageLabel";
            this.InputImageLabel.Size = new System.Drawing.Size(67, 15);
            this.InputImageLabel.TabIndex = 4;
            this.InputImageLabel.Text = "入力画像";
            // 
            // OutputImageLabel
            // 
            this.OutputImageLabel.AutoSize = true;
            this.OutputImageLabel.Location = new System.Drawing.Point(481, 33);
            this.OutputImageLabel.Name = "OutputImageLabel";
            this.OutputImageLabel.Size = new System.Drawing.Size(67, 15);
            this.OutputImageLabel.TabIndex = 5;
            this.OutputImageLabel.Text = "出力画像";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(829, 815);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 25);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "クリア";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InputImageChart
            // 
            this.InputImageChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.InputImageChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.InputImageChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.InputImageChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.InputImageChart.Legends.Add(legend5);
            this.InputImageChart.Location = new System.Drawing.Point(27, 489);
            this.InputImageChart.Name = "InputImageChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.InputImageChart.Series.Add(series5);
            this.InputImageChart.Size = new System.Drawing.Size(420, 200);
            this.InputImageChart.TabIndex = 7;
            this.InputImageChart.Text = "入力画像ヒストグラム";
            // 
            // OutputImageChart
            // 
            this.OutputImageChart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.OutputImageChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.OutputImageChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.OutputImageChart.Legends.Add(legend6);
            this.OutputImageChart.Location = new System.Drawing.Point(484, 489);
            this.OutputImageChart.Name = "OutputImageChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.OutputImageChart.Series.Add(series6);
            this.OutputImageChart.Size = new System.Drawing.Size(420, 200);
            this.OutputImageChart.TabIndex = 9;
            this.OutputImageChart.Text = "出力画像ヒストグラム";
            // 
            // RunGaussianFilterButton
            // 
            this.RunGaussianFilterButton.Location = new System.Drawing.Point(937, 125);
            this.RunGaussianFilterButton.Name = "RunGaussianFilterButton";
            this.RunGaussianFilterButton.Size = new System.Drawing.Size(207, 25);
            this.RunGaussianFilterButton.TabIndex = 13;
            this.RunGaussianFilterButton.Text = "ガウシアンフィルタ実行";
            this.RunGaussianFilterButton.UseVisualStyleBackColor = true;
            this.RunGaussianFilterButton.Click += new System.EventHandler(this.RunGaussianFilterButton_Click);
            // 
            // KernelSizeLabel
            // 
            this.KernelSizeLabel.AutoSize = true;
            this.KernelSizeLabel.Location = new System.Drawing.Point(949, 100);
            this.KernelSizeLabel.Name = "KernelSizeLabel";
            this.KernelSizeLabel.Size = new System.Drawing.Size(89, 15);
            this.KernelSizeLabel.TabIndex = 14;
            this.KernelSizeLabel.Text = "カーネルサイズ";
            // 
            // KernelSizeTextBox
            // 
            this.KernelSizeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KernelSizeTextBox.Location = new System.Drawing.Point(1044, 97);
            this.KernelSizeTextBox.Name = "KernelSizeTextBox";
            this.KernelSizeTextBox.Size = new System.Drawing.Size(100, 22);
            this.KernelSizeTextBox.TabIndex = 15;
            this.KernelSizeTextBox.Text = "3";
            this.KernelSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GammaValueLabel
            // 
            this.GammaValueLabel.AutoSize = true;
            this.GammaValueLabel.Location = new System.Drawing.Point(949, 177);
            this.GammaValueLabel.Name = "GammaValueLabel";
            this.GammaValueLabel.Size = new System.Drawing.Size(56, 15);
            this.GammaValueLabel.TabIndex = 16;
            this.GammaValueLabel.Text = "ガンマ値";
            // 
            // GammaValueTextBox
            // 
            this.GammaValueTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GammaValueTextBox.Location = new System.Drawing.Point(1044, 175);
            this.GammaValueTextBox.Name = "GammaValueTextBox";
            this.GammaValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.GammaValueTextBox.TabIndex = 17;
            this.GammaValueTextBox.Text = "2.2";
            this.GammaValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RunGammaCorrectButton
            // 
            this.RunGammaCorrectButton.Location = new System.Drawing.Point(937, 203);
            this.RunGammaCorrectButton.Name = "RunGammaCorrectButton";
            this.RunGammaCorrectButton.Size = new System.Drawing.Size(207, 25);
            this.RunGammaCorrectButton.TabIndex = 18;
            this.RunGammaCorrectButton.Text = "ガンマ補正実行";
            this.RunGammaCorrectButton.UseVisualStyleBackColor = true;
            this.RunGammaCorrectButton.Click += new System.EventHandler(this.RunGammaCorrectButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.RunGammaCorrectButton);
            this.Controls.Add(this.GammaValueTextBox);
            this.Controls.Add(this.GammaValueLabel);
            this.Controls.Add(this.KernelSizeTextBox);
            this.Controls.Add(this.KernelSizeLabel);
            this.Controls.Add(this.RunGaussianFilterButton);
            this.Controls.Add(this.OutputImageChart);
            this.Controls.Add(this.InputImageChart);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutputImageLabel);
            this.Controls.Add(this.InputImageLabel);
            this.Controls.Add(this.MessageArea);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(this.OutputImageArea);
            this.Controls.Add(this.InputImageArea);
            this.Name = "MainWindow";
            this.Text = "BasicImageProcApp";
            ((System.ComponentModel.ISupportInitialize)(this.InputImageArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputImageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputImageChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox InputImageArea;
        private System.Windows.Forms.PictureBox OutputImageArea;
        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox MessageArea;
        private System.Windows.Forms.Label InputImageLabel;
        private System.Windows.Forms.Label OutputImageLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart InputImageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OutputImageChart;
        private Button RunGaussianFilterButton;
        private Label KernelSizeLabel;
        private TextBox KernelSizeTextBox;
        private Label GammaValueLabel;
        private TextBox GammaValueTextBox;
        private Button RunGammaCorrectButton;
    }
}

