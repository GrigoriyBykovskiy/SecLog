using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SecLog
{
    public partial class Form1 : Form
    {
        public LogJournal EncryptLog;
        public LogJournal DecryptLog;
        public Form1()
        {
            InitializeComponent();
            /*var form2 = new Form2(this);
            form2.ShowDialog();*/
        }

        private void buttonAdditionalGenerateKey_Click(object sender, EventArgs e)
        {
            try
            {
                Aes aes = Aes.Create();
                aes.GenerateIV();
                aes.GenerateKey();

                StringBuilder EncryptKey = new StringBuilder();
                StringBuilder EncryptIV = new StringBuilder();


                EncryptKey.Clear();
                // Return the hexadecimal string.
                for (int i = 0; i < aes.Key.Length; i++)
                {
                    EncryptKey.Append(aes.Key[i].ToString("x2"));
                }

                string Key = EncryptKey.ToString();
                textBoxEncryptGetKey.Text = Key;

                EncryptIV.Clear();
                // Return the hexadecimal string.
                for (int i = 0; i < aes.IV.Length; i++)
                {
                    EncryptIV.Append(aes.IV[i].ToString("x2"));
                }

                string InitialVector = EncryptIV.ToString();
                textBoxEncryptGetIV.Text = InitialVector;

                MessageBox.Show("Анта бака!\nКлюч сгенерирован успешно\nКлюч для шифрования/подписи: " + Key + "\nВектор инициализации для шифрования: " + InitialVector + "\n",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при генерации ключа!\n" + excptn.Message + excptn.StackTrace, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdditionalGetLogFromDB_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/LogFromDB.csv"))
                {
                    throw new Exception("\nФайл уже получен!\n");
                }
                // Получаем контекст подключения к БД
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appconfig.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");
                string sql = "SELECT * FROM UserException;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Создаем объект DataAdapter
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    // Создаем объект DataSet
                    DataSet ds = new DataSet();
                    // Заполняем Dataset
                    adapter.Fill(ds);

                    using (StreamWriter sw = new StreamWriter(Directory.GetCurrentDirectory() + "/LogFromDB.csv", true, Encoding.UTF8))
                    {
                        foreach (DataTable dt in ds.Tables)
                        {
                            foreach (DataColumn column in dt.Columns)
                            {
                                sw.Write($"{column.ColumnName};");
                            }
                            sw.WriteLine();
                            // перебор всех строк таблицы
                            foreach (DataRow row in dt.Rows)
                            {
                                // получаем все ячейки строки
                                var cells = row.ItemArray;
                                foreach (object cell in cells)
                                {
                                    if (DBNull.Value.Equals(cell))
                                        sw.Write("NULL;");
                                    else
                                        sw.Write($"{cell};");
                                }
                                sw.WriteLine();
                            }
                        }
                    }
                }

                MessageBox.Show("Успешно!\nФайл находится в директории:\n" + Directory.GetCurrentDirectory(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при получении файла журнала!\n" + excptn.Message + excptn.StackTrace, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEncryptGetLog_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;
                        EncryptLog = new LogJournal(filePath);
                    }
                    catch (Exception excptn)
                    {
                        MessageBox.Show("Анта бака!\nОшибка при считывании файла журнала!\n" + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void buttonDecryptGetLog_Click(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        filePath = openFileDialog.FileName;
                        DecryptLog = new LogJournal(filePath);
                    }
                    catch (Exception excptn)
                    {
                        MessageBox.Show("Анта бака!\nОшибка при считывании файла журнала!\n" + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void buttonEcnrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEncryptGetKey.Text == "")
                {
                    throw new Exception("\nКлюч не может быть пустыми!\n");
                }

                if (textBoxEncryptGetIV.Text == "")
                {
                    throw new Exception("\nВектор инициализации не может быть пустыми!\n");
                }

                byte[] bytesFromBuilderEncryptKey = HexToByteArray(textBoxEncryptGetKey.Text);
                byte[] bytesFromBuilderEncryptIV = HexToByteArray(textBoxEncryptGetIV.Text);

                // Encrypt the string to an array of bytes.
                byte[] encrypted = EncryptStringToBytes_Aes(EncryptLog.Data.ToString(), bytesFromBuilderEncryptKey, bytesFromBuilderEncryptIV);

                using (BinaryWriter writer = new BinaryWriter(File.Open(Directory.GetCurrentDirectory() + "/" + "encrypt_output.csv", FileMode.Create)))
                {
                    writer.Write(encrypted, 0, encrypted.Length);
                }

                MessageBox.Show("Успешно!\nЗашифрованный файл находится в директории:\n" + Directory.GetCurrentDirectory(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при шифровании файла журнала!\n" + excptn.Message + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDecryptGetKey.Text == "")
                {
                    throw new Exception("\nКлюч не может быть пустыми!\n");
                }

                if (textBoxDecryptGetIV.Text == "")
                {
                    throw new Exception("\nВектор инициализации не может быть пустыми!\n");
                }

                byte[] bytesFromBuilderDecryptKey = HexToByteArray(textBoxDecryptGetKey.Text);
                byte[] bytesFromBuilderDecryptIV = HexToByteArray(textBoxDecryptGetIV.Text);

                // Decrypt the bytes to a string.
                string roundtrip = DecryptStringFromBytes_Aes(DecryptLog.BinaryData, bytesFromBuilderDecryptKey, bytesFromBuilderDecryptIV);

                File.WriteAllText(Directory.GetCurrentDirectory() + "/" + "decrypt_output.csv", roundtrip);

                MessageBox.Show("Успешно!\nДешифрованный файл находится в директории:\n" + Directory.GetCurrentDirectory(), "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при дефровании файла журнала!\n" + excptn.Message + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static byte[] HexToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
              .Where(x => x % 2 == 0)
              .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
              .ToArray();
        }

        private void buttonGetSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEncryptGetKey.Text == "")
                {
                    throw new Exception("\nКлюч не может быть пустыми!\n");
                }

                string salt = textBoxEncryptGetKey.Text;
                byte[] hashValue;


                //Create a new instance of the UnicodeEncoding class to
                //convert the string into an array of Unicode bytes.
                UnicodeEncoding ue = new UnicodeEncoding();

                //Convert the string into an array of bytes.
                byte[] messageBytes = ue.GetBytes(EncryptLog.Data.ToString() + salt);

                //Create a new instance of the SHA256 class to create
                //the hash value.
                SHA256 shHash = SHA256.Create();

                //Create the hash value from the array of bytes.
                hashValue = shHash.ComputeHash(messageBytes);

                // Return the hexadecimal string.
                StringBuilder outputHashValue = new StringBuilder();

                foreach (byte b in hashValue)
                {
                    outputHashValue.Append(b.ToString("X2"));
                }

                textBoxDecryptGetIV.Text = outputHashValue.ToString();

                MessageBox.Show("Успешно!\nПодпись файла: " + outputHashValue.ToString() + "\n", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при подписывании файла журнала!\n" + excptn.Message + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCheckSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDecryptGetKey.Text == "")
                {
                    throw new Exception("\nКлюч не может быть пустыми!\n");
                }

                if (textBoxDecryptGetIV.Text == "")
                {
                    throw new Exception("\nПодпись не может быть пустой!\n");
                }

                string salt = textBoxDecryptGetKey.Text;

                //This hash value is produced from "This is the original message!"
                //using SHA256.
                //byte[] sentHashValue = { 185, 203, 236, 22, 3, 228, 27, 130, 87, 23, 244, 15, 87, 88, 14, 43, 37, 61, 106, 224, 81, 172, 224, 211, 104, 85, 194, 197, 194, 25, 120, 217 };
                byte[] sentHashValue = HexToByteArray(textBoxDecryptGetIV.Text);
                //This is the string that corresponds to the previous hash value.
                string messageString = "This is the original message!";

                byte[] compareHashValue;

                //Create a new instance of the UnicodeEncoding class to
                //convert the string into an array of Unicode bytes.
                UnicodeEncoding ue = new UnicodeEncoding();

                //Convert the string into an array of bytes.
                byte[] messageBytes = ue.GetBytes(DecryptLog.Data.ToString() + salt);

                //Create a new instance of the SHA256 class to create
                //the hash value.
                SHA256 shHash = SHA256.Create();

                //Create the hash value from the array of bytes.
                compareHashValue = shHash.ComputeHash(messageBytes);

                bool same = true;

                //Compare the values of the two byte arrays.
                for (int x = 0; x < sentHashValue.Length; x++)
                {
                    if (sentHashValue[x] != compareHashValue[x])
                    {
                        same = false;
                    }
                }
                //Display whether or not the hash values are the same.
                if (same)
                {
                    MessageBox.Show("Успешно!\nФайл не был изменен\n", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception("\nФайл был измнен!\n");
                }


                
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при дефровании файла журнала!\n" + excptn.Message + excptn.StackTrace, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}