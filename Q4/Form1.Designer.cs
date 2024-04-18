namespace Q4
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btndevision = new System.Windows.Forms.Button();
            this.btnmultiplicction = new System.Windows.Forms.Button();
            this.btnsubstraction = new System.Windows.Forms.Button();
            this.btnaddition = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEaqual = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(156, 39);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(417, 92);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(156, 153);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(92, 62);
            this.btnclear.TabIndex = 15;
            this.btnclear.Text = "CE";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(156, 231);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(84, 51);
            this.btn7.TabIndex = 16;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(268, 231);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(84, 51);
            this.btnNum8.TabIndex = 17;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(384, 231);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 51);
            this.btn9.TabIndex = 18;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btndevision
            // 
            this.btndevision.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndevision.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndevision.Location = new System.Drawing.Point(489, 215);
            this.btndevision.Name = "btndevision";
            this.btndevision.Size = new System.Drawing.Size(84, 67);
            this.btndevision.TabIndex = 29;
            this.btndevision.Text = "/";
            this.btndevision.UseVisualStyleBackColor = false;
            this.btndevision.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnmultiplicction
            // 
            this.btnmultiplicction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnmultiplicction.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicction.Location = new System.Drawing.Point(489, 288);
            this.btnmultiplicction.Name = "btnmultiplicction";
            this.btnmultiplicction.Size = new System.Drawing.Size(84, 68);
            this.btnmultiplicction.TabIndex = 30;
            this.btnmultiplicction.Text = "x";
            this.btnmultiplicction.UseVisualStyleBackColor = false;
            this.btnmultiplicction.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnsubstraction
            // 
            this.btnsubstraction.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnsubstraction.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubstraction.Location = new System.Drawing.Point(489, 362);
            this.btnsubstraction.Name = "btnsubstraction";
            this.btnsubstraction.Size = new System.Drawing.Size(84, 65);
            this.btnsubstraction.TabIndex = 31;
            this.btnsubstraction.Text = "-";
            this.btnsubstraction.UseVisualStyleBackColor = false;
            this.btnsubstraction.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btnaddition
            // 
            this.btnaddition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnaddition.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddition.Location = new System.Drawing.Point(489, 433);
            this.btnaddition.Name = "btnaddition";
            this.btnaddition.Size = new System.Drawing.Size(84, 108);
            this.btnaddition.TabIndex = 32;
            this.btnaddition.Text = "+";
            this.btnaddition.UseVisualStyleBackColor = false;
            this.btnaddition.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(384, 305);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 51);
            this.btn6.TabIndex = 33;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(268, 305);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(84, 51);
            this.btn5.TabIndex = 34;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(156, 305);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(84, 51);
            this.btn4.TabIndex = 35;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(384, 376);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 51);
            this.btn3.TabIndex = 36;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(268, 376);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(84, 51);
            this.btn2.TabIndex = 37;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(156, 376);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(84, 51);
            this.btn1.TabIndex = 38;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(164, 453);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(304, 69);
            this.btn0.TabIndex = 39;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Digit_Click);
            // 
            // btnEaqual
            // 
            this.btnEaqual.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEaqual.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEaqual.Location = new System.Drawing.Point(156, 547);
            this.btnEaqual.Name = "btnEaqual";
            this.btnEaqual.Size = new System.Drawing.Size(417, 62);
            this.btnEaqual.TabIndex = 40;
            this.btnEaqual.Text = "=";
            this.btnEaqual.UseVisualStyleBackColor = false;
            this.btnEaqual.Click += new System.EventHandler(this.btnEaqual_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.Color.Navy;
            this.lblAnswer.Location = new System.Drawing.Point(462, 85);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 37);
            this.lblAnswer.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 638);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnEaqual);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btnaddition);
            this.Controls.Add(this.btnsubstraction);
            this.Controls.Add(this.btnmultiplicction);
            this.Controls.Add(this.btndevision);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Q4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btndevision;
        private System.Windows.Forms.Button btnmultiplicction;
        private System.Windows.Forms.Button btnsubstraction;
        private System.Windows.Forms.Button btnaddition;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnEaqual;
        private System.Windows.Forms.Label lblAnswer;
    }
}

