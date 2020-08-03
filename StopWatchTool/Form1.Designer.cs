namespace StopWatchTool
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.CustomFormCloseButton = new System.Windows.Forms.Button();
            this.StopWatchValueHolder = new System.Windows.Forms.Label();
            this.StopWatchSplitResetButton = new System.Windows.Forms.Button();
            this.StopWatchStartStopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "StopWatchTool";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // CustomFormCloseButton
            // 
            this.CustomFormCloseButton.BackColor = System.Drawing.Color.Red;
            this.CustomFormCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CustomFormCloseButton.ForeColor = System.Drawing.Color.White;
            this.CustomFormCloseButton.Location = new System.Drawing.Point(122, 8);
            this.CustomFormCloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CustomFormCloseButton.Name = "CustomFormCloseButton";
            this.CustomFormCloseButton.Size = new System.Drawing.Size(22, 23);
            this.CustomFormCloseButton.TabIndex = 1;
            this.CustomFormCloseButton.Text = "×";
            this.CustomFormCloseButton.UseVisualStyleBackColor = false;
            this.CustomFormCloseButton.Click += new System.EventHandler(this.CustomFormCloseButton_Click);
            // 
            // StopWatchValueHolder
            // 
            this.StopWatchValueHolder.AutoSize = true;
            this.StopWatchValueHolder.Location = new System.Drawing.Point(13, 38);
            this.StopWatchValueHolder.Name = "StopWatchValueHolder";
            this.StopWatchValueHolder.Size = new System.Drawing.Size(35, 12);
            this.StopWatchValueHolder.TabIndex = 2;
            this.StopWatchValueHolder.Text = "label2";
            // 
            // StopWatchSplitResetButton
            // 
            this.StopWatchSplitResetButton.Location = new System.Drawing.Point(12, 62);
            this.StopWatchSplitResetButton.Name = "StopWatchSplitResetButton";
            this.StopWatchSplitResetButton.Size = new System.Drawing.Size(61, 23);
            this.StopWatchSplitResetButton.TabIndex = 3;
            this.StopWatchSplitResetButton.Text = "Reset";
            this.StopWatchSplitResetButton.UseVisualStyleBackColor = true;
            this.StopWatchSplitResetButton.Click += new System.EventHandler(this.StopWatchSplitResetButton_Click);
            // 
            // StopWatchStartStopButton
            // 
            this.StopWatchStartStopButton.Location = new System.Drawing.Point(72, 62);
            this.StopWatchStartStopButton.Name = "StopWatchStartStopButton";
            this.StopWatchStartStopButton.Size = new System.Drawing.Size(60, 23);
            this.StopWatchStartStopButton.TabIndex = 4;
            this.StopWatchStartStopButton.Text = "Start";
            this.StopWatchStartStopButton.UseVisualStyleBackColor = true;
            this.StopWatchStartStopButton.Click += new System.EventHandler(this.StopWatchStartStopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(150, 97);
            this.Controls.Add(this.StopWatchStartStopButton);
            this.Controls.Add(this.StopWatchSplitResetButton);
            this.Controls.Add(this.StopWatchValueHolder);
            this.Controls.Add(this.CustomFormCloseButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CustomFormCloseButton;
        private System.Windows.Forms.Label StopWatchValueHolder;
        private System.Windows.Forms.Button StopWatchSplitResetButton;
        private System.Windows.Forms.Button StopWatchStartStopButton;
    }
}

