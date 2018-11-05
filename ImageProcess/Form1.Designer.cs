namespace ImageProcess
{
    partial class FrmImage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.picAfter = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDiffusion = new System.Windows.Forms.Button();
            this.btnSharpen = new System.Windows.Forms.Button();
            this.btnMosaic = new System.Windows.Forms.Button();
            this.btnHorse = new System.Windows.Forms.Button();
            this.btnRelief = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picOriginal.Location = new System.Drawing.Point(162, 28);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(352, 464);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnOpenImage.Location = new System.Drawing.Point(24, 208);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(76, 46);
            this.btnOpenImage.TabIndex = 1;
            this.btnOpenImage.Text = "打开";
            this.btnOpenImage.UseVisualStyleBackColor = false;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(152, 539);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(91, 46);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "底片";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(306, 539);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(91, 46);
            this.btnGray.TabIndex = 1;
            this.btnGray.Text = "灰度化";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // picAfter
            // 
            this.picAfter.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picAfter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAfter.Location = new System.Drawing.Point(817, 28);
            this.picAfter.Name = "picAfter";
            this.picAfter.Size = new System.Drawing.Size(352, 464);
            this.picAfter.TabIndex = 0;
            this.picAfter.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(24, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 46);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDiffusion
            // 
            this.btnDiffusion.Location = new System.Drawing.Point(460, 539);
            this.btnDiffusion.Name = "btnDiffusion";
            this.btnDiffusion.Size = new System.Drawing.Size(91, 46);
            this.btnDiffusion.TabIndex = 1;
            this.btnDiffusion.Text = "柔化";
            this.btnDiffusion.UseVisualStyleBackColor = true;
            this.btnDiffusion.Click += new System.EventHandler(this.btnDiffusion_Click);
            // 
            // btnSharpen
            // 
            this.btnSharpen.Location = new System.Drawing.Point(614, 539);
            this.btnSharpen.Name = "btnSharpen";
            this.btnSharpen.Size = new System.Drawing.Size(91, 46);
            this.btnSharpen.TabIndex = 1;
            this.btnSharpen.Text = "锐化";
            this.btnSharpen.UseVisualStyleBackColor = true;
            this.btnSharpen.Click += new System.EventHandler(this.btnSharpen_Click);
            // 
            // btnMosaic
            // 
            this.btnMosaic.Location = new System.Drawing.Point(768, 539);
            this.btnMosaic.Name = "btnMosaic";
            this.btnMosaic.Size = new System.Drawing.Size(91, 46);
            this.btnMosaic.TabIndex = 1;
            this.btnMosaic.Text = "马赛克";
            this.btnMosaic.UseVisualStyleBackColor = true;
            this.btnMosaic.Click += new System.EventHandler(this.btnMosaic_Click);
            // 
            // btnHorse
            // 
            this.btnHorse.Location = new System.Drawing.Point(922, 539);
            this.btnHorse.Name = "btnHorse";
            this.btnHorse.Size = new System.Drawing.Size(91, 46);
            this.btnHorse.TabIndex = 1;
            this.btnHorse.Text = "雾化";
            this.btnHorse.UseVisualStyleBackColor = true;
            this.btnHorse.Click += new System.EventHandler(this.btnHorse_Click);
            // 
            // btnRelief
            // 
            this.btnRelief.Location = new System.Drawing.Point(1076, 539);
            this.btnRelief.Name = "btnRelief";
            this.btnRelief.Size = new System.Drawing.Size(91, 46);
            this.btnRelief.TabIndex = 1;
            this.btnRelief.Text = "浮雕";
            this.btnRelief.UseVisualStyleBackColor = true;
            this.btnRelief.Click += new System.EventHandler(this.btnRelief_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 651);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRelief);
            this.Controls.Add(this.btnHorse);
            this.Controls.Add(this.btnMosaic);
            this.Controls.Add(this.btnSharpen);
            this.Controls.Add(this.btnDiffusion);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.picAfter);
            this.Controls.Add(this.picOriginal);
            this.Name = "FrmImage";
            this.Text = "图像处理";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAfter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.PictureBox picAfter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDiffusion;
        private System.Windows.Forms.Button btnSharpen;
        private System.Windows.Forms.Button btnMosaic;
        private System.Windows.Forms.Button btnHorse;
        private System.Windows.Forms.Button btnRelief;
    }
}

