using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campus
{
    public partial class CuratorsWindow : Form
    {
        Database database = new Database();
        public CuratorsWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            CreateColumns();
            CreateInspectionColumns();
            RefreshDataGrid(dataGridView1);
            RefreshInspectionDataGrid(dataGridView2);
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Регистрационный номер", "Регистрационный номер");
            dataGridView1.Columns.Add("Фамилия" + "Имя" + "Отчество","ФИО");
            dataGridView1.Columns.Add("Группа", "Группа");
        }
        public void CreateInspectionColumns()
        {
            dataGridView2.Columns.Add("Фамилия" + "Имя" + "Отчество", "ФИО");
            dataGridView2.Columns.Add("Группа", "Группа");
            dataGridView2.Columns.Add("Номер_общежития", "Номер общежития");
            dataGridView2.Columns.Add("Номер_комнаты", "Номер комнаты");
            dataGridView2.Columns.Add("Состояние", "Состояние");
            dataGridView2.Columns.Add("Коментарии", "Комментарии");
            dataGridView2.Columns.Add("Дата_проверки", "Дата проверки");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1),  record.GetString(2));
        }

        private void InspectionReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetDateTime(6));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT Регистрационный_номер, CONCAT(Фамилия, ' ', Имя, ' ', Отчество) AS ФИО, Группа FROM Студент";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void RefreshInspectionDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT DISTINCT CONCAT(Фамилия, ' ', Имя, ' ', Отчество) AS ФИО, Группа, Номер_общежития, Комната.Номер_комнаты, Состояние, Коментарии, Дата_проверки FROM Студент\r\nLEFT JOIN Аренда ON Студент.Регистрационный_номер = Аренда.Регистрационный_номер\r\nLEFT JOIN Комната ON Аренда.id_комнаты = Комната.id_комнаты\r\nLEFT JOIN Журнал_инспекции ON Комната.id_комнаты = Журнал_инспекции.id_комнаты\r\nLEFT JOIN Инспекция ON Журнал_инспекции.Код_инспекции = Инспекция.Код_инспекции\r\nWHERE Комната.id_комнаты is not null\r\n";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                InspectionReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tbStudent.Text = "";
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchQuery = $"SELECT Регистрационный_номер, CONCAT(Фамилия, ' ', Имя, ' ', Отчество) AS ФИО, Группа FROM Студент WHERE CONCAT(Фамилия, Имя, Отчество) like '%" + tbStudent.Text + "%' AND Группа like '%" + tbGroup.Text + "%'";

            SqlCommand command = new SqlCommand(@searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow (dgv, reader);
            }
            reader.Close();
        }

        private void InspectionSearch(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string searchQuery = $"SELECT DISTINCT CONCAT(Фамилия, ' ', Имя, ' ', Отчество) AS ФИО, Группа, Номер_общежития, Комната.Номер_комнаты, Состояние, Коментарии, Дата_проверки FROM Студент\r\nLEFT JOIN Аренда ON Студент.Регистрационный_номер = Аренда.Регистрационный_номер\r\nLEFT JOIN Комната ON Аренда.id_комнаты = Комната.id_комнаты\r\nLEFT JOIN Журнал_инспекции ON Комната.id_комнаты = Журнал_инспекции.id_комнаты\r\nLEFT JOIN Инспекция ON Журнал_инспекции.Код_инспекции = Инспекция.Код_инспекции\r\nWHERE Комната.id_комнаты is not null\r\n AND CONCAT(Фамилия, Имя, Отчество) like '%" + tbInspectionStudent.Text + "%' AND Группа like '%" + tbInspectionGroup.Text + "%'";

            SqlCommand command = new SqlCommand(@searchQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                InspectionReadSingleRow(dgv, reader);
            }
            reader.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void pbInspectionClear_Click(object sender, EventArgs e)
        {
            tbInspectionStudent.Text = "";
        }

        private void pbInspectionSearch_Click(object sender, EventArgs e)
        {
            InspectionSearch(dataGridView2);
        }

        private void CuratorsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
