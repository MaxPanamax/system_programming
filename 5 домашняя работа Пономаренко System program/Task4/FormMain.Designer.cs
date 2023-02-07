
namespace Task4
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
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelStatisticInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFilePath.ForeColor = System.Drawing.Color.Navy;
            this.labelFilePath.Location = new System.Drawing.Point(19, 15);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(107, 16);
            this.labelFilePath.TabIndex = 0;
            this.labelFilePath.Text = "Путь к файлу";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Enabled = false;
            this.textBoxFilePath.ForeColor = System.Drawing.Color.Lime;
            this.textBoxFilePath.Location = new System.Drawing.Point(125, 11);
            this.textBoxFilePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(354, 20);
            this.textBoxFilePath.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.ForeColor = System.Drawing.Color.Navy;
            this.buttonOpenFile.Location = new System.Drawing.Point(493, 11);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(96, 44);
            this.buttonOpenFile.TabIndex = 2;
            this.buttonOpenFile.Text = "Обзор";
            this.buttonOpenFile.UseVisualStyleBackColor = false;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.ForeColor = System.Drawing.Color.Navy;
            this.labelWord.Location = new System.Drawing.Point(8, 35);
            this.labelWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(118, 16);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "Введите слово";
            // 
            // textBoxWord
            // 
            this.textBoxWord.ForeColor = System.Drawing.Color.Red;
            this.textBoxWord.Location = new System.Drawing.Point(125, 35);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(354, 20);
            this.textBoxWord.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Red;
            this.buttonSearch.Enabled = false;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Location = new System.Drawing.Point(593, 11);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 44);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "ПОИСК";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // labelStatisticInfo
            // 
            this.labelStatisticInfo.AutoSize = true;
            this.labelStatisticInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatisticInfo.ForeColor = System.Drawing.Color.Green;
            this.labelStatisticInfo.Location = new System.Drawing.Point(9, 105);
            this.labelStatisticInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatisticInfo.Name = "labelStatisticInfo";
            this.labelStatisticInfo.Size = new System.Drawing.Size(95, 15);
            this.labelStatisticInfo.TabIndex = 6;
            this.labelStatisticInfo.Text = "Информация";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(718, 396);
            this.Controls.Add(this.labelStatisticInfo);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonOpenFile);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelFilePath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск слова в файле";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelStatisticInfo;
    }
}

