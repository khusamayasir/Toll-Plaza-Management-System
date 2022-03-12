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

namespace Assignment_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(DateTime.Now.ToString("hh:mm:ss tt"));
            progressBar1.Hide();
            progressBar2.Hide();
            label3.Hide();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }
        
        Queue my_queue = new Queue();

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Show();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar1.Value = i;
            }
            progressBar1.Hide();

            //WITH ARRAY
            string t = textBox1.Text;
            //my_queue.record[my_queue.i] = t;
            int a = my_queue.insertQ(t);

            if (my_queue.i >= 5)
            {
                string message = "Queue is OverFlow.";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Data successfully entered.";
                string title = "Thank You";
                MessageBox.Show(message, title);
            }
            my_queue.i++;
            textBox1.Clear();

            //WITH DATA BASE
            //my_queue.insertQ(textBox1.Text);
            //textBox1.Clear();
            //string message = "Data successfully entered.";
            //string title = "Alert";
            //MessageBox.Show(message, title);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar2.Show();
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar2.Value = i;
            }
            progressBar2.Hide();

            //WITH ARRAY
            string d;
            d = my_queue.printQueue();
            label3.Text = d;
            label3.Show();

            //WITH DATA BASE
            //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Toll_Plaza_System;Integrated Security=True");
            //string curr = "select top 1 noplate from record where timeout is null order by timein ";
            //conn.Open();
            //SqlDataAdapter ad = new SqlDataAdapter(curr, conn);
            //DataTable dt = new DataTable();
            //ad.Fill(dt);
            //label3.Text = dt.Rows[0][0].ToString() ;
            //label3.Show();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            label3.Hide();
            progressBar2.Show();
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 2000000;
            for (int i = 0; i <= 2000000; i++)
            {
                progressBar2.Value = i;
            }
            progressBar2.Hide();

            //WITH ARRAY
            int a = my_queue.dequeue();
            if (my_queue.front == my_queue.rear)
            {
                string message = "Queue is Empty";
                string title = "Alert";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Car with number plate (" + my_queue.record[my_queue.front] + ") is crossing the Toll.";
                string title = "Have a save journey";
                MessageBox.Show(message, title);
                my_queue.record[my_queue.front] = my_queue.record[my_queue.front++];
            }

            //WITH DATABASE
            //my_queue.dequeue();
            //    string message = "Your Car is crossing the Toll.";
            //    string title = "Alert";
            //    MessageBox.Show(message, title);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
