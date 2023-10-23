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
            direction = new Button();
            SuspendLayout();
            // 
            // import
            // 
            import.AllowDrop = true;
            import.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            import.Location = new Point(11, 70);
            import.Margin = new Padding(2, 1, 2, 1);
            import.Name = "import";
            import.Size = new Size(409, 177);
            import.TabIndex = 0;
            import.Text = "Drop images here.";
            import.UseVisualStyleBackColor = true;
            import.DragDrop += import_DragDrop;
            import.DragEnter += import_DragEnter;
            // 
            // direction
            // 
            direction.Font = new Font("Yu Gothic UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            direction.Location = new Point(11, 12);
            direction.Name = "direction";
            direction.Size = new Size(409, 43);
            direction.TabIndex = 1;
            direction.Text = "webp => jpg";
            direction.UseVisualStyleBackColor = true;
            direction.Click += direction_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 257);
            Controls.Add(direction);
            Controls.Add(import);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "webp2jpg";
            ResumeLayout(false);
        }

        #endregion

        private Button import;
        private Button direction;
    }
}