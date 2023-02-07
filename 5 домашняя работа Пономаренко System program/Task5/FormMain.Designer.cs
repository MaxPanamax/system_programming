
namespace Task5
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
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxWord = new System.Windows.Forms.TextBox();
            this.buttonSearchWordInTextFile = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.dataGridViewStatistic = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFolderPath.ForeColor = System.Drawing.Color.Lime;
            this.labelFolderPath.Location = new System.Drawing.Point(10, 20);
            this.labelFolderPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(107, 16);
            this.labelFolderPath.TabIndex = 0;
            this.labelFolderPath.Text = "Путь к папке:";
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Enabled = false;
            this.textBoxFolderPath.Location = new System.Drawing.Point(154, 16);
            this.textBoxFolderPath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(273, 20);
            this.textBoxFolderPath.TabIndex = 1;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.BackColor = System.Drawing.Color.Red;
            this.buttonOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFolder.ForeColor = System.Drawing.Color.White;
            this.buttonOpenFolder.Location = new System.Drawing.Point(444, 11);
            this.buttonOpenFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(76, 51);
            this.buttonOpenFolder.TabIndex = 2;
            this.buttonOpenFolder.Text = "ОБЗОР";
            this.buttonOpenFolder.UseVisualStyleBackColor = false;
            // 
            // labelWord
            // 
            this.labelWord.AutoSize = true;
            this.labelWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWord.ForeColor = System.Drawing.Color.Lime;
            this.labelWord.Location = new System.Drawing.Point(10, 46);
            this.labelWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(143, 16);
            this.labelWord.TabIndex = 3;
            this.labelWord.Text = "Слово для поиска:";
            // 
            // textBoxWord
            // 
            this.textBoxWord.Location = new System.Drawing.Point(154, 43);
            this.textBoxWord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxWord.Name = "textBoxWord";
            this.textBoxWord.Size = new System.Drawing.Size(273, 20);
            this.textBoxWord.TabIndex = 4;
            // 
            // buttonSearchWordInTextFile
            // 
            this.buttonSearchWordInTextFile.BackColor = System.Drawing.Color.Red;
            this.buttonSearchWordInTextFile.Enabled = false;
            this.buttonSearchWordInTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearchWordInTextFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearchWordInTextFile.Location = new System.Drawing.Point(367, 67);
            this.buttonSearchWordInTextFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearchWordInTextFile.Name = "buttonSearchWordInTextFile";
            this.buttonSearchWordInTextFile.Size = new System.Drawing.Size(153, 52);
            this.buttonSearchWordInTextFile.TabIndex = 5;
            this.buttonSearchWordInTextFile.Text = "Поиск слова в текстовых файлах";
            this.buttonSearchWordInTextFile.UseVisualStyleBackColor = false;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelInfo.Location = new System.Drawing.Point(12, 122);
            this.labelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(119, 18);
            this.labelInfo.TabIndex = 6;
            this.labelInfo.Text = "Инфоррмация";
            // 
            // dataGridViewStatistic
            // 
            this.dataGridViewStatistic.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridViewStatistic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatistic.Location = new System.Drawing.Point(15, 170);
            this.dataGridViewStatistic.Name = "dataGridViewStatistic";
            this.dataGridViewStatistic.RowHeadersWidth = 51;
            this.dataGridViewStatistic.Size = new System.Drawing.Size(505, 221);
            this.dataGridViewStatistic.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(547, 442);
            this.Controls.Add(this.dataGridViewStatistic);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonSearchWordInTextFile);
            this.Controls.Add(this.textBoxWord);
            this.Controls.Add(this.labelWord);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.textBoxFolderPath);
            this.Controls.Add(this.labelFolderPath);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Поиск слова в текстовых файлах директории";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatistic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFolderPath;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxWord;
        private System.Windows.Forms.Button buttonSearchWordInTextFile;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.DataGridView dataGridViewStatistic;
    }
}

