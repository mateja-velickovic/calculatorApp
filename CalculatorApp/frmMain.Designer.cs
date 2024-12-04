namespace CalculatorApp
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            btnClear = new Button();
            btnPow = new Button();
            btnPercentage = new Button();
            btnPi = new Button();
            btnInv = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSubstract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnAdd = new Button();
            btnEquals = new Button();
            btnComa = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(14, 69);
            txtResult.Margin = new Padding(4, 3, 4, 3);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(277, 31);
            txtResult.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(240, 36);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(51, 27);
            btnClear.TabIndex = 1;
            btnClear.Text = "AC";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(14, 127);
            btnPow.Margin = new Padding(4, 3, 4, 3);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(64, 50);
            btnPow.TabIndex = 2;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnOperator_Click;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(85, 127);
            btnPercentage.Margin = new Padding(4, 3, 4, 3);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(64, 50);
            btnPercentage.TabIndex = 3;
            btnPercentage.Text = "%";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnOperator_Click;
            // 
            // btnPi
            // 
            btnPi.Location = new Point(156, 127);
            btnPi.Margin = new Padding(4, 3, 4, 3);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(64, 50);
            btnPi.TabIndex = 4;
            btnPi.Text = "pi";
            btnPi.UseVisualStyleBackColor = true;
            btnPi.Click += btnOperator_Click;
            // 
            // btnInv
            // 
            btnInv.Location = new Point(227, 126);
            btnInv.Margin = new Padding(4, 3, 4, 3);
            btnInv.Name = "btnInv";
            btnInv.Size = new Size(64, 51);
            btnInv.TabIndex = 5;
            btnInv.Text = "+/-";
            btnInv.UseVisualStyleBackColor = true;
            btnInv.Click += btnOperator_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(14, 196);
            btn7.Margin = new Padding(4, 3, 4, 3);
            btn7.Name = "btn7";
            btn7.Size = new Size(64, 50);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btnNumber_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(85, 196);
            btn8.Margin = new Padding(4, 3, 4, 3);
            btn8.Name = "btn8";
            btn8.Size = new Size(64, 50);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btnNumber_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(156, 196);
            btn9.Margin = new Padding(4, 3, 4, 3);
            btn9.Name = "btn9";
            btn9.Size = new Size(64, 50);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btnNumber_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(227, 196);
            btnMultiply.Margin = new Padding(4, 3, 4, 3);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(64, 50);
            btnMultiply.TabIndex = 9;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnOperator_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(227, 263);
            btnDivide.Margin = new Padding(4, 3, 4, 3);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(64, 50);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnOperator_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(156, 263);
            btn6.Margin = new Padding(4, 3, 4, 3);
            btn6.Name = "btn6";
            btn6.Size = new Size(64, 50);
            btn6.TabIndex = 12;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btnNumber_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(85, 263);
            btn5.Margin = new Padding(4, 3, 4, 3);
            btn5.Name = "btn5";
            btn5.Size = new Size(64, 50);
            btn5.TabIndex = 11;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btnNumber_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(14, 263);
            btn4.Margin = new Padding(4, 3, 4, 3);
            btn4.Name = "btn4";
            btn4.Size = new Size(64, 50);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btnNumber_Click;
            // 
            // btnSubstract
            // 
            btnSubstract.Location = new Point(227, 330);
            btnSubstract.Margin = new Padding(4, 3, 4, 3);
            btnSubstract.Name = "btnSubstract";
            btnSubstract.Size = new Size(64, 50);
            btnSubstract.TabIndex = 17;
            btnSubstract.Text = "-";
            btnSubstract.UseVisualStyleBackColor = true;
            btnSubstract.Click += btnOperator_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(156, 330);
            btn3.Margin = new Padding(4, 3, 4, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(64, 50);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btnNumber_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(85, 330);
            btn2.Margin = new Padding(4, 3, 4, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(64, 50);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btnNumber_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(14, 330);
            btn1.Margin = new Padding(4, 3, 4, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(64, 50);
            btn1.TabIndex = 14;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btnNumber_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(227, 400);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(64, 50);
            btnAdd.TabIndex = 21;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnOperator_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(156, 400);
            btnEquals.Margin = new Padding(4, 3, 4, 3);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(64, 50);
            btnEquals.TabIndex = 20;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnComa
            // 
            btnComa.Location = new Point(85, 400);
            btnComa.Margin = new Padding(4, 3, 4, 3);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(64, 50);
            btnComa.TabIndex = 19;
            btnComa.Text = ".";
            btnComa.UseVisualStyleBackColor = true;
            btnComa.Click += btnComa_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(14, 400);
            btn0.Margin = new Padding(4, 3, 4, 3);
            btn0.Name = "btn0";
            btn0.Size = new Size(64, 50);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btnNumber_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 465);
            Controls.Add(btnAdd);
            Controls.Add(btnEquals);
            Controls.Add(btnComa);
            Controls.Add(btn0);
            Controls.Add(btnSubstract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnDivide);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnInv);
            Controls.Add(btnPi);
            Controls.Add(btnPercentage);
            Controls.Add(btnPow);
            Controls.Add(btnClear);
            Controls.Add(txtResult);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMain";
            Text = "Calculatrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPow;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnInv;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnComa;
        private System.Windows.Forms.Button btn0;
    }
}
