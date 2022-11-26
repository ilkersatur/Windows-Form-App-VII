using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WndApp.Temp
{
    internal class AdvWorksDB
    {
        public List<Person> PersonLists(string fName, string lName)
        {
            SqlConnection conn = new SqlConnection("Data source=.;initial catalog=AdventureWorks2014;integrated security=true");

            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT BusinessEntityID,FirstName,LastName,Title,MiddleName FROM Person.Person WHERE FirstName=@name AND LastName =@surname",conn);

            cmd.Parameters.AddWithValue("@name", fName);
            cmd.Parameters.AddWithValue("@surname", lName);
            SqlDataReader dr = cmd.ExecuteReader();

            List<Person> list = new List<Person>();
            while(dr.Read())
            {

                Person person = new Person();

                person.BusinessEntityID = dr.GetInt32(0);
                person.FirstName = dr["FirstName"].ToString();
                person.LastName = dr["LastName"].ToString();
                person.Title=dr["Title"].ToString(); person.MiddleName = dr["MiddleName"].ToString();
                
                list.Add(person);

            }
            conn.Close();
            return list;
        }
    }
}
