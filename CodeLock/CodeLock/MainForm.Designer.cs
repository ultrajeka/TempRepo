namespace CodeLock
{
    partial class MainForm
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
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblRandomNum = new System.Windows.Forms.Label();
            this.btnGenNumber = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblRandomPuk = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.lblTriesLeft = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPuk = new System.Windows.Forms.Label();
            this.pbCongrats = new System.Windows.Forms.PictureBox();
            this.lblPukTries = new System.Windows.Forms.Label();
            this.lblPukTriesLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCongrats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(74, 75);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(26, 30);
            this.btnThree.TabIndex = 4;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(42, 75);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(26, 30);
            this.btnTwo.TabIndex = 3;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(10, 111);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(26, 30);
            this.btnFour.TabIndex = 5;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(10, 148);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(26, 30);
            this.btnSeven.TabIndex = 8;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(42, 147);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(26, 30);
            this.btnEight.TabIndex = 9;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(10, 75);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(26, 30);
            this.btnOne.TabIndex = 2;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(74, 111);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(26, 30);
            this.btnSix.TabIndex = 7;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(42, 111);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(26, 30);
            this.btnFive.TabIndex = 6;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(74, 147);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(26, 30);
            this.btnNine.TabIndex = 10;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(10, 183);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(58, 30);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(74, 183);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(26, 30);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Quartz MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(10, 49);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(88, 20);
            this.tbInput.TabIndex = 0;
            this.tbInput.Visible = false;
            this.tbInput.TextChanged += new System.EventHandler(this.tbInput_TextChanged);
            this.tbInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbInput_KeyDown);
            // 
            // lblRandomNum
            // 
            this.lblRandomNum.AutoSize = true;
            this.lblRandomNum.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomNum.Location = new System.Drawing.Point(170, 12);
            this.lblRandomNum.Name = "lblRandomNum";
            this.lblRandomNum.Size = new System.Drawing.Size(0, 25);
            this.lblRandomNum.TabIndex = 15;
            // 
            // btnGenNumber
            // 
            this.btnGenNumber.Location = new System.Drawing.Point(8, 12);
            this.btnGenNumber.Name = "btnGenNumber";
            this.btnGenNumber.Size = new System.Drawing.Size(90, 31);
            this.btnGenNumber.TabIndex = 1;
            this.btnGenNumber.Text = "Пуск";
            this.btnGenNumber.UseVisualStyleBackColor = true;
            this.btnGenNumber.Click += new System.EventHandler(this.btnGenNumber_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(10, 219);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(90, 22);
            this.btnCompare.TabIndex = 14;
            this.btnCompare.Text = "Принять";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblRandomPuk
            // 
            this.lblRandomPuk.AutoSize = true;
            this.lblRandomPuk.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomPuk.ForeColor = System.Drawing.Color.Red;
            this.lblRandomPuk.Location = new System.Drawing.Point(170, 43);
            this.lblRandomPuk.Name = "lblRandomPuk";
            this.lblRandomPuk.Size = new System.Drawing.Size(24, 25);
            this.lblRandomPuk.TabIndex = 16;
            this.lblRandomPuk.Text = "0";
            this.lblRandomPuk.Visible = false;
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTries.ForeColor = System.Drawing.Color.Red;
            this.lblTries.Location = new System.Drawing.Point(235, 12);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(24, 25);
            this.lblTries.TabIndex = 17;
            this.lblTries.Text = "0";
            this.lblTries.Visible = false;
            // 
            // lblTriesLeft
            // 
            this.lblTriesLeft.AutoSize = true;
            this.lblTriesLeft.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTriesLeft.ForeColor = System.Drawing.Color.Red;
            this.lblTriesLeft.Location = new System.Drawing.Point(253, 12);
            this.lblTriesLeft.Name = "lblTriesLeft";
            this.lblTriesLeft.Size = new System.Drawing.Size(95, 25);
            this.lblTriesLeft.TabIndex = 18;
            this.lblTriesLeft.Text = "Tries left";
            this.lblTriesLeft.Visible = false;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPass.Location = new System.Drawing.Point(106, 12);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(61, 25);
            this.lblPass.TabIndex = 20;
            this.lblPass.Text = "Pass";
            this.lblPass.Visible = false;
            // 
            // lblPuk
            // 
            this.lblPuk.AutoSize = true;
            this.lblPuk.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPuk.ForeColor = System.Drawing.Color.Red;
            this.lblPuk.Location = new System.Drawing.Point(106, 43);
            this.lblPuk.Name = "lblPuk";
            this.lblPuk.Size = new System.Drawing.Size(58, 25);
            this.lblPuk.TabIndex = 21;
            this.lblPuk.Text = "PUK";
            this.lblPuk.Visible = false;
            // 
            // pbCongrats
            // 
            this.pbCongrats.Image = global::CodeLock.Properties.Resources.KnDq;
            this.pbCongrats.Location = new System.Drawing.Point(107, 77);
            this.pbCongrats.Name = "pbCongrats";
            this.pbCongrats.Size = new System.Drawing.Size(241, 164);
            this.pbCongrats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCongrats.TabIndex = 9;
            this.pbCongrats.TabStop = false;
            this.pbCongrats.Visible = false;
            // 
            // lblPukTries
            // 
            this.lblPukTries.AutoSize = true;
            this.lblPukTries.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPukTries.ForeColor = System.Drawing.Color.Red;
            this.lblPukTries.Location = new System.Drawing.Point(235, 43);
            this.lblPukTries.Name = "lblPukTries";
            this.lblPukTries.Size = new System.Drawing.Size(24, 25);
            this.lblPukTries.TabIndex = 22;
            this.lblPukTries.Text = "0";
            this.lblPukTries.Visible = false;
            // 
            // lblPukTriesLeft
            // 
            this.lblPukTriesLeft.AutoSize = true;
            this.lblPukTriesLeft.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPukTriesLeft.ForeColor = System.Drawing.Color.Red;
            this.lblPukTriesLeft.Location = new System.Drawing.Point(253, 43);
            this.lblPukTriesLeft.Name = "lblPukTriesLeft";
            this.lblPukTriesLeft.Size = new System.Drawing.Size(95, 25);
            this.lblPukTriesLeft.TabIndex = 23;
            this.lblPukTriesLeft.Text = "Tries left";
            this.lblPukTriesLeft.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 255);
            this.Controls.Add(this.lblPukTriesLeft);
            this.Controls.Add(this.lblPukTries);
            this.Controls.Add(this.lblPuk);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblTriesLeft);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblRandomPuk);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnGenNumber);
            this.Controls.Add(this.lblRandomNum);
            this.Controls.Add(this.pbCongrats);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Font = new System.Drawing.Font("Quartz MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeLock";
            ((System.ComponentModel.ISupportInitialize)(this.pbCongrats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pbCongrats;
        private System.Windows.Forms.Label lblRandomNum;
        private System.Windows.Forms.Button btnGenNumber;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lblRandomPuk;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.Label lblTriesLeft;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPuk;
        private System.Windows.Forms.Label lblPukTries;
        private System.Windows.Forms.Label lblPukTriesLeft;
    }
}

