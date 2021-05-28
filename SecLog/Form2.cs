using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SecLog
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 mainForm)
        {
            this.mainForm = mainForm;
            // block main form (auth need)
            mainForm.Enabled = false;

            InitializeComponent();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception("\nПоле логина не может быть пустым\n");
                }
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    throw new Exception("\nПоле пароля не может быть пустым\n");
                }

                // Получаем контекст подключения к БД
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appconfig.json");
                var config = builder.Build();
                string connectionString = config.GetConnectionString("DefaultConnection");

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Открываем подключение
                    connection.Open();

                    // Формируем запрос
                    SqlCommand command = new SqlCommand();

                    // Получаем хэш введенного пароля
                    MD5 md5 = MD5.Create();
                    string passwordHash = GetHash(md5, textBox2.Text);


                    command.CommandText = "SELECT * FROM Users Where Login = \'" + textBox1.Text + "\' AND " + "Password = \'" + passwordHash + "\';";
                    command.Connection = connection;

                    // Отправляем запрос
                    SqlDataReader reader = command.ExecuteReader();

                    // Если ответ не пришел - кидаем ошибку
                    if (!reader.HasRows)
                    {
                        throw new Exception("\nОтвет из БД пустой\n");
                    }

                    reader.Close();

                    // Иначе разрешаем работу с главной формой и выводим сообщение об успешной авторизации
                    mainForm.Enabled = true;

                    MessageBox.Show("Анта бака!\nАвторизация прошла успешно!\n", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Закрываем форму авторизации
                    this.Close();
                }
            }
            catch (Exception excptn)
            {
                MessageBox.Show("Анта бака!\nОшибка при Авторизации!\n" + excptn.Message + excptn.StackTrace, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        /*
        // Verify a hash against a string.
        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }
        */
    }
}