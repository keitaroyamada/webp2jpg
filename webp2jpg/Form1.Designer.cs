namespace webp2jpg
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
            import = new Button();
            progressBar2 = new ProgressBar();
            SuspendLayout();
            // 
            // import
            // 
            import.AllowDrop = true;
            import.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            import.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            import.Location = new System.Drawing.Point(11, 10);
            import.Margin = new Padding(2, 1, 2, 1);
            import.Name = "import";
            import.Size = new System.Drawing.Size(409, 177);
            import.TabIndex = 0;
            import.Text = "Drop images here.";
            import.UseVisualStyleBackColor = true;
            import.DragDrop += import_DragDrop;
            import.DragEnter += import_DragEnter;
            // 
            // progressBar2
            // 
            progressBar2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar2.Location = new System.Drawing.Point(12, 196);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new System.Drawing.Size(407, 10);
            progressBar2.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(431, 218);
            Controls.Add(progressBar2);
            Controls.Add(import);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "webp2jpg";
            ResumeLayout(false);
        }

        #endregion

        private Button import;
        private ProgressBar progressBar2;
    }
}