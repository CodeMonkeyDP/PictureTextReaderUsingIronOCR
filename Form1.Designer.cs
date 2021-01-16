using System;

namespace OCR_Using_IronOCR
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
            this.gbPic = new System.Windows.Forms.GroupBox();
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.gbText = new System.Windows.Forms.GroupBox();
            this.tbText = new System.Windows.Forms.RichTextBox();
            this.ms = new System.Windows.Forms.MenuStrip();
            this.btnFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransform = new System.Windows.Forms.Button();
            this.fd = new System.Windows.Forms.OpenFileDialog();
            this.chbAlign = new System.Windows.Forms.CheckBox();
            this.chbNoise = new System.Windows.Forms.CheckBox();
            this.gbLanguage = new System.Windows.Forms.GroupBox();
            this.cbLanguage = new System.Windows.Forms.ComboBox();
            this.gbPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            this.gbText.SuspendLayout();
            this.ms.SuspendLayout();
            this.gbLanguage.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPic
            // 
            this.gbPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPic.Controls.Add(this.pbPic);
            this.gbPic.Location = new System.Drawing.Point(20, 33);
            this.gbPic.Name = "gbPic";
            this.gbPic.Size = new System.Drawing.Size(369, 405);
            this.gbPic.TabIndex = 0;
            this.gbPic.TabStop = false;
            this.gbPic.Text = "Картинка:";
            // 
            // pbPic
            // 
            this.pbPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPic.Location = new System.Drawing.Point(7, 20);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(356, 379);
            this.pbPic.TabIndex = 0;
            this.pbPic.TabStop = false;
            // 
            // gbText
            // 
            this.gbText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbText.Controls.Add(this.tbText);
            this.gbText.Location = new System.Drawing.Point(395, 33);
            this.gbText.Name = "gbText";
            this.gbText.Size = new System.Drawing.Size(393, 405);
            this.gbText.TabIndex = 1;
            this.gbText.TabStop = false;
            this.gbText.Text = "Текст:";
            // 
            // tbText
            // 
            this.tbText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbText.Location = new System.Drawing.Point(7, 20);
            this.tbText.Name = "tbText";
            this.tbText.ReadOnly = true;
            this.tbText.Size = new System.Drawing.Size(380, 379);
            this.tbText.TabIndex = 0;
            this.tbText.Text = "";
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(800, 24);
            this.ms.TabIndex = 2;
            this.ms.Text = "menuStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpen,
            this.btnClose});
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(48, 20);
            this.btnFile.Text = "Файл";
            // 
            // btnOpen
            // 
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(181, 22);
            this.btnOpen.Text = "Загрузить картинку";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(181, 22);
            this.btnClose.Text = "Выход";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTransform
            // 
            this.btnTransform.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransform.Enabled = false;
            this.btnTransform.Location = new System.Drawing.Point(194, 444);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(366, 48);
            this.btnTransform.TabIndex = 3;
            this.btnTransform.Text = "Преобразовать изображение в текст";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // fd
            // 
            this.fd.Filter = "Bitmap Files|*.bmp";
            // 
            // chbAlign
            // 
            this.chbAlign.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbAlign.AutoSize = true;
            this.chbAlign.Location = new System.Drawing.Point(27, 452);
            this.chbAlign.Name = "chbAlign";
            this.chbAlign.Size = new System.Drawing.Size(113, 17);
            this.chbAlign.TabIndex = 4;
            this.chbAlign.Text = "Выровнять текст";
            this.chbAlign.UseVisualStyleBackColor = true;
            // 
            // chbNoise
            // 
            this.chbNoise.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chbNoise.AutoSize = true;
            this.chbNoise.Location = new System.Drawing.Point(27, 475);
            this.chbNoise.Name = "chbNoise";
            this.chbNoise.Size = new System.Drawing.Size(87, 17);
            this.chbNoise.TabIndex = 5;
            this.chbNoise.Text = "Убрать шум\r\n";
            this.chbNoise.UseVisualStyleBackColor = true;
            // 
            // gbLanguage
            // 
            this.gbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLanguage.Controls.Add(this.cbLanguage);
            this.gbLanguage.Location = new System.Drawing.Point(566, 444);
            this.gbLanguage.Name = "gbLanguage";
            this.gbLanguage.Size = new System.Drawing.Size(222, 48);
            this.gbLanguage.TabIndex = 6;
            this.gbLanguage.TabStop = false;
            this.gbLanguage.Text = "Язык:";
            // 
            // cbLanguage
            // 
            this.cbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.Items.AddRange(new object[] {
            "Английский",
            "Русский"});
            this.cbLanguage.Location = new System.Drawing.Point(6, 15);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.Size = new System.Drawing.Size(210, 21);
            this.cbLanguage.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.gbLanguage);
            this.Controls.Add(this.chbNoise);
            this.Controls.Add(this.chbAlign);
            this.Controls.Add(this.btnTransform);
            this.Controls.Add(this.gbText);
            this.Controls.Add(this.gbPic);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.Name = "Form1";
            this.Text = "Считватель текста";
            this.gbPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            this.gbText.ResumeLayout(false);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.gbLanguage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPic;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.GroupBox gbText;
        private System.Windows.Forms.RichTextBox tbText;
        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem btnFile;
        private System.Windows.Forms.ToolStripMenuItem btnOpen;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.OpenFileDialog fd;
        private System.Windows.Forms.CheckBox chbAlign;
        private System.Windows.Forms.CheckBox chbNoise;
        private System.Windows.Forms.GroupBox gbLanguage;
        private System.Windows.Forms.ComboBox cbLanguage;
    }
}

