using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProjectSB
{
    /*using MySql.Data;
    using MySql.Data.MySqlClient;

    namespace Data
    {
        public class DBConnection
        {
            private DBConnection()
            {
            }

            private string databaseName = string.Empty;
            public string DatabaseName
            {
                get { return databaseName; }
                set { databaseName = value; }
            }

            public string Password { get; set; }
            private MySqlConnection connection = null;
            public MySqlConnection Connection
            {
                get { return connection; }
            }

            private static DBConnection _instance = null;
            public static DBConnection Instance()
            {
                if (_instance == null)
                    _instance = new DBConnection();
                return _instance;
            }

            public bool IsConnect()
            {
                if (Connection == null)
                {
                    if (String.IsNullOrEmpty(databaseName))
                        return false;
                    string connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", databaseName);
                    connection = new MySqlConnection(connstring);
                    connection.Open();
                }

                return true;
            }

            public void Close()
            {
                connection.Close();
            }
        }
    }*/
    public partial class ScoreBoard : Form
    {
        public ScoreBoard()
        {
            InitializeComponent();
            deletebtn.MouseHover += new EventHandler(deletebtn_MouseHover);
            deletebtn.MouseLeave += new EventHandler(deletebtn_MouseLeave);
            backbtn.MouseHover += new EventHandler(backbtn_MouseHover);
            backbtn.MouseLeave += new EventHandler(backbtn_MouseLeave);
        }

        void deletebtn_MouseLeave(object sender, EventArgs e)
        {
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.dustbin));
        }


        void deletebtn_MouseHover(object sender, EventArgs e)
        {
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.dustbin2));
        }
        void backbtn_MouseLeave(object sender, EventArgs e)
        {
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back));
        }


        void backbtn_MouseHover(object sender, EventArgs e)
        {
            this.backbtn.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.back2));
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            AdminAuthentication obj = new AdminAuthentication();
            obj.Show();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            Visible = false;
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
