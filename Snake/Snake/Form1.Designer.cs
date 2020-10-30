namespace Snake
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
            this.components = new System.ComponentModel.Container();
            this.playingField = new System.Windows.Forms.PictureBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.labelPause = new System.Windows.Forms.Label();
            this.buttonPauseExit = new System.Windows.Forms.Button();
            this.buttonPauseContinue = new System.Windows.Forms.Button();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelResolution = new System.Windows.Forms.Label();
            this.nudSpeed = new System.Windows.Forms.NumericUpDown();
            this.nudResolution = new System.Windows.Forms.NumericUpDown();
            this.labelSettings = new System.Windows.Forms.Label();
            this.buttonSettingsExit = new System.Windows.Forms.Button();
            this.labelEndGameOver = new System.Windows.Forms.Label();
            this.labelEndScore = new System.Windows.Forms.Label();
            this.buttonEndExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playingField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).BeginInit();
            this.SuspendLayout();
            // 
            // playingField
            // 
            this.playingField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playingField.Location = new System.Drawing.Point(0, 0);
            this.playingField.Name = "playingField";
            this.playingField.Size = new System.Drawing.Size(800, 450);
            this.playingField.TabIndex = 0;
            this.playingField.TabStop = false;
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(299, 165);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(176, 46);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettings.Location = new System.Drawing.Point(299, 217);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(176, 46);
            this.buttonSettings.TabIndex = 2;
            this.buttonSettings.Text = "Настройки";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(299, 269);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(176, 46);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 350;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPause.Location = new System.Drawing.Point(275, 20);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(214, 73);
            this.labelPause.TabIndex = 4;
            this.labelPause.Text = "Пауза";
            // 
            // buttonPauseExit
            // 
            this.buttonPauseExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseExit.Location = new System.Drawing.Point(274, 234);
            this.buttonPauseExit.Name = "buttonPauseExit";
            this.buttonPauseExit.Size = new System.Drawing.Size(226, 81);
            this.buttonPauseExit.TabIndex = 5;
            this.buttonPauseExit.Text = "Выход";
            this.buttonPauseExit.UseVisualStyleBackColor = true;
            this.buttonPauseExit.Click += new System.EventHandler(this.buttonPauseExit_Click);
            // 
            // buttonPauseContinue
            // 
            this.buttonPauseContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPauseContinue.Location = new System.Drawing.Point(274, 130);
            this.buttonPauseContinue.Name = "buttonPauseContinue";
            this.buttonPauseContinue.Size = new System.Drawing.Size(226, 81);
            this.buttonPauseContinue.TabIndex = 6;
            this.buttonPauseContinue.Text = "Продолжить";
            this.buttonPauseContinue.UseVisualStyleBackColor = true;
            this.buttonPauseContinue.Click += new System.EventHandler(this.buttonPauseContinue_Click);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSpeed.Location = new System.Drawing.Point(12, 91);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(155, 37);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Скорость";
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(12, 144);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(190, 37);
            this.labelResolution.TabIndex = 8;
            this.labelResolution.Text = "Разрешение";
            // 
            // nudSpeed
            // 
            this.nudSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpeed.Location = new System.Drawing.Point(225, 97);
            this.nudSpeed.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(120, 31);
            this.nudSpeed.TabIndex = 9;
            this.nudSpeed.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // nudResolution
            // 
            this.nudResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudResolution.Location = new System.Drawing.Point(225, 150);
            this.nudResolution.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudResolution.Name = "nudResolution";
            this.nudResolution.Size = new System.Drawing.Size(120, 31);
            this.nudResolution.TabIndex = 10;
            this.nudResolution.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSettings.Location = new System.Drawing.Point(264, 9);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(264, 55);
            this.labelSettings.TabIndex = 11;
            this.labelSettings.Text = "Настройки";
            // 
            // buttonSettingsExit
            // 
            this.buttonSettingsExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSettingsExit.Location = new System.Drawing.Point(288, 199);
            this.buttonSettingsExit.Name = "buttonSettingsExit";
            this.buttonSettingsExit.Size = new System.Drawing.Size(205, 76);
            this.buttonSettingsExit.TabIndex = 12;
            this.buttonSettingsExit.Text = "Выход";
            this.buttonSettingsExit.UseVisualStyleBackColor = true;
            this.buttonSettingsExit.Click += new System.EventHandler(this.buttonSettingsExit_Click);
            // 
            // labelEndGameOver
            // 
            this.labelEndGameOver.AutoSize = true;
            this.labelEndGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndGameOver.Location = new System.Drawing.Point(167, 138);
            this.labelEndGameOver.Name = "labelEndGameOver";
            this.labelEndGameOver.Size = new System.Drawing.Size(474, 73);
            this.labelEndGameOver.TabIndex = 13;
            this.labelEndGameOver.Text = "Игра окончена";
            // 
            // labelEndScore
            // 
            this.labelEndScore.AutoSize = true;
            this.labelEndScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndScore.Location = new System.Drawing.Point(212, 244);
            this.labelEndScore.Name = "labelEndScore";
            this.labelEndScore.Size = new System.Drawing.Size(345, 73);
            this.labelEndScore.TabIndex = 14;
            this.labelEndScore.Text = "Ваш счет: ";
            // 
            // buttonEndExit
            // 
            this.buttonEndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndExit.Location = new System.Drawing.Point(274, 339);
            this.buttonEndExit.Name = "buttonEndExit";
            this.buttonEndExit.Size = new System.Drawing.Size(205, 76);
            this.buttonEndExit.TabIndex = 15;
            this.buttonEndExit.Text = "Выход";
            this.buttonEndExit.UseVisualStyleBackColor = true;
            this.buttonEndExit.Click += new System.EventHandler(this.buttonEndExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEndExit);
            this.Controls.Add(this.labelEndScore);
            this.Controls.Add(this.labelEndGameOver);
            this.Controls.Add(this.buttonSettingsExit);
            this.Controls.Add(this.labelSettings);
            this.Controls.Add(this.nudResolution);
            this.Controls.Add(this.nudSpeed);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPauseContinue);
            this.Controls.Add(this.buttonPauseExit);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.playingField);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Snake";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.playingField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudResolution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playingField;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.Button buttonPauseExit;
        private System.Windows.Forms.Button buttonPauseContinue;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.NumericUpDown nudSpeed;
        private System.Windows.Forms.NumericUpDown nudResolution;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Button buttonSettingsExit;
        private System.Windows.Forms.Label labelEndGameOver;
        private System.Windows.Forms.Label labelEndScore;
        private System.Windows.Forms.Button buttonEndExit;
    }
}

