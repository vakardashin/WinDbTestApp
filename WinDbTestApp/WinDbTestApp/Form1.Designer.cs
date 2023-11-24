namespace WinDbTestApp
{
    partial class FrmMain
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
            this.BtnMySql = new System.Windows.Forms.Button();
            this.BtnMsSql = new System.Windows.Forms.Button();
            this.BtnSqLite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMySql
            // 
            this.BtnMySql.Location = new System.Drawing.Point(12, 12);
            this.BtnMySql.Name = "BtnMySql";
            this.BtnMySql.Size = new System.Drawing.Size(144, 51);
            this.BtnMySql.TabIndex = 0;
            this.BtnMySql.Text = "MySQL";
            this.BtnMySql.UseVisualStyleBackColor = true;
            this.BtnMySql.Click += new System.EventHandler(this.BtnMySql_Click);
            // 
            // BtnMsSql
            // 
            this.BtnMsSql.Location = new System.Drawing.Point(12, 69);
            this.BtnMsSql.Name = "BtnMsSql";
            this.BtnMsSql.Size = new System.Drawing.Size(144, 51);
            this.BtnMsSql.TabIndex = 1;
            this.BtnMsSql.Text = "MS SQL";
            this.BtnMsSql.UseVisualStyleBackColor = true;
            // 
            // BtnSqLite
            // 
            this.BtnSqLite.Location = new System.Drawing.Point(12, 126);
            this.BtnSqLite.Name = "BtnSqLite";
            this.BtnSqLite.Size = new System.Drawing.Size(144, 51);
            this.BtnSqLite.TabIndex = 2;
            this.BtnSqLite.Text = "SQLite";
            this.BtnSqLite.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 193);
            this.Controls.Add(this.BtnSqLite);
            this.Controls.Add(this.BtnMsSql);
            this.Controls.Add(this.BtnMySql);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMySql;
        private System.Windows.Forms.Button BtnMsSql;
        private System.Windows.Forms.Button BtnSqLite;
    }
}

