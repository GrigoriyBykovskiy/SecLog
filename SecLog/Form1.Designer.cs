namespace SecLog
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEncrypt = new System.Windows.Forms.GroupBox();
            this.buttonGetSign = new System.Windows.Forms.Button();
            this.buttonEcnrypt = new System.Windows.Forms.Button();
            this.buttonEncryptGetLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEncryptGetKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDecrypt = new System.Windows.Forms.GroupBox();
            this.buttonCheckSign = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonDecryptGetLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecryptGetKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBoxAdditional = new System.Windows.Forms.GroupBox();
            this.buttonAdditionalGenerateKey = new System.Windows.Forms.Button();
            this.buttonAdditionalGetLogFromDB = new System.Windows.Forms.Button();
            this.groupBoxEncrypt.SuspendLayout();
            this.groupBoxDecrypt.SuspendLayout();
            this.groupBoxAdditional.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEncrypt
            // 
            this.groupBoxEncrypt.Controls.Add(this.buttonGetSign);
            this.groupBoxEncrypt.Controls.Add(this.buttonEcnrypt);
            this.groupBoxEncrypt.Controls.Add(this.buttonEncryptGetLog);
            this.groupBoxEncrypt.Controls.Add(this.label3);
            this.groupBoxEncrypt.Controls.Add(this.textBoxEncryptGetKey);
            this.groupBoxEncrypt.Controls.Add(this.label1);
            this.groupBoxEncrypt.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Size = new System.Drawing.Size(339, 285);
            this.groupBoxEncrypt.TabIndex = 0;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "Шифрование/Подпись";
            // 
            // buttonGetSign
            // 
            this.buttonGetSign.Location = new System.Drawing.Point(233, 249);
            this.buttonGetSign.Name = "buttonGetSign";
            this.buttonGetSign.Size = new System.Drawing.Size(100, 30);
            this.buttonGetSign.TabIndex = 5;
            this.buttonGetSign.Text = "Подписать";
            this.buttonGetSign.UseVisualStyleBackColor = true;
            // 
            // buttonEcnrypt
            // 
            this.buttonEcnrypt.Location = new System.Drawing.Point(6, 249);
            this.buttonEcnrypt.Name = "buttonEcnrypt";
            this.buttonEcnrypt.Size = new System.Drawing.Size(100, 30);
            this.buttonEcnrypt.TabIndex = 4;
            this.buttonEcnrypt.Text = "Шифровать";
            this.buttonEcnrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptGetLog
            // 
            this.buttonEncryptGetLog.Location = new System.Drawing.Point(6, 105);
            this.buttonEncryptGetLog.Name = "buttonEncryptGetLog";
            this.buttonEncryptGetLog.Size = new System.Drawing.Size(100, 30);
            this.buttonEncryptGetLog.TabIndex = 3;
            this.buttonEncryptGetLog.Text = "Выбрать";
            this.buttonEncryptGetLog.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите файл журнала:";
            // 
            // textBoxEncryptGetKey
            // 
            this.textBoxEncryptGetKey.Location = new System.Drawing.Point(6, 37);
            this.textBoxEncryptGetKey.Name = "textBoxEncryptGetKey";
            this.textBoxEncryptGetKey.Size = new System.Drawing.Size(200, 22);
            this.textBoxEncryptGetKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ключ:";
            // 
            // groupBoxDecrypt
            // 
            this.groupBoxDecrypt.Controls.Add(this.buttonCheckSign);
            this.groupBoxDecrypt.Controls.Add(this.buttonDecrypt);
            this.groupBoxDecrypt.Controls.Add(this.buttonDecryptGetLog);
            this.groupBoxDecrypt.Controls.Add(this.label4);
            this.groupBoxDecrypt.Controls.Add(this.textBoxDecryptGetKey);
            this.groupBoxDecrypt.Controls.Add(this.label2);
            this.groupBoxDecrypt.Location = new System.Drawing.Point(411, 12);
            this.groupBoxDecrypt.Name = "groupBoxDecrypt";
            this.groupBoxDecrypt.Size = new System.Drawing.Size(359, 285);
            this.groupBoxDecrypt.TabIndex = 1;
            this.groupBoxDecrypt.TabStop = false;
            this.groupBoxDecrypt.Text = "Дешифрование/Контроль целостности";
            // 
            // buttonCheckSign
            // 
            this.buttonCheckSign.Location = new System.Drawing.Point(203, 249);
            this.buttonCheckSign.Name = "buttonCheckSign";
            this.buttonCheckSign.Size = new System.Drawing.Size(150, 30);
            this.buttonCheckSign.TabIndex = 6;
            this.buttonCheckSign.Text = "Проверить подпись";
            this.buttonCheckSign.UseVisualStyleBackColor = true;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(6, 249);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(150, 30);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Дешифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonDecryptGetLog
            // 
            this.buttonDecryptGetLog.Location = new System.Drawing.Point(6, 105);
            this.buttonDecryptGetLog.Name = "buttonDecryptGetLog";
            this.buttonDecryptGetLog.Size = new System.Drawing.Size(100, 30);
            this.buttonDecryptGetLog.TabIndex = 4;
            this.buttonDecryptGetLog.Text = "Выбрать";
            this.buttonDecryptGetLog.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите файл журнала:";
            // 
            // textBoxDecryptGetKey
            // 
            this.textBoxDecryptGetKey.Location = new System.Drawing.Point(6, 37);
            this.textBoxDecryptGetKey.Name = "textBoxDecryptGetKey";
            this.textBoxDecryptGetKey.Size = new System.Drawing.Size(200, 22);
            this.textBoxDecryptGetKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите ключ:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(467, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(79, 36);
            this.listBox1.TabIndex = 2;
            // 
            // groupBoxAdditional
            // 
            this.groupBoxAdditional.Controls.Add(this.buttonAdditionalGenerateKey);
            this.groupBoxAdditional.Controls.Add(this.buttonAdditionalGetLogFromDB);
            this.groupBoxAdditional.Controls.Add(this.listBox1);
            this.groupBoxAdditional.Location = new System.Drawing.Point(12, 303);
            this.groupBoxAdditional.Name = "groupBoxAdditional";
            this.groupBoxAdditional.Size = new System.Drawing.Size(758, 138);
            this.groupBoxAdditional.TabIndex = 3;
            this.groupBoxAdditional.TabStop = false;
            this.groupBoxAdditional.Text = "Дополнительные возможности";
            // 
            // buttonAdditionalGenerateKey
            // 
            this.buttonAdditionalGenerateKey.Location = new System.Drawing.Point(6, 97);
            this.buttonAdditionalGenerateKey.Name = "buttonAdditionalGenerateKey";
            this.buttonAdditionalGenerateKey.Size = new System.Drawing.Size(200, 35);
            this.buttonAdditionalGenerateKey.TabIndex = 4;
            this.buttonAdditionalGenerateKey.Text = "Сгенерировать ключ";
            this.buttonAdditionalGenerateKey.UseVisualStyleBackColor = true;
            // 
            // buttonAdditionalGetLogFromDB
            // 
            this.buttonAdditionalGetLogFromDB.Location = new System.Drawing.Point(6, 23);
            this.buttonAdditionalGetLogFromDB.Name = "buttonAdditionalGetLogFromDB";
            this.buttonAdditionalGetLogFromDB.Size = new System.Drawing.Size(200, 35);
            this.buttonAdditionalGetLogFromDB.TabIndex = 3;
            this.buttonAdditionalGetLogFromDB.Text = "Получить журнал из БД";
            this.buttonAdditionalGetLogFromDB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.groupBoxAdditional);
            this.Controls.Add(this.groupBoxDecrypt);
            this.Controls.Add(this.groupBoxEncrypt);
            this.Name = "Form1";
            this.Text = "SecLog";
            this.groupBoxEncrypt.ResumeLayout(false);
            this.groupBoxEncrypt.PerformLayout();
            this.groupBoxDecrypt.ResumeLayout(false);
            this.groupBoxDecrypt.PerformLayout();
            this.groupBoxAdditional.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonDecryptGetLog;
        private System.Windows.Forms.Button buttonGetSign;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonCheckSign;
        private System.Windows.Forms.Button buttonAdditionalGetLogFromDB;
        private System.Windows.Forms.Button buttonAdditionalGenerateKey;
        private System.Windows.Forms.Button buttonEcnrypt;
        private System.Windows.Forms.Button buttonEncryptGetLog;
        private System.Windows.Forms.GroupBox groupBoxAdditional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxDecryptGetKey;
        private System.Windows.Forms.TextBox textBoxEncryptGetKey;

        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBoxDecrypt;

        #endregion
    }
}