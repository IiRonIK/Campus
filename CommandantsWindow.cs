using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Campus
{

    public partial class CommandantsWindow : Form
    {
        Database database = new Database();
        int selectedRow;
        public CommandantsWindow()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateRentColumns()
        {
            dataGridView1.Columns.Add("Номер_договора", "Номер договора");
            dataGridView1.Columns.Add("Продолжительность_аренды", "Продолжительность аренды");
            dataGridView1.Columns.Add("Дата_заселения", "Дата заселения");
            dataGridView1.Columns.Add("Дата_предполагаемого_выселения", "Дата предполагаемого выселения");
            dataGridView1.Columns.Add("Регистрационный_номер", "Регистрационный номер");
            dataGridView1.Columns.Add("Дата_фактического_выселения", "Дата фактического выселения");
            dataGridView1.Columns.Add("id_комнаты", "ID комнаты");
        }

        private void CreateRoomsColumns()
        {
            dataGridView2.Columns.Add("Номер_комнаты", "Номер комнаты");
            dataGridView2.Columns.Add("Количество_свободных_мест", "Количество свободных мест");
            dataGridView2.Columns.Add("Общее_количество_мест", "Общее количество мест");
            dataGridView2.Columns.Add("Номер_общежития", "Номер общежития");
            dataGridView2.Columns.Add("Номер_блока", "Номер блока");
            dataGridView2.Columns.Add("Арендная_плата", "Арендная плата");
            dataGridView2.Columns.Add("id_комнаты", "ID комнаты");
        }

        private void CreateInstectionsColumns()
        {
            dataGridView3.Columns.Add("Код_инспекции", "Код инспекции");
            dataGridView3.Columns.Add("Состояние", "Состояние");
            dataGridView3.Columns.Add("Коментарии", "Комментарии");
            dataGridView3.Columns.Add("id_комнаты", "ID комнаты");
            dataGridView3.Columns.Add("Дата_проверки", "Дата проверки");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetDateTime(2), record.GetDateTime(3), record.GetInt32(4), record.GetValue(5), record.GetInt32(6));
        }

        private void RoomsReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetString(0), record.GetInt32(1), record.GetInt32(2), record.GetInt32(3), record.GetInt32(4), record.GetString(5), record.GetInt32(6));
        }

        private void InspectionsReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetInt32(3), record.GetDateTime(4));
        }

        private void RefreshDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT * FROM Аренда";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }
            reader.Close();

            database.closeConnection();
        }

        private void RefreshRoomDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT * FROM Комната";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                RoomsReadSingleRow(dgv, reader);
            }
            reader.Close();

            database.closeConnection();
        }

        private void RefreshInspectionsDataGrid(DataGridView dgv)
        {
            dgv.Rows.Clear();

            string queryString = $"SELECT Журнал_инспекции.Код_инспекции, Состояние, Коментарии, id_комнаты, Дата_проверки FROM Журнал_инспекции LEFT JOIN Инспекция ON Инспекция.Код_инспекции = Журнал_инспекции.Код_инспекции";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                InspectionsReadSingleRow(dgv, reader);
            }
            reader.Close();

            database.closeConnection();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var contractNumber = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var departDate = dataGridView1.Rows[index].Cells[5].Value.ToString();

                var changeQuery = $"UPDATE Аренда SET Дата_фактического_выселения = '{departDate}' WHERE Номер_договора = '{contractNumber}'";

                var command = new SqlCommand(changeQuery, database.getConnection());

                command.ExecuteNonQuery();
            }
            database.closeConnection();
        }

        private void FreeRooms(DataGridView dgv)
        {
            dgv.Rows.Clear();
            database.openConnection();

            if(cbFreeRooms.Checked)
            {
                var query = $"SELECT * FROM Комната WHERE Количество_свободных_мест > 0";
                var command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RoomsReadSingleRow(dgv, reader);
                }
                reader.Close();
            }
            else
            {
                var query = $"SELECT * FROM Комната";
                var command = new SqlCommand(query, database.getConnection());
                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    RoomsReadSingleRow(dgv, reader);
                }
                reader.Close();
            }

            database.closeConnection();
        }

        private void cbFreeRooms_CheckedChanged(object sender, EventArgs e)
        {
            FreeRooms(dataGridView2);
        }

        private void saveRoomChangesButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridView2.Rows.Count; index++)
            {

                var id = dataGridView2.Rows[index].Cells[6].Value.ToString();
                var availableSeats = dataGridView2.Rows[index].Cells[1].Value.ToString();
                var totalSeats = dataGridView2.Rows[index].Cells[2].Value.ToString();

                var availableSeatsInteger = int.Parse(availableSeats);
                var totalSeatsInteger = int.Parse(totalSeats);

                if (availableSeatsInteger <= totalSeatsInteger)
                {
                    var changeQuery = $"UPDATE Комната SET Количество_свободных_мест = '{availableSeats}' WHERE id_комнаты = '{id}'";

                    var command = new SqlCommand(changeQuery, database.getConnection());

                    command.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("Количество свободных мест больше, чем общее количество мест!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }
            database.closeConnection();
        }

        private void CommandantsWindow_Load(object sender, EventArgs e)
        {
            CreateRentColumns();
            RefreshDataGrid(dataGridView1);
            dataGridView1.ReadOnly = false;
            for (int i = 0; i <= 6; i++)
            {
                if (i != 5)
                    dataGridView1.Columns[i].ReadOnly = true;
            }
            CreateRoomsColumns();
            RefreshRoomDataGrid(dataGridView2);
            dataGridView2.ReadOnly = false;
            for (int i = 0; i <= 6; i++)
            {
                if (i != 1)
                    dataGridView2.Columns[i].ReadOnly = true;
            }
            CreateInstectionsColumns();
            RefreshInspectionsDataGrid(dataGridView3);
        }

        private void GetContracts(DataGridView dgv)
        {
            dgv.Rows.Clear();
            database.openConnection();

            if (cbGetContracts.Checked)
            {
                var query = $"SELECT * FROM Аренда WHERE Дата_предполагаемого_выселения <= DATEADD(WEEK, 2, GETDATE()) ORDER BY Дата_предполагаемого_выселения";

                var command = new SqlCommand(query, database.getConnection());

                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
                reader.Close();
            }
            else
            {
                var query = $"SELECT * FROM Аренда";

                var command = new SqlCommand(query, database.getConnection());

                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ReadSingleRow(dgv, reader);
                }
                reader.Close();
            }
        }

        private void cbGetContracts_CheckedChanged(object sender, EventArgs e)
        {
            GetContracts(dataGridView1);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Add_Form addfrm = new Add_Form();
            addfrm.Show();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            RefreshInspectionsDataGrid(dataGridView3);
        }

        private void CommandantsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
