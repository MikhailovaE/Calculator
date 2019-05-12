namespace Calculator
{
    partial class CalculatorForm
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
            this.plusButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.fiveBotton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.arrowButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.threeBotton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.Location = new System.Drawing.Point(12, 74);
            this.plusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(122, 110);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.oneButton.Location = new System.Drawing.Point(12, 192);
            this.oneButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(161, 110);
            this.oneButton.TabIndex = 8;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // fiveBotton
            // 
            this.fiveBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fiveBotton.Location = new System.Drawing.Point(179, 309);
            this.fiveBotton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fiveBotton.Name = "fiveBotton";
            this.fiveBotton.Size = new System.Drawing.Size(161, 110);
            this.fiveBotton.TabIndex = 12;
            this.fiveBotton.Text = "5";
            this.fiveBotton.UseVisualStyleBackColor = true;
            this.fiveBotton.Click += new System.EventHandler(this.FiveBotton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.fourButton.Location = new System.Drawing.Point(12, 309);
            this.fourButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(161, 110);
            this.fourButton.TabIndex = 13;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.sixButton.Location = new System.Drawing.Point(347, 309);
            this.sixButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(161, 110);
            this.sixButton.TabIndex = 14;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.zeroButton.Location = new System.Drawing.Point(179, 427);
            this.zeroButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(161, 110);
            this.zeroButton.TabIndex = 18;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // arrowButton
            // 
            this.arrowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.arrowButton.Location = new System.Drawing.Point(347, 428);
            this.arrowButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.arrowButton.Name = "arrowButton";
            this.arrowButton.Size = new System.Drawing.Size(161, 110);
            this.arrowButton.TabIndex = 19;
            this.arrowButton.Text = "←";
            this.arrowButton.UseVisualStyleBackColor = true;
            this.arrowButton.Click += new System.EventHandler(this.ArrowButton_Click);
            // 
            // cButton
            // 
            this.cButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.cButton.Location = new System.Drawing.Point(12, 426);
            this.cButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(161, 110);
            this.cButton.TabIndex = 20;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.CButton_Click);
            // 
            // threeBotton
            // 
            this.threeBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.threeBotton.Location = new System.Drawing.Point(347, 192);
            this.threeBotton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.threeBotton.Name = "threeBotton";
            this.threeBotton.Size = new System.Drawing.Size(161, 110);
            this.threeBotton.TabIndex = 21;
            this.threeBotton.Text = "3";
            this.threeBotton.UseVisualStyleBackColor = true;
            this.threeBotton.Click += new System.EventHandler(this.ThreeBotton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.twoButton.Location = new System.Drawing.Point(179, 192);
            this.twoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(161, 110);
            this.twoButton.TabIndex = 22;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.Location = new System.Drawing.Point(140, 74);
            this.minusButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(117, 110);
            this.minusButton.TabIndex = 25;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.Button12_Click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multButton.Location = new System.Drawing.Point(264, 74);
            this.multButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(117, 110);
            this.multButton.TabIndex = 26;
            this.multButton.Text = "×";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.MultButton_Click);
            // 
            // divButton
            // 
            this.divButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.divButton.Location = new System.Drawing.Point(387, 74);
            this.divButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(121, 110);
            this.divButton.TabIndex = 27;
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.DivButton_Click);
            // 
            // equalButton
            // 
            this.equalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.equalButton.Location = new System.Drawing.Point(449, 13);
            this.equalButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(58, 55);
            this.equalButton.TabIndex = 28;
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MinimumSize = new System.Drawing.Size(431, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 55);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.SystemColors.Window;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(14, 14);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 51);
            this.label.TabIndex = 30;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 551);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.divButton);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.threeBotton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.arrowButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.fiveBotton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.plusButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(541, 607);
            this.MinimumSize = new System.Drawing.Size(541, 607);
            this.Name = "CalculatorForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button fiveBotton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button arrowButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button threeBotton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button multButton;
        private System.Windows.Forms.Button divButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label;
    }
}

