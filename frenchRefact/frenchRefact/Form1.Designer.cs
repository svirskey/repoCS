namespace frenchRefact
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArabian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSlav = new System.Windows.Forms.TextBox();
            this.buttonInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(504, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "В старославянском";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(632, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 39);
            this.label3.TabIndex = 23;
            this.label3.Text = "В арабском";
            // 
            // textBoxArabian
            // 
            this.textBoxArabian.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxArabian.Location = new System.Drawing.Point(897, 201);
            this.textBoxArabian.MaximumSize = new System.Drawing.Size(200, 50);
            this.textBoxArabian.Name = "textBoxArabian";
            this.textBoxArabian.ReadOnly = true;
            this.textBoxArabian.Size = new System.Drawing.Size(200, 47);
            this.textBoxArabian.TabIndex = 22;
            this.textBoxArabian.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(890, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 39);
            this.label2.TabIndex = 21;
            this.label2.Text = "Результат";
            // 
            // textBoxSlav
            // 
            this.textBoxSlav.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSlav.Location = new System.Drawing.Point(897, 290);
            this.textBoxSlav.MaximumSize = new System.Drawing.Size(200, 50);
            this.textBoxSlav.Name = "textBoxSlav";
            this.textBoxSlav.ReadOnly = true;
            this.textBoxSlav.Size = new System.Drawing.Size(200, 47);
            this.textBoxSlav.TabIndex = 20;
            this.textBoxSlav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonInput
            // 
            this.buttonInput.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInput.Location = new System.Drawing.Point(67, 201);
            this.buttonInput.Name = "buttonInput";
            this.buttonInput.Size = new System.Drawing.Size(160, 64);
            this.buttonInput.TabIndex = 19;
            this.buttonInput.Text = "Ввести";
            this.buttonInput.UseMnemonic = false;
            this.buttonInput.UseVisualStyleBackColor = false;
            this.buttonInput.Click += new System.EventHandler(this.buttonInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "Введите число до 999 на французском";
            // 
            // textBoxInput
            // 
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(67, 121);
            this.textBoxInput.MaximumSize = new System.Drawing.Size(600, 50);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(600, 40);
            this.textBoxInput.TabIndex = 17;
            this.textBoxInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 628);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArabian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSlav);
            this.Controls.Add(this.buttonInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArabian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSlav;
        private System.Windows.Forms.Button buttonInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
    }
}

