namespace DovusWinForm
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
            label1 = new Label();
            cmbxCharacters = new ComboBox();
            saldirButton = new Button();
            userHealthLabel = new Label();
            computerHealthLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.PeachPuff;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(496, 190);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 41);
            label1.TabIndex = 0;
            label1.Text = "Oyun Karakterlerini Seçiniz:";
            // 
            // cmbxCharacters
            // 
            cmbxCharacters.FormattingEnabled = true;
            cmbxCharacters.Location = new Point(463, 304);
            cmbxCharacters.Margin = new Padding(5, 5, 5, 5);
            cmbxCharacters.Name = "cmbxCharacters";
            cmbxCharacters.Size = new Size(483, 49);
            cmbxCharacters.TabIndex = 1;
            cmbxCharacters.SelectedIndexChanged += cmbxCharacters_SelectedIndexChanged;
            // 
            // saldirButton
            // 
            saldirButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            saldirButton.ForeColor = Color.DarkGreen;
            saldirButton.Location = new Point(592, 437);
            saldirButton.Margin = new Padding(5, 5, 5, 5);
            saldirButton.Name = "saldirButton";
            saldirButton.Size = new Size(235, 71);
            saldirButton.TabIndex = 2;
            saldirButton.Text = "Saldir";
            saldirButton.UseVisualStyleBackColor = true;
            saldirButton.Click += saldirButton_Click;
            // 
            // userHealthLabel
            // 
            userHealthLabel.AutoSize = true;
            userHealthLabel.BackColor = Color.PeachPuff;
            userHealthLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            userHealthLabel.ForeColor = Color.DarkGreen;
            userHealthLabel.Location = new Point(612, 614);
            userHealthLabel.Margin = new Padding(5, 0, 5, 0);
            userHealthLabel.Name = "userHealthLabel";
            userHealthLabel.Size = new Size(164, 41);
            userHealthLabel.TabIndex = 3;
            userHealthLabel.Text = "UserHealth";
            userHealthLabel.Click += userHealthLabel_Click;
            // 
            // computerHealthLabel
            // 
            computerHealthLabel.AutoSize = true;
            computerHealthLabel.BackColor = Color.PeachPuff;
            computerHealthLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            computerHealthLabel.ForeColor = Color.DarkGreen;
            computerHealthLabel.Location = new Point(581, 732);
            computerHealthLabel.Margin = new Padding(5, 0, 5, 0);
            computerHealthLabel.Name = "computerHealthLabel";
            computerHealthLabel.Size = new Size(246, 41);
            computerHealthLabel.TabIndex = 4;
            computerHealthLabel.Text = "Computer Health";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1586, 1192);
            Controls.Add(computerHealthLabel);
            Controls.Add(userHealthLabel);
            Controls.Add(saldirButton);
            Controls.Add(cmbxCharacters);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbxCharacters;
        private Button saldirButton;
        private Label userHealthLabel;
        private Label computerHealthLabel;
    }
}
