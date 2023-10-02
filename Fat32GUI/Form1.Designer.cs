namespace Fat32GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbVolumes = new System.Windows.Forms.ComboBox();
            this.lblselect = new System.Windows.Forms.Label();
            this.txtVolInfo = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbVolumes
            // 
            this.cmbVolumes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVolumes.FormattingEnabled = true;
            this.cmbVolumes.Location = new System.Drawing.Point(71, 15);
            this.cmbVolumes.Margin = new System.Windows.Forms.Padding(2);
            this.cmbVolumes.Name = "cmbVolumes";
            this.cmbVolumes.Size = new System.Drawing.Size(85, 21);
            this.cmbVolumes.TabIndex = 3;
            this.cmbVolumes.SelectedIndexChanged += new System.EventHandler(this.cmbVolumes_SelectedIndexChanged);
            // 
            // lblselect
            // 
            this.lblselect.AutoSize = true;
            this.lblselect.Location = new System.Drawing.Point(4, 18);
            this.lblselect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblselect.Name = "lblselect";
            this.lblselect.Size = new System.Drawing.Size(63, 13);
            this.lblselect.TabIndex = 4;
            this.lblselect.Text = "Select drive";
            // 
            // txtVolInfo
            // 
            this.txtVolInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtVolInfo.Location = new System.Drawing.Point(7, 41);
            this.txtVolInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVolInfo.Multiline = true;
            this.txtVolInfo.Name = "txtVolInfo";
            this.txtVolInfo.ReadOnly = true;
            this.txtVolInfo.Size = new System.Drawing.Size(181, 59);
            this.txtVolInfo.TabIndex = 5;
            // 
            // btnFormat
            // 
            this.btnFormat.Enabled = false;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(7, 128);
            this.btnFormat.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(181, 44);
            this.btnFormat.TabIndex = 6;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.btnFormat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLabel);
            this.groupBox1.Controls.Add(this.cmbVolumes);
            this.groupBox1.Controls.Add(this.btnFormat);
            this.groupBox1.Controls.Add(this.txtVolInfo);
            this.groupBox1.Controls.Add(this.lblselect);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(193, 182);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(165, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Label";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(41, 104);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(2);
            this.txtLabel.MaxLength = 11;
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(147, 20);
            this.txtLabel.TabIndex = 7;
            this.txtLabel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabel_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 195);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Fat32GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbVolumes;
        private System.Windows.Forms.Label lblselect;
        private System.Windows.Forms.TextBox txtVolInfo;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

