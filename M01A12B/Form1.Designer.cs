namespace M01A12B
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
            btnOK = new Button();
            label1 = new Label();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.Location = new Point(266, 172);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(97, 51);
            btnOK.TabIndex = 0;
            btnOK.Text = "Mostrar";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 51);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 1;
            label1.Text = " ";
            label1.Click += label1_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(63, 76);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(43, 15);
            lblMsg.TabIndex = 2;
            lblMsg.Text = "lblMsg";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMsg);
            Controls.Add(label1);
            Controls.Add(btnOK);
            Name = "Form1";
            Text = "lblMsg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOK;
        private Label label1;
        private Label lblMsg;
    }
}
