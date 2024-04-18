namespace Q2
{
    partial class Q2
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
            this.Snum = new System.Windows.Forms.Label();
            this.txtFnum = new System.Windows.Forms.TextBox();
            this.txtSnum = new System.Windows.Forms.TextBox();
            this.btnaddition = new System.Windows.Forms.Button();
            this.btnSubstraction = new System.Windows.Forms.Button();
            this.btnmultiplication = new System.Windows.Forms.Button();
            this.btnDivison = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fnum
            // 
            this.Fnum.AutoSize = true;
            this.Fnum.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnum.Location = new System.Drawing.Point(92, 81);
            this.Fnum.Name = "Fnum";
            this.Fnum.Size = new System.Drawing.Size(215, 31);
            this.Fnum.TabIndex = 3;
            this.Fnum.Text = "Enter 1st number";
            // 
            // Snum
            // 
            this.Snum.AutoSize = true;
            this.Snum.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snum.Location = new System.Drawing.Point(92, 159);
            this.Snum.Name = "Snum";
            this.Snum.Size = new System.Drawing.Size(224, 31);
            this.Snum.TabIndex = 5;
            this.Snum.Text = "Enter 2nd number";
            // 
            // txtFnum
            // 
            this.txtFnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFnum.Location = new System.Drawing.Point(371, 81);
            this.txtFnum.Multiline = true;
            this.txtFnum.Name = "txtFnum";
            this.txtFnum.Size = new System.Drawing.Size(264, 30);
            this.txtFnum.TabIndex = 6;
            // 
            // txtSnum
            // 
            this.txtSnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSnum.Location = new System.Drawing.Point(371, 161);
            this.txtSnum.Multiline = true;
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(264, 30);
            this.txtSnum.TabIndex = 7;
            // 
            // btnaddition
            // 
            this.btnaddition.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddition.Location = new System.Drawing.Point(141, 244);
            this.btnaddition.Name = "btnaddition";
            this.btnaddition.Size = new System.Drawing.Size(73, 56);
            this.btnaddition.TabIndex = 8;
            this.btnaddition.Text = "+";
            this.btnaddition.UseVisualStyleBackColor = true;
            this.btnaddition.Click += new System.EventHandler(this.btnaddition_Click);
            // 
            // btnSubstraction
            // 
            this.btnSubstraction.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstraction.Location = new System.Drawing.Point(267, 244);
            this.btnSubstraction.Name = "btnSubstraction";
            this.btnSubstraction.Size = new System.Drawing.Size(73, 56);
            this.btnSubstraction.TabIndex = 9;
            this.btnSubstraction.Text = "-";
            this.btnSubstraction.UseVisualStyleBackColor = true;
            this.btnSubstraction.Click += new System.EventHandler(this.btnSubstraction_Click);
            // 
            // btnmultiplication
            // 
            this.btnmultiplication.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplication.Location = new System.Drawing.Point(392, 244);
            this.btnmultiplication.Name = "btnmultiplication";
            this.btnmultiplication.Size = new System.Drawing.Size(73, 56);
            this.btnmultiplication.TabIndex = 10;
            this.btnmultiplication.Text = "x";
            this.btnmultiplication.UseVisualStyleBackColor = true;
            this.btnmultiplication.Click += new System.EventHandler(this.btnmultiplication_Click);
            // 
            // btnDivison
            // 
            this.btnDivison.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivison.Location = new System.Drawing.Point(517, 244);
            this.btnDivison.Name = "btnDivison";
            this.btnDivison.Size = new System.Drawing.Size(73, 56);
            this.btnDivison.TabIndex = 11;
            this.btnDivison.Text = "/";
            this.btnDivison.UseVisualStyleBackColor = true;
            this.btnDivison.Click += new System.EventHandler(this.btnDivison_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Navy;
            this.lblAnswer.Location = new System.Drawing.Point(260, 361);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 40);
            this.lblAnswer.TabIndex = 12;
            // 
            // Q2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 508);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnDivison);
            this.Controls.Add(this.btnmultiplication);
            this.Controls.Add(this.btnSubstraction);
            this.Controls.Add(this.btnaddition);
            this.Controls.Add(this.txtSnum);
            this.Controls.Add(this.txtFnum);
            this.Controls.Add(this.Snum);
            this.Controls.Add(this.Fnum);
            this.Name = "Q2";
            this.Text = "Q2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Fnum;
        private System.Windows.Forms.Label Snum;
        private System.Windows.Forms.TextBox txtFnum;
        private System.Windows.Forms.TextBox txtSnum;
        private System.Windows.Forms.Button btnaddition;
        private System.Windows.Forms.Button btnSubstraction;
        private System.Windows.Forms.Button btnmultiplication;
        private System.Windows.Forms.Button btnDivison;
        private System.Windows.Forms.Label lblAnswer;
    }
}

