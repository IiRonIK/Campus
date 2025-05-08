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
    public partial class Add_role : Form
    {
        Database database = new Database();
        public Add_role()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var login = tbLogin.Text;
            var password = md5.hashPassword(tbPassword.Text);
            var role = cbRoles.Text;

            if (checkuser())
            {
                return;
            }

            var addQuery = $"INSERT INTO Пользователи (login_user, password_user, role) VALUES ('{login}', '{password}', '{role}')";
            
            var command = new SqlCommand(addQuery, database.getConnection());

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан!");
            }

            database.closeConnection();
        }

        private Boolean checkuser()
        {
            var loginUser = tbLogin.Text;
            var passwordUser = md5.hashPassword(tbPassword.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"select id_user, login_user, password_user, role from Пользователи where login_user = '{loginUser}' and password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Add_role_Load(object sender, EventArgs e)
        {
            tbLogin.MaxLength = 50;
            tbPassword.MaxLength = 50;
        }
    }
}
