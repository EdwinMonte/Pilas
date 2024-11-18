namespace Pilas
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
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            lstStack = new ListBox();
            txtValue = new TextBox();
            SuspendLayout();
            // 
            // btnPush
            // 
            btnPush.Location = new Point(58, 69);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(141, 54);
            btnPush.TabIndex = 0;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(58, 129);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(141, 43);
            btnPop.TabIndex = 1;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(58, 178);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(141, 44);
            btnPeek.TabIndex = 2;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            // 
            // lstStack
            // 
            lstStack.FormattingEnabled = true;
            lstStack.Location = new Point(218, 18);
            lstStack.Name = "lstStack";
            lstStack.Size = new Size(750, 404);
            lstStack.TabIndex = 3;
            // 
            // txtValue
            // 
            txtValue.Location = new Point(66, 456);
            txtValue.Multiline = true;
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(273, 61);
            txtValue.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 641);
            Controls.Add(txtValue);
            Controls.Add(lstStack);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private ListBox lstStack;
        private TextBox txtValue;
    }
}
