namespace WinFormsApp33
{
    partial class Form1
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
            txtInput = new RichTextBox();
            txtResult = new RichTextBox();
            txtRows = new TextBox();
            txtCols = new TextBox();
            btnSolve = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(133, 152);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(244, 120);
            txtInput.TabIndex = 0;
            txtInput.Text = "";
            txtInput.TextChanged += richTextBox1_TextChanged;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(420, 152);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(245, 120);
            txtResult.TabIndex = 1;
            txtResult.Text = "";
            // 
            // txtRows
            // 
            txtRows.Location = new Point(337, 52);
            txtRows.Name = "txtRows";
            txtRows.Size = new Size(125, 27);
            txtRows.TabIndex = 2;
            // 
            // txtCols
            // 
            txtCols.Location = new Point(337, 94);
            txtCols.Name = "txtCols";
            txtCols.Size = new Size(125, 27);
            txtCols.TabIndex = 3;
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(351, 323);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(94, 29);
            btnSolve.TabIndex = 4;
            btnSolve.Text = "button1";
            btnSolve.UseVisualStyleBackColor = true;
            btnSolve.Click += btnSolve_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 55);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 5;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 101);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSolve);
            Controls.Add(txtCols);
            Controls.Add(txtRows);
            Controls.Add(txtResult);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtInput;
        private RichTextBox txtResult;
        private TextBox txtRows;
        private TextBox txtCols;
        private Button btnSolve;
        private Label label1;
        private Label label2;
    }
}
