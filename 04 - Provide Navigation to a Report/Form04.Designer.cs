namespace Provide_Navigation_to_Report
{
    partial class Form04
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
            this.buttonRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunReport.Location = new System.Drawing.Point(12, 12);
            this.buttonRunReport.Name = "buttonRunReport";
            this.buttonRunReport.Size = new System.Drawing.Size(360, 23);
            this.buttonRunReport.TabIndex = 3;
            this.buttonRunReport.Text = "Run report";
            this.buttonRunReport.UseVisualStyleBackColor = true;
            this.buttonRunReport.Click += new System.EventHandler(this.buttonRunReport_Click);
            // 
            // Form04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 47);
            this.Controls.Add(this.buttonRunReport);
            this.MaximizeBox = false;
            this.Name = "Form04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provide Navigation to a Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRunReport;
    }
}

