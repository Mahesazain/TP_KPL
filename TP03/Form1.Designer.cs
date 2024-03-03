namespace TP03
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
            INPUT = new TextBox();
            OUTPUT = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // INPUT
            // 
            INPUT.Location = new Point(78, 70);
            INPUT.Name = "INPUT";
            INPUT.Size = new Size(191, 23);
            INPUT.TabIndex = 0;
            INPUT.TextChanged += INPUT_TextChanged;
            // 
            // OUTPUT
            // 
            OUTPUT.Location = new Point(78, 118);
            OUTPUT.Name = "OUTPUT";
            OUTPUT.Size = new Size(272, 23);
            OUTPUT.TabIndex = 1;
            OUTPUT.TextChanged += OUTPUT_TextChanged;
            // 
            // Submit
            // 
            Submit.Location = new Point(275, 69);
            Submit.Name = "Submit";
            Submit.Size = new Size(75, 23);
            Submit.TabIndex = 2;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(402, 192);
            Controls.Add(Submit);
            Controls.Add(OUTPUT);
            Controls.Add(INPUT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox INPUT;
        private TextBox OUTPUT;
        private Button Submit;
    }
}
