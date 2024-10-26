namespace DarkScript3
{
    partial class GameChooser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ds1Btn = new System.Windows.Forms.Button();
            bbBtn = new System.Windows.Forms.Button();
            ds3Btn = new System.Windows.Forms.Button();
            sekiroBtn = new System.Windows.Forms.Button();
            ds2Btn = new System.Windows.Forms.Button();
            ds2scholarBtn = new System.Windows.Forms.Button();
            fancy = new System.Windows.Forms.CheckBox();
            fancyLabel = new System.Windows.Forms.Label();
            customBtn = new System.Windows.Forms.Button();
            eldenBtn = new System.Windows.Forms.Button();
            ac6Button = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ds1Btn
            // 
            this.ds1Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ds1Btn.Location = new System.Drawing.Point(12, 12);
            this.ds1Btn.Name = "ds1Btn";
            this.ds1Btn.Size = new System.Drawing.Size(141, 23);
            this.ds1Btn.TabIndex = 0;
            this.ds1Btn.Text = "Dark Souls";
            this.ds1Btn.UseVisualStyleBackColor = true;
            this.ds1Btn.Click += new System.EventHandler(this.Ds1Btn_Click);
            // 
            // bbBtn
            // 
            bbBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            bbBtn.Location = new System.Drawing.Point(15, 47);
            bbBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            bbBtn.Name = "bbBtn";
            bbBtn.Size = new System.Drawing.Size(164, 27);
            bbBtn.TabIndex = 1;
            bbBtn.Text = "Bloodborne";
            bbBtn.UseVisualStyleBackColor = true;
            bbBtn.Click += BbBtn_Click;
            // 
            // ds3Btn
            // 
            this.ds3Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ds3Btn.Location = new System.Drawing.Point(12, 127);
            this.ds3Btn.Name = "ds3Btn";
            this.ds3Btn.Size = new System.Drawing.Size(141, 23);
            this.ds3Btn.TabIndex = 2;
            this.ds3Btn.Text = "Dark Souls III";
            this.ds3Btn.UseVisualStyleBackColor = true;
            this.ds3Btn.Click += new System.EventHandler(this.Ds3Btn_Click);
            // 
            // sekiroBtn
            // 
            this.sekiroBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sekiroBtn.Location = new System.Drawing.Point(12, 156);
            this.sekiroBtn.Name = "sekiroBtn";
            this.sekiroBtn.Size = new System.Drawing.Size(141, 23);
            this.sekiroBtn.TabIndex = 3;
            this.sekiroBtn.Text = "Sekiro";
            this.sekiroBtn.UseVisualStyleBackColor = true;
            this.sekiroBtn.Click += new System.EventHandler(this.SekiroBtn_Click);
            // 
            // ds2Btn
            // 
            this.ds2Btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ds2Btn.Location = new System.Drawing.Point(12, 70);
            this.ds2Btn.Name = "ds2Btn";
            this.ds2Btn.Size = new System.Drawing.Size(141, 23);
            this.ds2Btn.TabIndex = 4;
            this.ds2Btn.Text = "Dark Souls II";
            this.ds2Btn.UseVisualStyleBackColor = true;
            this.ds2Btn.Click += new System.EventHandler(this.ds2Btn_Click);
            // 
            // ds2scholarBtn
            // 
            this.ds2scholarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ds2scholarBtn.Location = new System.Drawing.Point(12, 99);
            this.ds2scholarBtn.Name = "ds2scholarBtn";
            this.ds2scholarBtn.Size = new System.Drawing.Size(141, 23);
            this.ds2scholarBtn.TabIndex = 5;
            this.ds2scholarBtn.Text = "Dark Souls II SOTFS";
            this.ds2scholarBtn.UseVisualStyleBackColor = true;
            this.ds2scholarBtn.Click += new System.EventHandler(this.ds2scholarBtn_Click);
            // 
            // fancy
            // 
            fancy.AutoSize = true;
            fancy.Location = new System.Drawing.Point(14, 312);
            fancy.Margin = new System.Windows.Forms.Padding(2);
            fancy.Name = "fancy";
            fancy.Size = new System.Drawing.Size(103, 19);
            fancy.TabIndex = 6;
            fancy.Text = "Use MattScript";
            fancy.UseVisualStyleBackColor = true;
            fancy.CheckedChanged += fancy_CheckedChanged;
            // 
            // fancyLabel
            // 
            fancyLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            fancyLabel.Location = new System.Drawing.Point(10, 334);
            fancyLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fancyLabel.Name = "fancyLabel";
            fancyLabel.Size = new System.Drawing.Size(168, 39);
            fancyLabel.TabIndex = 7;
            fancyLabel.Text = "(Formats scripts to make them easier to understand)";
            // 
            // customBtn
            // 
            customBtn.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            customBtn.Location = new System.Drawing.Point(15, 278);
            customBtn.Margin = new System.Windows.Forms.Padding(2);
            customBtn.Name = "customBtn";
            customBtn.Size = new System.Drawing.Size(164, 30);
            customBtn.TabIndex = 6;
            customBtn.Text = "Custom EMEDF...";
            customBtn.UseVisualStyleBackColor = true;
            customBtn.Click += customBtn_Click;
            
            // 
            // eldenBtn
            // 
            this.eldenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eldenBtn.Location = new System.Drawing.Point(12, 185);
            this.eldenBtn.Name = "eldenBtn";
            this.eldenBtn.Size = new System.Drawing.Size(141, 23);
            this.eldenBtn.TabIndex = 8;
            this.eldenBtn.Text = "Elden Ring";
            this.eldenBtn.UseVisualStyleBackColor = true;
            this.eldenBtn.Click += new System.EventHandler(this.eldenBtn_Click);
            // 
            // ac6Button
            // 
            ac6Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            ac6Button.Location = new System.Drawing.Point(15, 246);
            ac6Button.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ac6Button.Name = "ac6Button";
            ac6Button.Size = new System.Drawing.Size(164, 27);
            ac6Button.TabIndex = 9;
            ac6Button.Text = "Armored Core VI";
            ac6Button.UseVisualStyleBackColor = true;
            ac6Button.Click += ac6Btn_Click;
            // 
            // GameChooser
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(192, 386);
            Controls.Add(ac6Button);
            Controls.Add(eldenBtn);
            Controls.Add(fancyLabel);
            Controls.Add(fancy);
            Controls.Add(customBtn);
            Controls.Add(ds2scholarBtn);
            Controls.Add(ds2Btn);
            Controls.Add(sekiroBtn);
            Controls.Add(ds3Btn);
            Controls.Add(bbBtn);
            Controls.Add(ds1Btn);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            KeyPreview = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "GameChooser";
            Text = "GameChooser";
            KeyDown += GameChooser_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button ds1Btn;
        private System.Windows.Forms.Button bbBtn;
        private System.Windows.Forms.Button ds3Btn;
        private System.Windows.Forms.Button sekiroBtn;
        private System.Windows.Forms.Button ds2Btn;
        private System.Windows.Forms.Button ds2scholarBtn;
        private System.Windows.Forms.CheckBox fancy;
        private System.Windows.Forms.Label fancyLabel;
        private System.Windows.Forms.Button customBtn;
        private System.Windows.Forms.Button eldenBtn;
        private System.Windows.Forms.Button ac6Button;
    }
}