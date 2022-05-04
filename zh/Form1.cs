using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Data.Sql;
using System.Data.SqlClient;

namespace zh
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        List<datamodel> source = new List<datamodel>();

        DataTable datatable = new DataTable();
        string Filter_title = "title";
        string Filter_author = "author";
        string Filter_date = "date";
        string Filter_views = "views";
        string Filter_likes = "likes";
        string Filter_link = "link";
        public Form1()

        {
            InitializeComponent();

            server = "127.0.0.1";
            database = "ted";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            StreamReader r = new StreamReader("data_s.json");
            String jsonString = r.ReadToEnd();
            source = JsonConvert.DeserializeObject<List<datamodel>>(jsonString);
            connection.Open();
            foreach (datamodel item in source)
            {

                String query2 = "INSERT INTO ted_data (`title`,`author`,`date`,`views`,`likes`,`link`) VALUES('" + item.title.Replace("'", "") + "','" + item.author.Replace("'", "") + "','" + item.date + "','" + item.views + "','" + item.likes + "','" + item.link + "')";
                query2.Replace("'", "");
                MySqlCommand cmd = new MySqlCommand(query2, connection);
                cmd.ExecuteNonQuery();
            }
            //dataGridView1.DataSource = source;
            //advancedDataGridView1.DataSource = source;

            datatable.Columns.Add("title", typeof(string));
            datatable.Columns.Add("author", typeof(string));
            datatable.Columns.Add("date", typeof(string));
            datatable.Columns.Add("views", typeof(int));
            datatable.Columns.Add("likes", typeof(int));
            datatable.Columns.Add("link", typeof(string));
            foreach (datamodel item in source)
            {
                datatable.Rows.Add(new object[] { item.title, item.author , item.date, item.views, item.likes, item.link });
            }
            dataGridView1.DataSource = datatable;


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }


        private void author_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Filter_author, author.Text);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (datamodel item in source)
            {
                if (author.Text == item.author) 
                {
                    this.chart1.Series["views"].Points.AddXY(author.Text, item.views);
                    this.chart1.Series["likes"].Points.AddXY(author.Text, item.likes);
                }
            }

        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Filter_title, title.Text);
        }

        private void date_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Filter_date, date.Text);
        }

        private void views_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", Filter_views, views.Text);
        }

        private void likes_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", Filter_likes, likes.Text);
        }

        private void links_TextChanged(object sender, EventArgs e)
        {
            datatable.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", Filter_link, links.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string link = dataGridView1.SelectedCells[0].Value.ToString();
            try
            {
                System.Diagnostics.Process.Start(link);
            }
            catch (System.ComponentModel.Win32Exception)
            {

                //throw;
            }
           
        }
    }
    class datamodel
    {
        public String title { get; set; }
        public String author { get; set; }
        public String date { get; set; }
        public int views { get; set; }
        public int likes { get; set; }
        public String link { get; set; }

    }
}
