using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace SecLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}