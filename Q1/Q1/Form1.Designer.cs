namespace Q1
{
    partial class Q1
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
            this.Fnum = new System.Windows.Forms.Label();
            this.txtFnum = new System.Windows.Forms.TextBox();
            this.Snum = new System.Windows.Forms.Label();
            this.txtSnum = new System.Windows.Forms.TextBox();
            this.btnaddition = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fnum
            // 
            this.Fnum.AutoSize = true;
            this.Fnum.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnum.Location = new System.Drawing.Point(76, 65);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(215, 31);
            this.Fnum.TabIndex = 2;
            this.Fnum.Text = "Enter 1st number";
            // 
            // txtFnum
            // 
            this.txtFnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFnum.Location = new System.Drawing.Point(352, 66);
            this.txtFnum.Multiline = true;
            this.txtFnum.Name = "txtFnum";
            this.txtFnum.Size = new System.Drawing.Size(264, 30);
            this.txtFnum.TabIndex = 3;
            // 
            // Snum
            // 
            this.Snum.AutoSize = true;
            this.Snum.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snum.Location = new System.Drawing.Point(76, 151);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(224, 31);
            this.Snum.TabIndex = 4;
            this.Snum.Text = "Enter 2nd number";
            // 
            // txtSnum
            // 
            this.txtSnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnum.Location = new System.Drawing.Point(352, 151);
            this.txtSnum.Multiline = true;
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(264, 30);
            this.txtSnum.TabIndex = 5;
            // 
            // btnaddition
            // 
            this.btnaddition.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddition.Location = new System.Drawing.Point(208, 246);
            this.btnaddition.Name = "btnaddition";
            this.btnaddition.Size = new System.Drawing.Size(355, 65);
            this.btnaddition.TabIndex = 6;
            this.btnaddition.Text = "Calculate Addition (+)";
            this.btnaddition.UseVisualStyleBackColor = true;
            this.btnaddition.Click += new System.EventHandler(this.btnaddition_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Navy;
            this.lblAnswer.Location = new System.Drawing.Point(261, 330);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 36);
            this.lblAnswer.TabIndex = 7;
            // 
            // Q1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnaddition);
            this.Controls.Add(this.txtSnum);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.txtFnum);
            this.Controls.Add(this.Fnum);
            this.Name = "Q1";
            this.Text = "Q1";
            this.Load += new System.EventHandler(this.Q1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fnum;
        private System.Windows.Forms.TextBox txtFnum;
        private System.Windows.Forms.Label Snum;
        private System.Windows.Forms.TextBox txtSnum;
        private System.Windows.Forms.Button btnaddition;
        private System.Windows.Forms.Label lblAnswer;
    }
}

