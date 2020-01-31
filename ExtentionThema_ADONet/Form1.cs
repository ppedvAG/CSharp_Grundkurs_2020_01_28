using System;
using System.Collections.Generic;
using System.ComponentModel;

//DataTable / DataSet
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ExtentionThema_ADONet
{
    public partial class Form1 : Form
    {   //ADO.NET 


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=SURFACE-KW1;Initial Catalog=AdventureWorks2017;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            DataTable resultTable = new DataTable("Products");

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            try
            {
                sqlConnection.Open();
                string sqlStatement = "Select TOP (1000) * FROM [AdventureWorks2017].[Production].[Product]";
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(resultTable);
                dataGridView1.DataSource = resultTable;

                resultTable.WriteXml("Product1.xml");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }

            
            // Seit .NET 3.0 / 3.5
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Logik implementieren wie oben
                //connection.close wird nicht benötigt


                //!! Wichtige Info für using - Für eiegene Klassen. Muss das Interface IDispose implement.
            }

            #region XMLSerializer
            XmlSerializer ser = new XmlSerializer(typeof(DataTable));
            TextWriter writer = new StreamWriter("Product2.xml");
            ser.Serialize(writer, resultTable);
            writer.Close();
            #endregion

        }
    }
}
