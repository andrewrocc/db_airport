using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace db_airport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        private void Form1_Load(object sender, EventArgs e)
        {
            //при загрузке окна проверяем соединение с SQLServer
            try
            {
                connect = new SqlConnection(@"Data Source=DESKTOP-AR14CLQ\SQLEXPRESS;Initial Catalog=Kurswork;Integrated Security=True");
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка соединения!\n{ex.Message}", "Error!");
                Application.Exit();
            }
        }
    }
}