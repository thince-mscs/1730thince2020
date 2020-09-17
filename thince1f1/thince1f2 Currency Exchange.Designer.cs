namespace thince1f1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.picKroneDim = new System.Windows.Forms.PictureBox();
            this.picEuroDim = new System.Windows.Forms.PictureBox();
            this.picBhutanDim = new System.Windows.Forms.PictureBox();
            this.picAustraliaDim = new System.Windows.Forms.PictureBox();
            this.picEuro = new System.Windows.Forms.PictureBox();
            this.picKrone = new System.Windows.Forms.PictureBox();
            this.picBhutan = new System.Windows.Forms.PictureBox();
            this.picAustralia = new System.Windows.Forms.PictureBox();
            this.btnAustralia = new System.Windows.Forms.Button();
            this.btnBhutan = new System.Windows.Forms.Button();
            this.btnKrone = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtUSDollars = new System.Windows.Forms.TextBox();
            this.txtTotalUSD = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblEquation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picKroneDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEuroDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBhutanDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAustraliaDim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEuro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBhutan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAustralia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Rate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "$US";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(182, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 23);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(288, 262);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(182, 162);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(100, 20);
            this.txtCurrency.TabIndex = 5;
            this.txtCurrency.Text = "0.00";
            this.txtCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCurrency.TextChanged += new System.EventHandler(this.calcUSD);
            // 
            // picKroneDim
            // 
            this.picKroneDim.Image = global::thince1f1.Properties.Resources.Jan_Mayen_Flag_icondim;
            this.picKroneDim.Location = new System.Drawing.Point(320, 410);
            this.picKroneDim.Name = "picKroneDim";
            this.picKroneDim.Size = new System.Drawing.Size(131, 92);
            this.picKroneDim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKroneDim.TabIndex = 41;
            this.picKroneDim.TabStop = false;
            this.picKroneDim.Visible = false;
            // 
            // picEuroDim
            // 
            this.picEuroDim.Image = global::thince1f1.Properties.Resources.Finland_Flag_icondim;
            this.picEuroDim.Location = new System.Drawing.Point(457, 410);
            this.picEuroDim.Name = "picEuroDim";
            this.picEuroDim.Size = new System.Drawing.Size(131, 92);
            this.picEuroDim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEuroDim.TabIndex = 40;
            this.picEuroDim.TabStop = false;
            this.picEuroDim.Visible = false;
            // 
            // picBhutanDim
            // 
            this.picBhutanDim.Image = global::thince1f1.Properties.Resources.Bhutan_Flag_icon;
            this.picBhutanDim.Location = new System.Drawing.Point(173, 410);
            this.picBhutanDim.Name = "picBhutanDim";
            this.picBhutanDim.Size = new System.Drawing.Size(131, 92);
            this.picBhutanDim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBhutanDim.TabIndex = 39;
            this.picBhutanDim.TabStop = false;
            this.picBhutanDim.Visible = false;
            // 
            // picAustraliaDim
            // 
            this.picAustraliaDim.Image = global::thince1f1.Properties.Resources.Australia_Flag_icon;
            this.picAustraliaDim.Location = new System.Drawing.Point(36, 410);
            this.picAustraliaDim.Name = "picAustraliaDim";
            this.picAustraliaDim.Size = new System.Drawing.Size(131, 92);
            this.picAustraliaDim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAustraliaDim.TabIndex = 38;
            this.picAustraliaDim.TabStop = false;
            this.picAustraliaDim.Visible = false;
            // 
            // picEuro
            // 
            this.picEuro.Image = global::thince1f1.Properties.Resources.Finland_Flag_icon1;
            this.picEuro.Location = new System.Drawing.Point(457, 312);
            this.picEuro.Name = "picEuro";
            this.picEuro.Size = new System.Drawing.Size(131, 92);
            this.picEuro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEuro.TabIndex = 37;
            this.picEuro.TabStop = false;
            this.picEuro.Visible = false;
            // 
            // picKrone
            // 
            this.picKrone.Image = global::thince1f1.Properties.Resources.Jan_Mayen_Flag_icon;
            this.picKrone.Location = new System.Drawing.Point(320, 312);
            this.picKrone.Name = "picKrone";
            this.picKrone.Size = new System.Drawing.Size(131, 92);
            this.picKrone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKrone.TabIndex = 36;
            this.picKrone.TabStop = false;
            this.picKrone.Visible = false;
            // 
            // picBhutan
            // 
            this.picBhutan.Image = global::thince1f1.Properties.Resources.Bhutan_Flag_icon1;
            this.picBhutan.Location = new System.Drawing.Point(173, 312);
            this.picBhutan.Name = "picBhutan";
            this.picBhutan.Size = new System.Drawing.Size(131, 92);
            this.picBhutan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBhutan.TabIndex = 35;
            this.picBhutan.TabStop = false;
            this.picBhutan.Visible = false;
            // 
            // picAustralia
            // 
            this.picAustralia.Image = global::thince1f1.Properties.Resources.Australia_Flag_icon_nondim;
            this.picAustralia.Location = new System.Drawing.Point(36, 312);
            this.picAustralia.Name = "picAustralia";
            this.picAustralia.Size = new System.Drawing.Size(131, 92);
            this.picAustralia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAustralia.TabIndex = 34;
            this.picAustralia.TabStop = false;
            this.picAustralia.Visible = false;
            // 
            // btnAustralia
            // 
            this.btnAustralia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAustralia.Location = new System.Drawing.Point(36, 32);
            this.btnAustralia.Name = "btnAustralia";
            this.btnAustralia.Size = new System.Drawing.Size(120, 89);
            this.btnAustralia.TabIndex = 1;
            this.btnAustralia.Text = "Australian Dollar";
            this.btnAustralia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAustralia.UseVisualStyleBackColor = true;
            this.btnAustralia.Click += new System.EventHandler(this.btnAustralia_Click);
            // 
            // btnBhutan
            // 
            this.btnBhutan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBhutan.Location = new System.Drawing.Point(162, 32);
            this.btnBhutan.Name = "btnBhutan";
            this.btnBhutan.Size = new System.Drawing.Size(120, 89);
            this.btnBhutan.TabIndex = 2;
            this.btnBhutan.Text = "Bhutanese Ngultrum";
            this.btnBhutan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBhutan.UseVisualStyleBackColor = true;
            this.btnBhutan.Click += new System.EventHandler(this.btnBhutan_Click);
            // 
            // btnKrone
            // 
            this.btnKrone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKrone.Location = new System.Drawing.Point(288, 32);
            this.btnKrone.Name = "btnKrone";
            this.btnKrone.Size = new System.Drawing.Size(120, 89);
            this.btnKrone.TabIndex = 3;
            this.btnKrone.Text = "Norwegian krone";
            this.btnKrone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKrone.UseVisualStyleBackColor = true;
            this.btnKrone.Click += new System.EventHandler(this.btnKrone_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEuro.Location = new System.Drawing.Point(414, 32);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(120, 89);
            this.btnEuro.TabIndex = 4;
            this.btnEuro.Text = "Euro";
            this.btnEuro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // lblCurrency
            // 
            this.lblCurrency.BackColor = System.Drawing.Color.Silver;
            this.lblCurrency.Location = new System.Drawing.Point(31, 162);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(125, 25);
            this.lblCurrency.TabIndex = 20;
            this.lblCurrency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(182, 188);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "0.00";
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRate.TextChanged += new System.EventHandler(this.calcUSD);
            // 
            // txtUSDollars
            // 
            this.txtUSDollars.Location = new System.Drawing.Point(182, 214);
            this.txtUSDollars.Name = "txtUSDollars";
            this.txtUSDollars.ReadOnly = true;
            this.txtUSDollars.Size = new System.Drawing.Size(100, 20);
            this.txtUSDollars.TabIndex = 48;
            this.txtUSDollars.TabStop = false;
            this.txtUSDollars.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalUSD
            // 
            this.txtTotalUSD.Location = new System.Drawing.Point(182, 240);
            this.txtTotalUSD.Name = "txtTotalUSD";
            this.txtTotalUSD.ReadOnly = true;
            this.txtTotalUSD.Size = new System.Drawing.Size(100, 20);
            this.txtTotalUSD.TabIndex = 49;
            this.txtTotalUSD.TabStop = false;
            this.txtTotalUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(288, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(31, 20);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblEquation
            // 
            this.lblEquation.BackColor = System.Drawing.Color.Silver;
            this.lblEquation.Location = new System.Drawing.Point(34, 240);
            this.lblEquation.Name = "lblEquation";
            this.lblEquation.Size = new System.Drawing.Size(125, 45);
            this.lblEquation.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 305);
            this.Controls.Add(this.lblEquation);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTotalUSD);
            this.Controls.Add(this.txtUSDollars);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnKrone);
            this.Controls.Add(this.btnBhutan);
            this.Controls.Add(this.btnAustralia);
            this.Controls.Add(this.picKroneDim);
            this.Controls.Add(this.picEuroDim);
            this.Controls.Add(this.picBhutanDim);
            this.Controls.Add(this.picAustraliaDim);
            this.Controls.Add(this.picEuro);
            this.Controls.Add(this.picKrone);
            this.Controls.Add(this.picBhutan);
            this.Controls.Add(this.picAustralia);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "thince1f1 Currency Exchange";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picKroneDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEuroDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBhutanDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAustraliaDim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEuro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKrone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBhutan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAustralia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.PictureBox picAustralia;
        private System.Windows.Forms.PictureBox picEuro;
        private System.Windows.Forms.PictureBox picKrone;
        private System.Windows.Forms.PictureBox picBhutan;
        private System.Windows.Forms.PictureBox picAustraliaDim;
        private System.Windows.Forms.PictureBox picEuroDim;
        private System.Windows.Forms.PictureBox picBhutanDim;
        private System.Windows.Forms.PictureBox picKroneDim;
        private System.Windows.Forms.Button btnAustralia;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnKrone;
        private System.Windows.Forms.Button btnBhutan;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox txtTotalUSD;
        private System.Windows.Forms.TextBox txtUSDollars;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblEquation;
    }
}

