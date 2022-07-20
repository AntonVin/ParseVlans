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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageInterface = new System.Windows.Forms.TabPage();
            this.tabPageVLAN = new System.Windows.Forms.TabPage();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.btnPageToLeft = new System.Windows.Forms.Button();
            this.btnPageToRight = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageInterface.SuspendLayout();
            this.tabPageVLAN.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExtract
            // 
            this.btnExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExtract.Location = new System.Drawing.Point(241, 389);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(540, 61);
            this.btnExtract.TabIndex = 0;
            this.btnExtract.Text = "Извлечь";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // txtBoxSource1
            // 
            this.txtBoxSource1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSource1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSource1.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSource1.Multiline = true;
            this.txtBoxSource1.Name = "txtBoxSource1";
            this.txtBoxSource1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSource1.Size = new System.Drawing.Size(1049, 633);
            this.txtBoxSource1.TabIndex = 1;
            this.txtBoxSource1.Text = resources.GetString("txtBoxSource1.Text");
            // 
            // txtBoxSource2
            // 
            this.txtBoxSource2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxSource2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSource2.Location = new System.Drawing.Point(3, 3);
            this.txtBoxSource2.Multiline = true;
            this.txtBoxSource2.Name = "txtBoxSource2";
            this.txtBoxSource2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxSource2.Size = new System.Drawing.Size(1039, 623);
            this.txtBoxSource2.TabIndex = 2;
            this.txtBoxSource2.Text = resources.GetString("txtBoxSource2.Text");
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBoxResult.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxResult.Location = new System.Drawing.Point(3, 3);
            this.txtBoxResult.Multiline = true;
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxResult.Size = new System.Drawing.Size(906, 339);
            this.txtBoxResult.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageInterface);
            this.tabControl1.Controls.Add(this.tabPageVLAN);
            this.tabControl1.Controls.Add(this.tabPageResult);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(920, 371);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageInterface
            // 
            this.tabPageInterface.Controls.Add(this.txtBoxSource1);
            this.tabPageInterface.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageInterface.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageInterface.Location = new System.Drawing.Point(4, 22);
            this.tabPageInterface.Name = "tabPageInterface";
            this.tabPageInterface.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInterface.Size = new System.Drawing.Size(1045, 629);
            this.tabPageInterface.TabIndex = 1;
            this.tabPageInterface.Text = "Интерфейс";
            this.tabPageInterface.UseVisualStyleBackColor = true;
            // 
            // tabPageVLAN
            // 
            this.tabPageVLAN.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageVLAN.Controls.Add(this.txtBoxSource2);
            this.tabPageVLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageVLAN.Location = new System.Drawing.Point(4, 22);
            this.tabPageVLAN.Name = "tabPageVLAN";
            this.tabPageVLAN.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVLAN.Size = new System.Drawing.Size(1045, 629);
            this.tabPageVLAN.TabIndex = 0;
            this.tabPageVLAN.Text = "VLANS";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.txtBoxResult);
            this.tabPageResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPageResult.Location = new System.Drawing.Point(4, 22);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResult.Size = new System.Drawing.Size(912, 345);
            this.tabPageResult.TabIndex = 2;
            this.tabPageResult.Text = "Результат";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // btnPageToLeft
            // 
            this.btnPageToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageToLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPageToLeft.Location = new System.Drawing.Point(0, 389);
            this.btnPageToLeft.Name = "btnPageToLeft";
            this.btnPageToLeft.Size = new System.Drawing.Size(115, 61);
            this.btnPageToLeft.TabIndex = 8;
            this.btnPageToLeft.Text = "<";
            this.btnPageToLeft.UseVisualStyleBackColor = true;
            this.btnPageToLeft.Click += new System.EventHandler(this.btnPageToLeft_Click);
            // 
            // btnPageToRight
            // 
            this.btnPageToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPageToRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPageToRight.Location = new System.Drawing.Point(120, 389);
            this.btnPageToRight.Name = "btnPageToRight";
            this.btnPageToRight.Size = new System.Drawing.Size(115, 61);
            this.btnPageToRight.TabIndex = 9;
            this.btnPageToRight.Text = ">";
            this.btnPageToRight.UseVisualStyleBackColor = true;
            this.btnPageToRight.Click += new System.EventHandler(this.btnPageToRight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 462);
            this.Controls.Add(this.btnPageToRight);
            this.Controls.Add(this.btnPageToLeft);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExtract);
            this.MinimumSize = new System.Drawing.Size(960, 200);
            this.Name = "Form1";
            this.Text = "Работа с VLANS";
            this.tabControl1.ResumeLayout(false);
            this.tabPageInterface.ResumeLayout(false);
            this.tabPageInterface.PerformLayout();
            this.tabPageVLAN.ResumeLayout(false);
            this.tabPageVLAN.PerformLayout();
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.TextBox txtBoxSource1;
        private System.Windows.Forms.TextBox txtBoxSource2;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageVLAN;
        private System.Windows.Forms.TabPage tabPageInterface;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.Button btnPageToLeft;
        private System.Windows.Forms.Button btnPageToRight;
    }
}

