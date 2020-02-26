namespace Caesar
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.inputtextmsg = new System.Windows.Forms.Label();
            this.outputtextmsg = new System.Windows.Forms.Label();
            this.keyinp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Encrypt.Location = new System.Drawing.Point(41, 189);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(163, 48);
            this.Encrypt.TabIndex = 0;
            this.Encrypt.Text = "Encrypt";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Decrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Decrypt.Location = new System.Drawing.Point(598, 189);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(163, 48);
            this.Decrypt.TabIndex = 1;
            this.Decrypt.Text = "Decrypt";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // InputTextBox
            // 
            this.InputTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.InputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputTextBox.Location = new System.Drawing.Point(228, 35);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(345, 150);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputTextBox.Location = new System.Drawing.Point(228, 267);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(345, 170);
            this.OutputTextBox.TabIndex = 3;
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox_TextChanged);
            // 
            // Key
            // 
            this.Key.BackColor = System.Drawing.SystemColors.Info;
            this.Key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Key.Location = new System.Drawing.Point(360, 208);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(213, 29);
            this.Key.TabIndex = 4;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // inputtextmsg
            // 
            this.inputtextmsg.AutoSize = true;
            this.inputtextmsg.BackColor = System.Drawing.SystemColors.Menu;
            this.inputtextmsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.inputtextmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.inputtextmsg.Location = new System.Drawing.Point(224, 7);
            this.inputtextmsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.inputtextmsg.Name = "inputtextmsg";
            this.inputtextmsg.Size = new System.Drawing.Size(104, 25);
            this.inputtextmsg.TabIndex = 5;
            this.inputtextmsg.Text = "Text input:";
            // 
            // outputtextmsg
            // 
            this.outputtextmsg.AutoSize = true;
            this.outputtextmsg.BackColor = System.Drawing.SystemColors.Menu;
            this.outputtextmsg.Cursor = System.Windows.Forms.Cursors.Default;
            this.outputtextmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.outputtextmsg.Location = new System.Drawing.Point(224, 239);
            this.outputtextmsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.outputtextmsg.Name = "outputtextmsg";
            this.outputtextmsg.Size = new System.Drawing.Size(115, 25);
            this.outputtextmsg.TabIndex = 6;
            this.outputtextmsg.Text = "Translation:";
            // 
            // keyinp
            // 
            this.keyinp.AutoSize = true;
            this.keyinp.BackColor = System.Drawing.SystemColors.Menu;
            this.keyinp.Cursor = System.Windows.Forms.Cursors.Default;
            this.keyinp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.keyinp.Location = new System.Drawing.Point(223, 204);
            this.keyinp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.keyinp.Name = "keyinp";
            this.keyinp.Size = new System.Drawing.Size(95, 25);
            this.keyinp.TabIndex = 7;
            this.keyinp.Text = "Your key:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyinp);
            this.Controls.Add(this.outputtextmsg);
            this.Controls.Add(this.inputtextmsg);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Name = "MainForm";
            this.Text = "Caesar Code";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label inputtextmsg;
        private System.Windows.Forms.Label outputtextmsg;
        private System.Windows.Forms.Label keyinp;
    }
}

