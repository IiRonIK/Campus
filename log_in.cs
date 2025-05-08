using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Campus
{
    public partial class log_in : Form
    {
        Database database = new Database();

        enum Role{
            Администратор,
            Куратор,
            Комендант,
        }
        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void log_in_Load(object sender, EventArgs e)
        {

            pbClosedEye.Visible = false;
            tbUsername.MaxLength = 50;
            tbPassword.MaxLength = 50;
        }

        private void log_inButton_Click(object sender, EventArgs e)
        {
            var loginUser = tbUsername.Text;
            var passwordUser = md5.hashPassword(tbPassword.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = $"SELECT id_user, login_user, password_user, role FROM Пользователи WHERE login_user = '{loginUser}' AND password_user = '{passwordUser}'";

            SqlCommand command= new SqlCommand(queryString, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if(table.Rows.Count == 1)
            {
                Role userRole = (Role)Enum.Parse(typeof(Role), table.Rows[0]["role"].ToString());

                switch (userRole)
                {
                    case Role.Администратор:
                        Panel_Admin adminForm = new Panel_Admin();
                        this.Hide();
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        adminForm.Show();
                        break;
                    case Role.Куратор:
                        CuratorsWindow curatorForm = new CuratorsWindow();
                        this.Hide();
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        curatorForm.Show();
                        break;
                    case Role.Комендант:
                        CommandantsWindow comendantForm = new CommandantsWindow();
                        this.Hide();
                        MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        comendantForm.Show();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pbOpenedEye_Click(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
            pbOpenedEye.Visible = false;
            pbClosedEye.Visible = true;
        }

        private void pbClosedEye_Click_1(object sender, EventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
            pbOpenedEye.Visible = true;
            pbClosedEye.Visible = false;
        }
    }
}
