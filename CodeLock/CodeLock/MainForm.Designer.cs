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
            this.btnEmpty1 = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lblRandomNum = new System.Windows.Forms.Label();
            this.btnGenNumber = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.pbCongrats = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCongrats)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(74, 58);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(26, 30);
            this.btnThree.TabIndex = 0;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(42, 58);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(26, 30);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(10, 94);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(26, 30);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(10, 131);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(26, 30);
            this.btnSeven.TabIndex = 2;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(42, 130);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(26, 30);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(10, 58);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(26, 30);
            this.btnOne.TabIndex = 6;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(74, 94);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(26, 30);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(42, 94);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(26, 30);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(74, 130);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(26, 30);
            this.btnNine.TabIndex = 5;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(42, 166);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(26, 30);
            this.btnZero.TabIndex = 5;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(74, 166);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(26, 30);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "<";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEmpty1
            // 
            this.btnEmpty1.Location = new System.Drawing.Point(10, 167);
            this.btnEmpty1.Name = "btnEmpty1";
            this.btnEmpty1.Size = new System.Drawing.Size(26, 30);
            this.btnEmpty1.TabIndex = 6;
            this.btnEmpty1.UseVisualStyleBackColor = true;
            this.btnEmpty1.Click += new System.EventHandler(this.btnEmpty1_Click);
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Quartz MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInput.Location = new System.Drawing.Point(10, 21);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(88, 23);
            this.tbInput.TabIndex = 8;
            // 
            // lblRandomNum
            // 
            this.lblRandomNum.AutoSize = true;
            this.lblRandomNum.Font = new System.Drawing.Font("Quartz MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRandomNum.Location = new System.Drawing.Point(263, 20);
            this.lblRandomNum.Name = "lblRandomNum";
            this.lblRandomNum.Size = new System.Drawing.Size(90, 32);
            this.lblRandomNum.TabIndex = 10;
            this.lblRandomNum.Text = "00000";
            // 
            // btnGenNumber
            // 
            this.btnGenNumber.Location = new System.Drawing.Point(120, 21);
            this.btnGenNumber.Name = "btnGenNumber";
            this.btnGenNumber.Size = new System.Drawing.Size(137, 31);
            this.btnGenNumber.TabIndex = 11;
            this.btnGenNumber.Text = "Пуск";
            this.btnGenNumber.UseVisualStyleBackColor = true;
            this.btnGenNumber.Click += new System.EventHandler(this.btnGenNumber_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(10, 202);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(90, 22);
            this.btnCompare.TabIndex = 11;
            this.btnCompare.Text = "Принять";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // pbCongrats
            // 
            this.pbCongrats.Image = global::CodeLock.Properties.Resources.badResultImage;
            this.pbCongrats.Location = new System.Drawing.Point(120, 58);
            this.pbCongrats.Name = "pbCongrats";
            this.pbCongrats.Size = new System.Drawing.Size(233, 166);
            this.pbCongrats.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCongrats.TabIndex = 9;
            this.pbCongrats.TabStop = false;
            this.pbCongrats.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 235);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnGenNumber);
            this.Controls.Add(this.lblRandomNum);
            this.Controls.Add(this.pbCongrats);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnEmpty1);
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
        private System.Windows.Forms.Button btnEmpty1;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.PictureBox pbCongrats;
        private System.Windows.Forms.Label lblRandomNum;
        private System.Windows.Forms.Button btnGenNumber;
        private System.Windows.Forms.Button btnCompare;
    }
}

