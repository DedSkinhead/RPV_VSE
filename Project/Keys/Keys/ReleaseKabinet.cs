using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Keys
{
    public partial class ReleaseKabinet : Form
    {
        Bd Bd = new Bd();
        public int index;
        public ReleaseKabinet()
        {
            InitializeComponent();
        }

        private void ReleaseConfirmation_Click(object sender, EventArgs e)
        {
            int indexRelease = index+1;
            Bd.openConnection();
            string query = $"update Kabinet set State_kabinet='1',Id_teacher='1' where Id_kabinet='{indexRelease}'";
            SqlCommand command = new SqlCommand(query, Bd.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Кабинет свободен");
            Watchman watchman = new Watchman();
            Hide();
            watchman.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Watchman watchman = new Watchman();
            Hide();
            watchman.Show();
        }
    }
}
