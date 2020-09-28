namespace thince2b2
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
            this.txtAmountAustralia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.txtUSDEuro = new System.Windows.Forms.TextBox();
            this.txtRateEuro = new System.Windows.Forms.TextBox();
            this.txtAmountEuro = new System.Windows.Forms.TextBox();
            this.txtUSDKrone = new System.Windows.Forms.TextBox();
            this.txtRateKrone = new System.Windows.Forms.TextBox();
            this.txtAmountKrone = new System.Windows.Forms.TextBox();
            this.txtUSDBhutan = new System.Windows.Forms.TextBox();
            this.txtRateBhutan = new System.Windows.Forms.TextBox();
            this.txtUSDAustralia = new System.Windows.Forms.TextBox();
            this.txtRateAustralia = new System.Windows.Forms.TextBox();
            this.txtAmountBhutan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAmountAustralia
            // 
            this.txtAmountAustralia.Location = new System.Drawing.Point(87, 139);
            this.txtAmountAustralia.Name = "txtAmountAustralia";
            this.txtAmountAustralia.Size = new System.Drawing.Size(127, 20);
            this.txtAmountAustralia.TabIndex = 44;
            this.txtAmountAustralia.Text = "0.00";
            this.txtAmountAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(638, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 20);
            this.label9.TabIndex = 72;
            this.label9.Text = "+";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "$US";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 51;
            this.label6.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Amount:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(353, 217);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 23);
            this.btnExit.TabIndex = 49;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(220, 217);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 23);
            this.btnReset.TabIndex = 48;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(686, 191);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(127, 20);
            this.txtTotalUSD.TabIndex = 53;
            this.txtTotalUSD.TabStop = false;
            // 
            // txtUSDEuro
            // 
            this.txtUSDEuro.Location = new System.Drawing.Point(486, 191);
            this.txtUSDEuro.Name = "txtUSDEuro";
            this.txtUSDEuro.ReadOnly = true;
            this.txtUSDEuro.Size = new System.Drawing.Size(127, 20);
            this.txtUSDEuro.TabIndex = 71;
            this.txtUSDEuro.TabStop = false;
            this.txtUSDEuro.Text = "0.00";
            this.txtUSDEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateEuro
            // 
            this.txtRateEuro.Location = new System.Drawing.Point(486, 165);
            this.txtRateEuro.Name = "txtRateEuro";
            this.txtRateEuro.Size = new System.Drawing.Size(127, 20);
            this.txtRateEuro.TabIndex = 57;
            this.txtRateEuro.Text = "1.18429";
            this.txtRateEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountEuro
            // 
            this.txtAmountEuro.Location = new System.Drawing.Point(486, 139);
            this.txtAmountEuro.Name = "txtAmountEuro";
            this.txtAmountEuro.Size = new System.Drawing.Size(127, 20);
            this.txtAmountEuro.TabIndex = 47;
            this.txtAmountEuro.Text = "0.00";
            this.txtAmountEuro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountEuro.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDKrone
            // 
            this.txtUSDKrone.Location = new System.Drawing.Point(353, 191);
            this.txtUSDKrone.Name = "txtUSDKrone";
            this.txtUSDKrone.ReadOnly = true;
            this.txtUSDKrone.Size = new System.Drawing.Size(127, 20);
            this.txtUSDKrone.TabIndex = 70;
            this.txtUSDKrone.TabStop = false;
            this.txtUSDKrone.Text = "0.00";
            this.txtUSDKrone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateKrone
            // 
            this.txtRateKrone.Location = new System.Drawing.Point(353, 165);
            this.txtRateKrone.Name = "txtRateKrone";
            this.txtRateKrone.Size = new System.Drawing.Size(127, 20);
            this.txtRateKrone.TabIndex = 56;
            this.txtRateKrone.Text = "0.11943";
            this.txtRateKrone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateKrone.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountKrone
            // 
            this.txtAmountKrone.Location = new System.Drawing.Point(353, 139);
            this.txtAmountKrone.Name = "txtAmountKrone";
            this.txtAmountKrone.Size = new System.Drawing.Size(127, 20);
            this.txtAmountKrone.TabIndex = 46;
            this.txtAmountKrone.Text = "0.00";
            this.txtAmountKrone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountKrone.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDBhutan
            // 
            this.txtUSDBhutan.Location = new System.Drawing.Point(220, 191);
            this.txtUSDBhutan.Name = "txtUSDBhutan";
            this.txtUSDBhutan.ReadOnly = true;
            this.txtUSDBhutan.Size = new System.Drawing.Size(127, 20);
            this.txtUSDBhutan.TabIndex = 69;
            this.txtUSDBhutan.TabStop = false;
            this.txtUSDBhutan.Text = "0.00";
            this.txtUSDBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateBhutan
            // 
            this.txtRateBhutan.Location = new System.Drawing.Point(220, 165);
            this.txtRateBhutan.Name = "txtRateBhutan";
            this.txtRateBhutan.Size = new System.Drawing.Size(127, 20);
            this.txtRateBhutan.TabIndex = 55;
            this.txtRateBhutan.Text = "0.0136087";
            this.txtRateBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateBhutan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtUSDAustralia
            // 
            this.txtUSDAustralia.Location = new System.Drawing.Point(87, 191);
            this.txtUSDAustralia.Name = "txtUSDAustralia";
            this.txtUSDAustralia.ReadOnly = true;
            this.txtUSDAustralia.Size = new System.Drawing.Size(127, 20);
            this.txtUSDAustralia.TabIndex = 68;
            this.txtUSDAustralia.TabStop = false;
            this.txtUSDAustralia.Text = "0.00";
            this.txtUSDAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRateAustralia
            // 
            this.txtRateAustralia.Location = new System.Drawing.Point(87, 165);
            this.txtRateAustralia.Name = "txtRateAustralia";
            this.txtRateAustralia.Size = new System.Drawing.Size(127, 20);
            this.txtRateAustralia.TabIndex = 54;
            this.txtRateAustralia.Text = "0.725832";
            this.txtRateAustralia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRateAustralia.TextChanged += new System.EventHandler(this.calculate);
            // 
            // txtAmountBhutan
            // 
            this.txtAmountBhutan.Location = new System.Drawing.Point(220, 139);
            this.txtAmountBhutan.Name = "txtAmountBhutan";
            this.txtAmountBhutan.Size = new System.Drawing.Size(127, 20);
            this.txtAmountBhutan.TabIndex = 45;
            this.txtAmountBhutan.Text = "0.00";
            this.txtAmountBhutan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmountBhutan.TextChanged += new System.EventHandler(this.calculate);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "American Dollar";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(686, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 106);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 64;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Norwegian krone";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(353, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(127, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 61;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Euro";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(486, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(127, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 60;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Bhutanese Ngultrum";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(220, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 106);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Australian Dollar";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(87, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 274);
            this.Controls.Add(this.txtAmountAustralia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDEuro);
            this.Controls.Add(this.txtRateEuro);
            this.Controls.Add(this.txtAmountEuro);
            this.Controls.Add(this.txtUSDKrone);
            this.Controls.Add(this.txtRateKrone);
            this.Controls.Add(this.txtAmountKrone);
            this.Controls.Add(this.txtUSDBhutan);
            this.Controls.Add(this.txtRateBhutan);
            this.Controls.Add(this.txtUSDAustralia);
            this.Controls.Add(this.txtRateAustralia);
            this.Controls.Add(this.txtAmountBhutan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAmountAustralia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDEuro;
        private System.Windows.Forms.TextBox txtRateEuro;
        private System.Windows.Forms.TextBox txtAmountEuro;
        private System.Windows.Forms.TextBox txtUSDKrone;
        private System.Windows.Forms.TextBox txtRateKrone;
        private System.Windows.Forms.TextBox txtAmountKrone;
        private System.Windows.Forms.TextBox txtUSDBhutan;
        private System.Windows.Forms.TextBox txtRateBhutan;
        private System.Windows.Forms.TextBox txtUSDAustralia;
        private System.Windows.Forms.TextBox txtRateAustralia;
        private System.Windows.Forms.TextBox txtAmountBhutan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

