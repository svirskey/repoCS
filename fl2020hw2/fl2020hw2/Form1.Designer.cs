namespace fl2020hw2
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
            this.textInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.textFrom = new System.Windows.Forms.TextBox();
            this.textTo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textInput
            // 
            this.textInput.Location = new System.Drawing.Point(146, 41);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(172, 20);
            this.textInput.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вперед";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textOutput
            // 
            this.textOutput.Location = new System.Drawing.Point(407, 41);
            this.textOutput.Name = "textOutput";
            this.textOutput.Size = new System.Drawing.Size(166, 20);
            this.textOutput.TabIndex = 2;
            // 
            // textFrom
            // 
            this.textFrom.Location = new System.Drawing.Point(146, 82);
            this.textFrom.Name = "textFrom";
            this.textFrom.Size = new System.Drawing.Size(31, 20);
            this.textFrom.TabIndex = 3;
            this.textFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFrom_KeyPress);
            // 
            // textTo
            // 
            this.textTo.Location = new System.Drawing.Point(196, 82);
            this.textTo.Name = "textTo";
            this.textTo.Size = new System.Drawing.Size(30, 20);
            this.textTo.TabIndex = 4;
            this.textTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textTo_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textTo);
            this.Controls.Add(this.textFrom);
            this.Controls.Add(this.textOutput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textInput);
            this.Name = "Form1";
            this.Text = "Дз 2 Вар 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.TextBox textFrom;
        private System.Windows.Forms.TextBox textTo;
    }
}

