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
    public partial class Panel_Admin : Form
    {
        Database database = new Database();
        public Panel_Admin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "ID");
            dataGridView1.Columns.Add("Login", "Логин");
            dataGridView1.Columns.Add("Password", "Пароль");
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn()
            {
                Name = "ComboBoxColumn",
                HeaderText = "Роль",
                DataSource = new string[] {"Администратор", "Куратор", "Комендант"}
            };
            dataGridView1.Columns.Add(comboBoxColumn);
        }

        private void ReadSingleRow(IDataRecord record)
        {
            dataGridView1.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3));
        }

        private void RefreshDataGrid()
        {
            dataGridView1.Rows.Clear();

            string queryString = $"select * from Пользователи";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(reader);
            }

            reader.Close();

            database.closeConnection();
        }

        private void Panel_Admin_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid();
            dataGridView1.ReadOnly = false;
            for (int i = 0; i <= 3; i++)
            {
                if (i != 3)
                    dataGridView1.Columns[i].ReadOnly = true;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            Add_role add_Role = new Add_role();
            add_Role.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var role = dataGridView1.Rows[index].Cells[3].Value.ToString();

                var changeQuery = $"UPDATE Пользователи SET role = '{role}' WHERE id_user = '{id}'";

                var command = new SqlCommand(changeQuery, database.getConnection());
                command.ExecuteNonQuery();
            }
            database.closeConnection();

            RefreshDataGrid();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;

            var id = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells[0].Value);
            var deleteQuery = $"DELETE FROM Пользователи WHERE id_user = '{id}'";

            var command = new SqlCommand(deleteQuery, database.getConnection());
            command.ExecuteNonQuery();

            database.closeConnection();

            RefreshDataGrid();
        }

        private void pbRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid();
        }

        private void Panel_Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
