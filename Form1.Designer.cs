namespace Petals
{
    partial class Petals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Petals));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dieOneTxtBox = new System.Windows.Forms.TextBox();
            this.lblDie1 = new System.Windows.Forms.Label();
            this.lblDie2 = new System.Windows.Forms.Label();
            this.dieTwoTxtBox = new System.Windows.Forms.TextBox();
            this.lblDie3 = new System.Windows.Forms.Label();
            this.dieThreeTxtBox = new System.Windows.Forms.TextBox();
            this.lblDie4 = new System.Windows.Forms.Label();
            this.dieFourTxtBox = new System.Windows.Forms.TextBox();
            this.lblDie5 = new System.Windows.Forms.Label();
            this.dieFiveTxtBox = new System.Windows.Forms.TextBox();
            this.lblGuess = new System.Windows.Forms.Label();
            this.guessTxtBx = new System.Windows.Forms.TextBox();
            this.lblTotalRolls = new System.Windows.Forms.Label();
            this.totalRollsTxtBx = new System.Windows.Forms.TextBox();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.numberCorrectTxtBx = new System.Windows.Forms.TextBox();
            this.lblBestRun = new System.Windows.Forms.Label();
            this.bestRunTxtBx = new System.Windows.Forms.TextBox();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.numberIncorrectTxtBx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGameStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Petals.Properties.Resources.dieface1;
            this.pictureBox1.Location = new System.Drawing.Point(70, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Petals.Properties.Resources.dieface2;
            this.pictureBox2.Location = new System.Drawing.Point(195, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 117);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Petals.Properties.Resources.dieface3;
            this.pictureBox3.Location = new System.Drawing.Point(320, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 117);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Petals.Properties.Resources.dieface4;
            this.pictureBox4.Location = new System.Drawing.Point(445, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(119, 117);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Petals.Properties.Resources.dieface5;
            this.pictureBox5.Location = new System.Drawing.Point(570, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(119, 117);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // dieOneTxtBox
            // 
            this.dieOneTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieOneTxtBox.Location = new System.Drawing.Point(70, 203);
            this.dieOneTxtBox.Name = "dieOneTxtBox";
            this.dieOneTxtBox.Size = new System.Drawing.Size(100, 44);
            this.dieOneTxtBox.TabIndex = 6;
            // 
            // lblDie1
            // 
            this.lblDie1.AutoSize = true;
            this.lblDie1.Location = new System.Drawing.Point(70, 184);
            this.lblDie1.Name = "lblDie1";
            this.lblDie1.Size = new System.Drawing.Size(32, 13);
            this.lblDie1.TabIndex = 7;
            this.lblDie1.Text = "Die 1";
            this.lblDie1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDie2
            // 
            this.lblDie2.AutoSize = true;
            this.lblDie2.Location = new System.Drawing.Point(195, 184);
            this.lblDie2.Name = "lblDie2";
            this.lblDie2.Size = new System.Drawing.Size(32, 13);
            this.lblDie2.TabIndex = 9;
            this.lblDie2.Text = "Die 2";
            this.lblDie2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dieTwoTxtBox
            // 
            this.dieTwoTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieTwoTxtBox.Location = new System.Drawing.Point(195, 203);
            this.dieTwoTxtBox.Name = "dieTwoTxtBox";
            this.dieTwoTxtBox.Size = new System.Drawing.Size(100, 44);
            this.dieTwoTxtBox.TabIndex = 8;
            this.dieTwoTxtBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblDie3
            // 
            this.lblDie3.AutoSize = true;
            this.lblDie3.Location = new System.Drawing.Point(320, 184);
            this.lblDie3.Name = "lblDie3";
            this.lblDie3.Size = new System.Drawing.Size(32, 13);
            this.lblDie3.TabIndex = 11;
            this.lblDie3.Text = "Die 3";
            // 
            // dieThreeTxtBox
            // 
            this.dieThreeTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieThreeTxtBox.Location = new System.Drawing.Point(320, 203);
            this.dieThreeTxtBox.Name = "dieThreeTxtBox";
            this.dieThreeTxtBox.Size = new System.Drawing.Size(100, 44);
            this.dieThreeTxtBox.TabIndex = 10;
            // 
            // lblDie4
            // 
            this.lblDie4.AutoSize = true;
            this.lblDie4.Location = new System.Drawing.Point(445, 184);
            this.lblDie4.Name = "lblDie4";
            this.lblDie4.Size = new System.Drawing.Size(32, 13);
            this.lblDie4.TabIndex = 13;
            this.lblDie4.Text = "Die 4";
            // 
            // dieFourTxtBox
            // 
            this.dieFourTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieFourTxtBox.Location = new System.Drawing.Point(445, 203);
            this.dieFourTxtBox.Name = "dieFourTxtBox";
            this.dieFourTxtBox.Size = new System.Drawing.Size(100, 44);
            this.dieFourTxtBox.TabIndex = 12;
            // 
            // lblDie5
            // 
            this.lblDie5.AutoSize = true;
            this.lblDie5.Location = new System.Drawing.Point(570, 184);
            this.lblDie5.Name = "lblDie5";
            this.lblDie5.Size = new System.Drawing.Size(32, 13);
            this.lblDie5.TabIndex = 15;
            this.lblDie5.Text = "Die 5";
            // 
            // dieFiveTxtBox
            // 
            this.dieFiveTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dieFiveTxtBox.Location = new System.Drawing.Point(570, 203);
            this.dieFiveTxtBox.Name = "dieFiveTxtBox";
            this.dieFiveTxtBox.Size = new System.Drawing.Size(100, 44);
            this.dieFiveTxtBox.TabIndex = 14;
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(70, 292);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(62, 13);
            this.lblGuess.TabIndex = 19;
            this.lblGuess.Text = "Your Guess";
            // 
            // guessTxtBx
            // 
            this.guessTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guessTxtBx.Location = new System.Drawing.Point(70, 311);
            this.guessTxtBx.Name = "guessTxtBx";
            this.guessTxtBx.Size = new System.Drawing.Size(100, 44);
            this.guessTxtBx.TabIndex = 18;
            // 
            // lblTotalRolls
            // 
            this.lblTotalRolls.AutoSize = true;
            this.lblTotalRolls.Location = new System.Drawing.Point(275, 319);
            this.lblTotalRolls.Name = "lblTotalRolls";
            this.lblTotalRolls.Size = new System.Drawing.Size(57, 13);
            this.lblTotalRolls.TabIndex = 21;
            this.lblTotalRolls.Text = "Total Rolls";
            this.lblTotalRolls.Click += new System.EventHandler(this.label8_Click);
            // 
            // totalRollsTxtBx
            // 
            this.totalRollsTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalRollsTxtBx.Location = new System.Drawing.Point(278, 335);
            this.totalRollsTxtBx.Name = "totalRollsTxtBx";
            this.totalRollsTxtBx.Size = new System.Drawing.Size(100, 44);
            this.totalRollsTxtBx.TabIndex = 20;
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(278, 382);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(81, 13);
            this.lblCorrect.TabIndex = 23;
            this.lblCorrect.Text = "Number Correct";
            // 
            // numberCorrectTxtBx
            // 
            this.numberCorrectTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberCorrectTxtBx.Location = new System.Drawing.Point(278, 398);
            this.numberCorrectTxtBx.Name = "numberCorrectTxtBx";
            this.numberCorrectTxtBx.Size = new System.Drawing.Size(100, 44);
            this.numberCorrectTxtBx.TabIndex = 22;
            // 
            // lblBestRun
            // 
            this.lblBestRun.AutoSize = true;
            this.lblBestRun.Location = new System.Drawing.Point(275, 445);
            this.lblBestRun.Name = "lblBestRun";
            this.lblBestRun.Size = new System.Drawing.Size(51, 13);
            this.lblBestRun.TabIndex = 25;
            this.lblBestRun.Text = "Best Run";
            // 
            // bestRunTxtBx
            // 
            this.bestRunTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bestRunTxtBx.Location = new System.Drawing.Point(278, 461);
            this.bestRunTxtBx.Name = "bestRunTxtBx";
            this.bestRunTxtBx.Size = new System.Drawing.Size(100, 44);
            this.bestRunTxtBx.TabIndex = 24;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Location = new System.Drawing.Point(70, 253);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(75, 23);
            this.btnRollDice.TabIndex = 26;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(70, 359);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(75, 23);
            this.btnGuess.TabIndex = 27;
            this.btnGuess.Text = "Enter Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "dieface1.png");
            this.imageList1.Images.SetKeyName(1, "dieface2.png");
            this.imageList1.Images.SetKeyName(2, "dieface3.png");
            this.imageList1.Images.SetKeyName(3, "dieface4.png");
            this.imageList1.Images.SetKeyName(4, "dieface5.png");
            this.imageList1.Images.SetKeyName(5, "dieface6.png");
            // 
            // numberIncorrectTxtBx
            // 
            this.numberIncorrectTxtBx.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberIncorrectTxtBx.Location = new System.Drawing.Point(399, 398);
            this.numberIncorrectTxtBx.Name = "numberIncorrectTxtBx";
            this.numberIncorrectTxtBx.Size = new System.Drawing.Size(100, 44);
            this.numberIncorrectTxtBx.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Number Incorrect";
            // 
            // lblGameStatus
            // 
            this.lblGameStatus.AutoSize = true;
            this.lblGameStatus.Location = new System.Drawing.Point(253, 268);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(0, 13);
            this.lblGameStatus.TabIndex = 30;
            // 
            // Petals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1025, 689);
            this.Controls.Add(this.lblGameStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberIncorrectTxtBx);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lblBestRun);
            this.Controls.Add(this.bestRunTxtBx);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.numberCorrectTxtBx);
            this.Controls.Add(this.lblTotalRolls);
            this.Controls.Add(this.totalRollsTxtBx);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.guessTxtBx);
            this.Controls.Add(this.lblDie5);
            this.Controls.Add(this.dieFiveTxtBox);
            this.Controls.Add(this.lblDie4);
            this.Controls.Add(this.dieFourTxtBox);
            this.Controls.Add(this.lblDie3);
            this.Controls.Add(this.dieThreeTxtBox);
            this.Controls.Add(this.lblDie2);
            this.Controls.Add(this.dieTwoTxtBox);
            this.Controls.Add(this.lblDie1);
            this.Controls.Add(this.dieOneTxtBox);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Petals";
            this.Text = "Petals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox dieOneTxtBox;
        private System.Windows.Forms.Label lblDie1;
        private System.Windows.Forms.Label lblDie2;
        private System.Windows.Forms.TextBox dieTwoTxtBox;
        private System.Windows.Forms.Label lblDie3;
        private System.Windows.Forms.TextBox dieThreeTxtBox;
        private System.Windows.Forms.Label lblDie4;
        private System.Windows.Forms.TextBox dieFourTxtBox;
        private System.Windows.Forms.Label lblDie5;
        private System.Windows.Forms.TextBox dieFiveTxtBox;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox guessTxtBx;
        private System.Windows.Forms.Label lblTotalRolls;
        private System.Windows.Forms.TextBox totalRollsTxtBx;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.TextBox numberCorrectTxtBx;
        private System.Windows.Forms.Label lblBestRun;
        private System.Windows.Forms.TextBox bestRunTxtBx;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox numberIncorrectTxtBx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGameStatus;
    }
}

