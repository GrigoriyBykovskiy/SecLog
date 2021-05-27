using System;
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
                     
                     // Вывод информации о подключении
                     Console.WriteLine("Подключение открыто");
                     Console.WriteLine("Свойства подключения:");
                     Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
                     Console.WriteLine($"\tБаза данных: {connection.Database}");
                     Console.WriteLine($"\tСервер: {connection.DataSource}");
                     Console.WriteLine($"\tВерсия сервера: {connection.ServerVersion}");
                     Console.WriteLine($"\tСостояние: {connection.State}");
                     Console.WriteLine($"\tWorkstationld: {connection.WorkstationId}");
                     
                     // Формируем запрос
                     SqlCommand command = new SqlCommand();
                     command.CommandText = "SELECT * FORM users WHERE ";
                     command.Connection = connection;
            
                     SqlDataReader reader = command.ExecuteReader();
                     Console.WriteLine("База данных создана");
                     
                     
                     
                     // if all ok
                     mainForm.Enabled = true;
                 }
             }
             catch (Exception excptn)
             {
                 MessageBox.Show("Анта бака!\nОшибка при Авторизации!\n" + excptn.StackTrace, "Ошибка",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
    }
}