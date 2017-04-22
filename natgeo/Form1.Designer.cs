namespace natgeo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblTotalCurrent = new System.Windows.Forms.Label();
            this.tmrPollLJ = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ctlBargraph1 = new natgeo.ctlBargraph();
            this.dougScrollingTextCtrl1 = new DougScrollingText.DougScrollingTextCtrl();
            this.pictureBoxNatgeoLogoRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxEarthdayRunLogoLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNatgeoLogoRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEarthdayRunLogoLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalCurrent
            // 
            this.lblTotalCurrent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTotalCurrent.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCurrent.Font = new System.Drawing.Font("Open 24 Display St", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCurrent.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCurrent.Location = new System.Drawing.Point(12, 59);
            this.lblTotalCurrent.Name = "lblTotalCurrent";
            this.lblTotalCurrent.Size = new System.Drawing.Size(935, 61);
            this.lblTotalCurrent.TabIndex = 0;
            this.lblTotalCurrent.Text = "asdf";
            this.lblTotalCurrent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrPollLJ
            // 
            this.tmrPollLJ.Tick += new System.EventHandler(this.tmrPollLJ_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(935, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "this event needs 400W\r\nLet\'s start pedalling!\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ctlBargraph1
            // 
            this.ctlBargraph1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctlBargraph1.BackColor = System.Drawing.Color.Transparent;
            this.ctlBargraph1.Location = new System.Drawing.Point(12, 195);
            this.ctlBargraph1.Name = "ctlBargraph1";
            this.ctlBargraph1.Size = new System.Drawing.Size(935, 419);
            this.ctlBargraph1.TabIndex = 4;
            // 
            // dougScrollingTextCtrl1
            // 
            this.dougScrollingTextCtrl1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dougScrollingTextCtrl1.BackColor = System.Drawing.Color.White;
            this.dougScrollingTextCtrl1.ForeColor = System.Drawing.Color.Black;
            this.dougScrollingTextCtrl1.Location = new System.Drawing.Point(12, 12);
            this.dougScrollingTextCtrl1.Name = "dougScrollingTextCtrl1";
            this.dougScrollingTextCtrl1.Size = new System.Drawing.Size(935, 44);
            this.dougScrollingTextCtrl1.TabIndex = 2;
            this.dougScrollingTextCtrl1.Text = "National Geographic Channel Earth day Run 2017";
            // 
            // pictureBox1
            // 
            this.pictureBoxNatgeoLogoRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxNatgeoLogoRight.Image = global::natgeo.Properties.Resources.NAT_Geo_Logo;
            this.pictureBoxNatgeoLogoRight.Location = new System.Drawing.Point(657, 0);
            this.pictureBoxNatgeoLogoRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxNatgeoLogoRight.Name = "pictureBoxNatgeoLogoRight";
            this.pictureBoxNatgeoLogoRight.Size = new System.Drawing.Size(300, 90);
            this.pictureBoxNatgeoLogoRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNatgeoLogoRight.TabIndex = 5;
            this.pictureBoxNatgeoLogoRight.TabStop = false;
            // 
            // pictureBoxEarthdayRunLogoLeft
            // 
            this.pictureBoxEarthdayRunLogoLeft.Image = global::natgeo.Properties.Resources.NAT_Geo_Logo_EarthDayRunSolid;
            this.pictureBoxEarthdayRunLogoLeft.Location = new System.Drawing.Point(-15, -20);
            this.pictureBoxEarthdayRunLogoLeft.Name = "pictureBoxEarthdayRunLogoLeft";
            this.pictureBoxEarthdayRunLogoLeft.Size = new System.Drawing.Size(266, 205);
            this.pictureBoxEarthdayRunLogoLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEarthdayRunLogoLeft.TabIndex = 6;
            this.pictureBoxEarthdayRunLogoLeft.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::natgeo.Properties.Resources.NAT_Geo_LogoEarthDayRunTransparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(959, 626);
            this.Controls.Add(this.pictureBoxEarthdayRunLogoLeft);
            this.Controls.Add(this.pictureBoxNatgeoLogoRight);
            this.Controls.Add(this.ctlBargraph1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dougScrollingTextCtrl1);
            this.Controls.Add(this.lblTotalCurrent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNatgeoLogoRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEarthdayRunLogoLeft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTotalCurrent;
        private System.Windows.Forms.Timer tmrPollLJ;
        private DougScrollingText.DougScrollingTextCtrl dougScrollingTextCtrl1;
        private System.Windows.Forms.Label label1;
        private ctlBargraph ctlBargraph1;
        private System.Windows.Forms.PictureBox pictureBoxNatgeoLogoRight;
        private System.Windows.Forms.PictureBox pictureBoxEarthdayRunLogoLeft;
    }
}

