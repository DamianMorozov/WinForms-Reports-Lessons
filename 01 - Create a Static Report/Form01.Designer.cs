namespace Create_Static_Report
{
    partial class Form01
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
            this.buttonRunReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRunReport
            // 
            this.buttonRunReport.Location = new System.Drawing.Point(12, 12);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(310, 23);
            this.buttonRunReport.TabIndex = 0;
            this.buttonRunReport.Text = "Run report";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 47);
            this.Controls.Add(this.buttonRunReport);
            this.MaximizeBox = false;
            this.Name = "Form01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "01 - Create a Static Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunReport;
    }
}

