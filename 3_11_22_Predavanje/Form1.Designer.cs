namespace _3_11_22_Predavanje
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
            this.btn_Show = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPupilNum = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblReturn2 = new System.Windows.Forms.Label();
            this.txtSkolaIme = new System.Windows.Forms.TextBox();
            this.txtBrojUcenika = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_Show.Location = new System.Drawing.Point(150, 12);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(75, 23);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Prikaži";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(13, 50);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(0, 13);
            this.lblReturn.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblName.Location = new System.Drawing.Point(507, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Ime:";
            // 
            // lblPupilNum
            // 
            this.lblPupilNum.AutoSize = true;
            this.lblPupilNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblPupilNum.Location = new System.Drawing.Point(465, 50);
            this.lblPupilNum.Name = "lblPupilNum";
            this.lblPupilNum.Size = new System.Drawing.Size(78, 15);
            this.lblPupilNum.TabIndex = 3;
            this.lblPupilNum.Text = "Broj učenika:";
            // 
            // btnInput
            // 
            this.btnInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnInput.Location = new System.Drawing.Point(667, 22);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(45, 41);
            this.btnInput.TabIndex = 4;
            this.btnInput.Text = "OK";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblReturn2
            // 
            this.lblReturn2.AutoSize = true;
            this.lblReturn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblReturn2.Location = new System.Drawing.Point(474, 93);
            this.lblReturn2.Name = "lblReturn2";
            this.lblReturn2.Size = new System.Drawing.Size(0, 15);
            this.lblReturn2.TabIndex = 5;
            // 
            // txtSkolaIme
            // 
            this.txtSkolaIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSkolaIme.Location = new System.Drawing.Point(549, 19);
            this.txtSkolaIme.Name = "txtSkolaIme";
            this.txtSkolaIme.Size = new System.Drawing.Size(100, 21);
            this.txtSkolaIme.TabIndex = 6;
            // 
            // txtBrojUcenika
            // 
            this.txtBrojUcenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtBrojUcenika.Location = new System.Drawing.Point(549, 45);
            this.txtBrojUcenika.Name = "txtBrojUcenika";
            this.txtBrojUcenika.Size = new System.Drawing.Size(100, 21);
            this.txtBrojUcenika.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBrojUcenika);
            this.Controls.Add(this.txtSkolaIme);
            this.Controls.Add(this.lblReturn2);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblPupilNum);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.btn_Show);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPupilNum;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblReturn2;
        private System.Windows.Forms.TextBox txtSkolaIme;
        private System.Windows.Forms.TextBox txtBrojUcenika;
    }
}

