namespace WindowsFormsAppTestCreate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textInput = new System.Windows.Forms.TextBox();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.PAN = new System.Windows.Forms.Panel();
            this.BTN = new System.Windows.Forms.Button();
            this.PAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(3, 3);
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(326, 326);
            this.textInput.TabIndex = 0;
            this.textInput.Text = resources.GetString("textInput.Text");
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(444, 0);
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(332, 329);
            this.textOutput.TabIndex = 1;
            this.textOutput.Text = "10\r\n9\r\n8\r\n7\r\n6\r\n5\r\n4\r\n3\r\n2\r\n1";
            // 
            // PAN
            // 
            this.PAN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PAN.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.PAN.Controls.Add(this.textInput);
            this.PAN.Controls.Add(this.textOutput);
            this.PAN.Location = new System.Drawing.Point(12, 37);
            this.PAN.Name = "PAN";
            this.PAN.Size = new System.Drawing.Size(776, 401);
            this.PAN.TabIndex = 2;
            // 
            // BTN
            // 
            this.BTN.Location = new System.Drawing.Point(12, 8);
            this.BTN.Name = "BTN";
            this.BTN.Size = new System.Drawing.Size(75, 23);
            this.BTN.TabIndex = 3;
            this.BTN.Text = "BTN";
            this.BTN.UseVisualStyleBackColor = true;
            this.BTN.Click += new System.EventHandler(this.BTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN);
            this.Controls.Add(this.PAN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FResize);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.Resize += new System.EventHandler(this.FResize);
            this.PAN.ResumeLayout(false);
            this.PAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.Panel PAN;
        private System.Windows.Forms.Button BTN;
    }
}

