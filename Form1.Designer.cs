namespace CCAD16_Assignment4_1_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtInput1 = new TextBox();
            txtInput2 = new TextBox();
            txtResult = new Label();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            lblFunction = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            
            // txtInput1
            txtInput1.Location = new Point(254, 107);
            txtInput1.Name = "txtInput1";
            txtInput1.Size = new Size(68, 23);
            txtInput1.TabIndex = 0;
            
            // txtInput2
            txtInput2.Location = new Point(254, 136);
            txtInput2.Name = "txtInput2";
            txtInput2.Size = new Size(68, 23);
            txtInput2.TabIndex = 1;
            
            // txtResult
            txtResult.AutoSize = true;
            txtResult.Location = new Point(199, 288);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(67, 15);
            txtResult.TabIndex = 2;
            txtResult.Text = "Result Here";
            
            // btnAdd
            btnAdd.Location = new Point(177, 196);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(51, 35);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            
            // btnSubtract
            btnSubtract.Location = new Point(234, 196);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(51, 35);
            btnSubtract.TabIndex = 4;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            
            // btnMultiply
            btnMultiply.Location = new Point(177, 237);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(51, 35);
            btnMultiply.TabIndex = 5;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            
            // btnDivide
            btnDivide.Location = new Point(234, 237);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(51, 35);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += btnDivide_Click;
            
            // lblFunction
            lblFunction.AutoSize = true;
            lblFunction.Location = new Point(177, 178);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(104, 15);
            lblFunction.TabIndex = 7;
            lblFunction.Text = "Choose a function";
            
            // label1
            label1.AutoSize = true;
            label1.Location = new Point(177, 115);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 8;
            label1.Text = "1st Operand";
            
            // label2
            label2.AutoSize = true;
            label2.Location = new Point(177, 139);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 9;
            label2.Text = "2nd Operand";
            
            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblFunction);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(txtResult);
            Controls.Add(txtInput2);
            Controls.Add(txtInput1);
            Name = "Form1";
            Text = "Simple Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput1;
        private TextBox txtInput2;
        private Label txtResult;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Label lblFunction;
        private Label label1;
        private Label label2;
    }
}
