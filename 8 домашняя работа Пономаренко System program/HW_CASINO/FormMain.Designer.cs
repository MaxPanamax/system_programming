
namespace Task6
{
    partial class FormMain
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
            this.listBoxPlayerLog = new System.Windows.Forms.ListBox();
            this.labelPlayerLog = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlayerLog
            // 
            this.listBoxPlayerLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxPlayerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPlayerLog.ForeColor = System.Drawing.Color.DarkGreen;
            this.listBoxPlayerLog.FormattingEnabled = true;
            this.listBoxPlayerLog.HorizontalScrollbar = true;
            this.listBoxPlayerLog.ItemHeight = 16;
            this.listBoxPlayerLog.Location = new System.Drawing.Point(9, 31);
            this.listBoxPlayerLog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBoxPlayerLog.Name = "listBoxPlayerLog";
            this.listBoxPlayerLog.ScrollAlwaysVisible = true;
            this.listBoxPlayerLog.Size = new System.Drawing.Size(836, 308);
            this.listBoxPlayerLog.TabIndex = 0;
            // 
            // labelPlayerLog
            // 
            this.labelPlayerLog.AutoSize = true;
            this.labelPlayerLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPlayerLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPlayerLog.Location = new System.Drawing.Point(9, 7);
            this.labelPlayerLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPlayerLog.Name = "labelPlayerLog";
            this.labelPlayerLog.Size = new System.Drawing.Size(96, 24);
            this.labelPlayerLog.TabIndex = 1;
            this.labelPlayerLog.Text = "События";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.Color.Red;
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStartGame.Location = new System.Drawing.Point(11, 362);
            this.buttonStartGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(82, 44);
            this.buttonStartGame.TabIndex = 6;
            this.buttonStartGame.Text = "Старт";
            this.buttonStartGame.UseVisualStyleBackColor = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelInfo.Location = new System.Drawing.Point(134, 362);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(48, 16);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Инфо";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(134, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Игрок выбывает, если сыграл 8 раундов или если у игрока закончились деньги";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(856, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelPlayerLog);
            this.Controls.Add(this.listBoxPlayerLog);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Casino (рулетка)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlayerLog;
        private System.Windows.Forms.Label labelPlayerLog;
        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label1;
    }
}

