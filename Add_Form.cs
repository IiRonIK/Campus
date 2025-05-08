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

namespace Campus
{
    public partial class Add_Form : Form
    {
        Database database = new Database();
        public Add_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var inspectionCode = tbInspectionCode.Text;
            var status = tbStatus.Text;
            string comments = tbComments.Text.ToString();
            var id = tbId.Text;

            var firstAddQuery = $"INSERT INTO Инспекция (Код_инспекции, Дата_проверки) VALUES ('{inspectionCode}', GETDATE())";
            var secondAddQuery = $"INSERT INTO Журнал_инспекции (Состояние, Коментарии, Код_инспекции ,id_комнаты) VALUES ('{status}', '{comments}', '{inspectionCode}', '{id}')";

            var firstCommand = new SqlCommand(firstAddQuery, database.getConnection());
            var secondCommand = new SqlCommand(secondAddQuery, database.getConnection());

            firstCommand.ExecuteNonQuery();
            secondCommand.ExecuteNonQuery();

            MessageBox.Show("Запись успешно создана!!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            database.closeConnection();
        }
    }
}
