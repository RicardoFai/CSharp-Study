namespace Ex002
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
            lblMsg1 = new Label();
            lblMsg2 = new Label();
            lblMsg3 = new Label();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblMsg1
            // 
            lblMsg1.AutoSize = true;
            lblMsg1.Location = new Point(72, 156);
            lblMsg1.Name = "lblMsg1";
            lblMsg1.Size = new Size(32, 15);
            lblMsg1.TabIndex = 0;
            lblMsg1.Text = "MEU";
            lblMsg1.Visible = false;
            lblMsg1.Click += label1_Click;
            // 
            // lblMsg2
            // 
            lblMsg2.AutoSize = true;
            lblMsg2.Location = new Point(243, 156);
            lblMsg2.Name = "lblMsg2";
            lblMsg2.Size = new Size(44, 15);
            lblMsg2.TabIndex = 1;
            lblMsg2.Text = "BRASIL";
            lblMsg2.Visible = false;
            // 
            // lblMsg3
            // 
            lblMsg3.AutoSize = true;
            lblMsg3.Location = new Point(394, 156);
            lblMsg3.Name = "lblMsg3";
            lblMsg3.Size = new Size(69, 15);
            lblMsg3.TabIndex = 2;
            lblMsg3.Text = "BRASILEIRO";
            lblMsg3.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(243, 278);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(152, 54);
            btnIniciar.TabIndex = 3;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(lblMsg3);
            Controls.Add(lblMsg2);
            Controls.Add(lblMsg1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brasil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg1;
        private Label lblMsg2;
        private Label lblMsg3;
        private Button btnIniciar;
    }
}
