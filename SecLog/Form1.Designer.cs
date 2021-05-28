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
            this.textBoxEncryptGetIV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonGetSign = new System.Windows.Forms.Button();
            this.buttonEcnrypt = new System.Windows.Forms.Button();
            this.buttonEncryptGetLog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxEncryptGetKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxDecrypt = new System.Windows.Forms.GroupBox();
            this.textBoxDecryptGetIV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonCheckSign = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonDecryptGetLog = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDecryptGetKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBoxEncrypt.Controls.Add(this.textBoxEncryptGetIV);
            this.groupBoxEncrypt.Controls.Add(this.label5);
            this.groupBoxEncrypt.Controls.Add(this.buttonGetSign);
            this.groupBoxEncrypt.Controls.Add(this.buttonEcnrypt);
            this.groupBoxEncrypt.Controls.Add(this.buttonEncryptGetLog);
            this.groupBoxEncrypt.Controls.Add(this.label3);
            this.groupBoxEncrypt.Controls.Add(this.textBoxEncryptGetKey);
            this.groupBoxEncrypt.Controls.Add(this.label1);
            this.groupBoxEncrypt.Location = new System.Drawing.Point(9, 10);
            this.groupBoxEncrypt.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxEncrypt.Name = "groupBoxEncrypt";
            this.groupBoxEncrypt.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxEncrypt.Size = new System.Drawing.Size(254, 232);
            this.groupBoxEncrypt.TabIndex = 0;
            this.groupBoxEncrypt.TabStop = false;
            this.groupBoxEncrypt.Text = "Шифрование/Подпись";
            // 
            // textBoxEncryptGetIV
            // 
            this.textBoxEncryptGetIV.Location = new System.Drawing.Point(4, 93);
            this.textBoxEncryptGetIV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncryptGetIV.Name = "textBoxEncryptGetIV";
            this.textBoxEncryptGetIV.Size = new System.Drawing.Size(151, 20);
            this.textBoxEncryptGetIV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(1, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Введите вектор инициализации:";
            // 
            // buttonGetSign
            // 
            this.buttonGetSign.Location = new System.Drawing.Point(175, 202);
            this.buttonGetSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGetSign.Name = "buttonGetSign";
            this.buttonGetSign.Size = new System.Drawing.Size(75, 24);
            this.buttonGetSign.TabIndex = 5;
            this.buttonGetSign.Text = "Подписать";
            this.buttonGetSign.UseVisualStyleBackColor = true;
            this.buttonGetSign.Click += new System.EventHandler(this.buttonGetSign_Click);
            // 
            // buttonEcnrypt
            // 
            this.buttonEcnrypt.Location = new System.Drawing.Point(4, 202);
            this.buttonEcnrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEcnrypt.Name = "buttonEcnrypt";
            this.buttonEcnrypt.Size = new System.Drawing.Size(75, 24);
            this.buttonEcnrypt.TabIndex = 4;
            this.buttonEcnrypt.Text = "Шифровать";
            this.buttonEcnrypt.UseVisualStyleBackColor = true;
            this.buttonEcnrypt.Click += new System.EventHandler(this.buttonEcnrypt_Click);
            // 
            // buttonEncryptGetLog
            // 
            this.buttonEncryptGetLog.Location = new System.Drawing.Point(4, 154);
            this.buttonEncryptGetLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEncryptGetLog.Name = "buttonEncryptGetLog";
            this.buttonEncryptGetLog.Size = new System.Drawing.Size(75, 24);
            this.buttonEncryptGetLog.TabIndex = 3;
            this.buttonEncryptGetLog.Text = "Выбрать";
            this.buttonEncryptGetLog.UseVisualStyleBackColor = true;
            this.buttonEncryptGetLog.Click += new System.EventHandler(this.buttonEncryptGetLog_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(2, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберите файл журнала:";
            // 
            // textBoxEncryptGetKey
            // 
            this.textBoxEncryptGetKey.Location = new System.Drawing.Point(4, 30);
            this.textBoxEncryptGetKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxEncryptGetKey.Name = "textBoxEncryptGetKey";
            this.textBoxEncryptGetKey.Size = new System.Drawing.Size(151, 20);
            this.textBoxEncryptGetKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ключ:";
            // 
            // groupBoxDecrypt
            // 
            this.groupBoxDecrypt.Controls.Add(this.textBoxDecryptGetIV);
            this.groupBoxDecrypt.Controls.Add(this.label6);
            this.groupBoxDecrypt.Controls.Add(this.buttonCheckSign);
            this.groupBoxDecrypt.Controls.Add(this.buttonDecrypt);
            this.groupBoxDecrypt.Controls.Add(this.buttonDecryptGetLog);
            this.groupBoxDecrypt.Controls.Add(this.label4);
            this.groupBoxDecrypt.Controls.Add(this.textBoxDecryptGetKey);
            this.groupBoxDecrypt.Controls.Add(this.label2);
            this.groupBoxDecrypt.Location = new System.Drawing.Point(308, 10);
            this.groupBoxDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxDecrypt.Name = "groupBoxDecrypt";
            this.groupBoxDecrypt.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxDecrypt.Size = new System.Drawing.Size(269, 232);
            this.groupBoxDecrypt.TabIndex = 1;
            this.groupBoxDecrypt.TabStop = false;
            this.groupBoxDecrypt.Text = "Дешифрование/Контроль целостности";
            // 
            // textBoxDecryptGetIV
            // 
            this.textBoxDecryptGetIV.Location = new System.Drawing.Point(4, 93);
            this.textBoxDecryptGetIV.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDecryptGetIV.Name = "textBoxDecryptGetIV";
            this.textBoxDecryptGetIV.Size = new System.Drawing.Size(151, 20);
            this.textBoxDecryptGetIV.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "Введите вектор инициализации/подпись:";
            // 
            // buttonCheckSign
            // 
            this.buttonCheckSign.Location = new System.Drawing.Point(145, 202);
            this.buttonCheckSign.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckSign.Name = "buttonCheckSign";
            this.buttonCheckSign.Size = new System.Drawing.Size(120, 24);
            this.buttonCheckSign.TabIndex = 6;
            this.buttonCheckSign.Text = "Проверить подпись";
            this.buttonCheckSign.UseVisualStyleBackColor = true;
            this.buttonCheckSign.Click += new System.EventHandler(this.buttonCheckSign_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(4, 202);
            this.buttonDecrypt.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(120, 24);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Дешифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonDecryptGetLog
            // 
            this.buttonDecryptGetLog.Location = new System.Drawing.Point(4, 154);
            this.buttonDecryptGetLog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDecryptGetLog.Name = "buttonDecryptGetLog";
            this.buttonDecryptGetLog.Size = new System.Drawing.Size(75, 24);
            this.buttonDecryptGetLog.TabIndex = 4;
            this.buttonDecryptGetLog.Text = "Выбрать";
            this.buttonDecryptGetLog.UseVisualStyleBackColor = true;
            this.buttonDecryptGetLog.Click += new System.EventHandler(this.buttonDecryptGetLog_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(1, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите файл журнала:";
            // 
            // textBoxDecryptGetKey
            // 
            this.textBoxDecryptGetKey.Location = new System.Drawing.Point(4, 30);
            this.textBoxDecryptGetKey.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDecryptGetKey.Name = "textBoxDecryptGetKey";
            this.textBoxDecryptGetKey.Size = new System.Drawing.Size(151, 20);
            this.textBoxDecryptGetKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите ключ:";
            // 
            // groupBoxAdditional
            // 
            this.groupBoxAdditional.Controls.Add(this.buttonAdditionalGenerateKey);
            this.groupBoxAdditional.Controls.Add(this.buttonAdditionalGetLogFromDB);
            this.groupBoxAdditional.Location = new System.Drawing.Point(9, 246);
            this.groupBoxAdditional.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxAdditional.Name = "groupBoxAdditional";
            this.groupBoxAdditional.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxAdditional.Size = new System.Drawing.Size(568, 112);
            this.groupBoxAdditional.TabIndex = 3;
            this.groupBoxAdditional.TabStop = false;
            this.groupBoxAdditional.Text = "Дополнительные возможности";
            // 
            // buttonAdditionalGenerateKey
            // 
            this.buttonAdditionalGenerateKey.Location = new System.Drawing.Point(4, 79);
            this.buttonAdditionalGenerateKey.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdditionalGenerateKey.Name = "buttonAdditionalGenerateKey";
            this.buttonAdditionalGenerateKey.Size = new System.Drawing.Size(150, 28);
            this.buttonAdditionalGenerateKey.TabIndex = 4;
            this.buttonAdditionalGenerateKey.Text = "Сгенерировать ключ";
            this.buttonAdditionalGenerateKey.UseVisualStyleBackColor = true;
            this.buttonAdditionalGenerateKey.Click += new System.EventHandler(this.buttonAdditionalGenerateKey_Click);
            // 
            // buttonAdditionalGetLogFromDB
            // 
            this.buttonAdditionalGetLogFromDB.Location = new System.Drawing.Point(4, 19);
            this.buttonAdditionalGetLogFromDB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdditionalGetLogFromDB.Name = "buttonAdditionalGetLogFromDB";
            this.buttonAdditionalGetLogFromDB.Size = new System.Drawing.Size(150, 28);
            this.buttonAdditionalGetLogFromDB.TabIndex = 3;
            this.buttonAdditionalGetLogFromDB.Text = "Получить журнал из БД";
            this.buttonAdditionalGetLogFromDB.UseVisualStyleBackColor = true;
            this.buttonAdditionalGetLogFromDB.Click += new System.EventHandler(this.buttonAdditionalGetLogFromDB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.groupBoxAdditional);
            this.Controls.Add(this.groupBoxDecrypt);
            this.Controls.Add(this.groupBoxEncrypt);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.TextBox textBoxDecryptGetKey;
        private System.Windows.Forms.TextBox textBoxEncryptGetKey;

        private System.Windows.Forms.GroupBox groupBoxEncrypt;
        private System.Windows.Forms.GroupBox groupBoxDecrypt;

        #endregion

        private System.Windows.Forms.TextBox textBoxEncryptGetIV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDecryptGetIV;
        private System.Windows.Forms.Label label6;
    }
}