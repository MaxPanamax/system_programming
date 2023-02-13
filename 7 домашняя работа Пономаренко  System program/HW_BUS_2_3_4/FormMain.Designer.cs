
namespace HomeWork2_3_4
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
            this.listBoxPassengers = new System.Windows.Forms.ListBox();
            this.labelPassengers = new System.Windows.Forms.Label();
            this.listBoxBus = new System.Windows.Forms.ListBox();
            this.labelBus = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelCountPassenger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPassengers
            // 
            this.listBoxPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxPassengers.ForeColor = System.Drawing.Color.Red;
            this.listBoxPassengers.FormattingEnabled = true;
            this.listBoxPassengers.HorizontalScrollbar = true;
            this.listBoxPassengers.ItemHeight = 16;
            this.listBoxPassengers.Location = new System.Drawing.Point(12, 46);
            this.listBoxPassengers.Name = "listBoxPassengers";
            this.listBoxPassengers.ScrollAlwaysVisible = true;
            this.listBoxPassengers.Size = new System.Drawing.Size(849, 228);
            this.listBoxPassengers.TabIndex = 0;
            // 
            // labelPassengers
            // 
            this.labelPassengers.AutoSize = true;
            this.labelPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassengers.ForeColor = System.Drawing.Color.Blue;
            this.labelPassengers.Location = new System.Drawing.Point(12, 9);
            this.labelPassengers.Name = "labelPassengers";
            this.labelPassengers.Size = new System.Drawing.Size(121, 24);
            this.labelPassengers.TabIndex = 1;
            this.labelPassengers.Text = "Пассажиры";
            // 
            // listBoxBus
            // 
            this.listBoxBus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.listBoxBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxBus.ForeColor = System.Drawing.Color.Fuchsia;
            this.listBoxBus.FormattingEnabled = true;
            this.listBoxBus.HorizontalScrollbar = true;
            this.listBoxBus.ItemHeight = 20;
            this.listBoxBus.Location = new System.Drawing.Point(12, 307);
            this.listBoxBus.Name = "listBoxBus";
            this.listBoxBus.ScrollAlwaysVisible = true;
            this.listBoxBus.Size = new System.Drawing.Size(849, 164);
            this.listBoxBus.TabIndex = 2;
            // 
            // labelBus
            // 
            this.labelBus.AutoSize = true;
            this.labelBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBus.ForeColor = System.Drawing.Color.Blue;
            this.labelBus.Location = new System.Drawing.Point(12, 280);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(106, 24);
            this.labelBus.TabIndex = 3;
            this.labelBus.Text = "Автобусы";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Red;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStart.Location = new System.Drawing.Point(879, 9);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(124, 39);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Старт";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.Blue;
            this.labelTime.Location = new System.Drawing.Point(452, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(180, 25);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Текущее время";
            // 
            // labelCountPassenger
            // 
            this.labelCountPassenger.AutoSize = true;
            this.labelCountPassenger.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPassenger.ForeColor = System.Drawing.Color.Blue;
            this.labelCountPassenger.Location = new System.Drawing.Point(240, 473);
            this.labelCountPassenger.Name = "labelCountPassenger";
            this.labelCountPassenger.Size = new System.Drawing.Size(527, 25);
            this.labelCountPassenger.TabIndex = 6;
            this.labelCountPassenger.Text = "Текущее количество пассажиров на остановке";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1005, 507);
            this.Controls.Add(this.labelCountPassenger);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelBus);
            this.Controls.Add(this.listBoxBus);
            this.Controls.Add(this.labelPassengers);
            this.Controls.Add(this.listBoxPassengers);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конечная остановка автобусов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPassengers;
        private System.Windows.Forms.Label labelPassengers;
        private System.Windows.Forms.ListBox listBoxBus;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelCountPassenger;
    }
}

