using System.Data.SqlClient;

namespace sql1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connection = "server=TEJASGOWDA05\\SQLEXPRESS;initial catalog=day1;integrated security=sspi";



            string createtable = "create table person(id int primary key,name varchar(30),age int,salary int)";

            string inserttable = "insert into person values(3,'yuva',98,880)";

            string updatetable = "update person set age=28 where name='yuva'";

            string deletetable = "delete from person where name='manoj'";

            using (SqlConnection c = new SqlConnection(connection))
            {
                c.Open();
                using (SqlCommand cmd = new SqlCommand(deletetable, c))
                {
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine(dr["name"]);
                    //}
                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("added successfully");

        }
    }
}
 