namespace StringEqualityAllison
{
    partial class frmStringEquality
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
            this.txtString2 = new System.Windows.Forms.TextBox();
            this.txtString1 = new System.Windows.Forms.TextBox();
            this.lblString2 = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblcase = new System.Windows.Forms.Label();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtString2
            // 
            this.txtString2.Location = new System.Drawing.Point(176, 124);
            this.txtString2.Name = "txtString2";
            this.txtString2.Size = new System.Drawing.Size(100, 20);
            this.txtString2.TabIndex = 0;
            // 
            // txtString1
            // 
            this.txtString1.Location = new System.Drawing.Point(176, 81);
            this.txtString1.Name = "txtString1";
            this.txtString1.Size = new System.Drawing.Size(100, 20);
            this.txtString1.TabIndex = 1;
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString2.Location = new System.Drawing.Point(79, 122);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(63, 19);
            this.lblString2.TabIndex = 2;
            this.lblString2.Text = "String 2";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblString.Location = new System.Drawing.Point(81, 82);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(61, 19);
            this.lblString.TabIndex = 3;
            this.lblString.Text = "String 1";
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(121, 163);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(78, 28);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblcase
            // 
            this.lblcase.AutoSize = true;
            this.lblcase.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcase.Location = new System.Drawing.Point(24, 28);
            this.lblcase.Name = "lblcase";
            this.lblcase.Size = new System.Drawing.Size(146, 19);
            this.lblcase.TabIndex = 5;
            this.lblcase.Text = "Case doesn\'t matter";
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(11, 9);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(322, 19);
            this.lblEnter.TabIndex = 6;
            this.lblEnter.Text = "Enter two strings to check if they\'re the same";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("GOST Common", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(70, 211);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(155, 19);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "The strings are equal";
            // 
            // frmStringEquality
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(345, 246);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.lblcase);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblString);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.txtString1);
            this.Controls.Add(this.txtString2);
            this.Name = "frmStringEquality";
            this.Text = "String Equality by Allison C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString2;
        private System.Windows.Forms.TextBox txtString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblcase;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblAnswer;
    }
}

