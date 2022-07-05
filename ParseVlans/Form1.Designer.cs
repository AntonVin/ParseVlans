namespace ParseVlans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExtract = new System.Windows.Forms.Button();
            this.txtBoxSource1 = new System.Windows.Forms.TextBox();
            this.txtBoxSource2 = new System.Windows.Forms.TextBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtract.Location = new System.Drawing.Point(206, 493);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(540, 61);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Извлечь";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtBoxSource1
            // 
            this.txtBoxSource1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSource1.Location = new System.Drawing.Point(12, 12);
            this.txtBoxSource1.Multiline = true;
            this.txtBoxSource1.Name = "txtBoxSource1";
            this.txtBoxSource1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSource1.Size = new System.Drawing.Size(284, 475);
            this.txtBoxSource1.TabIndex = 1;
            this.txtBoxSource1.Text = resources.GetString("txtBoxSource1.Text");
            // 
            // txtBoxSource2
            // 
            this.txtBoxSource2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSource2.Location = new System.Drawing.Point(302, 9);
            this.txtBoxSource2.Multiline = true;
            this.txtBoxSource2.Name = "txtBoxSource2";
            this.txtBoxSource2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSource2.Size = new System.Drawing.Size(284, 478);
            this.txtBoxSource2.TabIndex = 2;
            this.txtBoxSource2.Text = resources.GetString("txtBoxSource2.Text");
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Location = new System.Drawing.Point(610, 12);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxResult.Size = new System.Drawing.Size(346, 475);
            this.txtBoxResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 566);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.txtBoxSource2);
            this.Controls.Add(this.txtBoxSource1);
            this.Controls.Add(this.btnExtract);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtBoxSource1;
        private System.Windows.Forms.TextBox txtBoxSource2;
        private System.Windows.Forms.TextBox txtBoxResult;
    }
}

