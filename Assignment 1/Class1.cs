using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment_1
{
    public class Queue
    {
        //WITH ARRAY
        public string[] record = new string[5];
        public int i = 0;
        public int front = 0;
        public int rear = 0;
        public int max = 5;

        //WITH DATA BASE
        //SqlConnection conn = new SqlConnection("Data Source=DESKTOP-91IR7TI\\TEW_SQLEXPRESS;Initial Catalog=Toll_Plaza_System;Integrated Security=True");


        public int /*void*/ insertQ(string noplate)
        {
            //WITH ARRAY
            if (rear == max - 1)
            {
                return rear;
            }
            else
            {
                record[rear] = noplate;
                ++rear;
                return rear;
            }

            //WITH DATA BASE
            //string insrt = "insert into record(noplate,timein) values('" + noplate + "','"+DateTime.Now+"')";
            //conn.Open();
            //SqlCommand com = new SqlCommand(insrt, conn);
            //com.ExecuteNonQuery();
            //conn.Close();

        }

        public int /*void*/ dequeue()
        {
            //WITH ARRAY
            if (front == rear)
            {
                return front;
            }
            else
            {
                return front;
            }

            //WITH DATA BASE
            //string insrt = "update record set timeout='" + DateTime.Now + "' where did=(select top 1 did from record where timeout is null order by timein)";
            //conn.Open();
            //SqlCommand com = new SqlCommand(insrt, conn);
            //com.ExecuteNonQuery();
            //conn.Close();

        }

        public string /*void*/ printQueue()
        {
            string text;

            if (front == rear)
            {
                text = "Queue is Empty";
                return text;
            }
            else
            {
                text = record[front];
                return text;
            }
        }
    }
}
