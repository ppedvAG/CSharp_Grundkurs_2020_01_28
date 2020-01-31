using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ExtentionThema_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
            {
                dataGridView1.AutoGenerateColumns = true;
                dataGridView2.AutoGenerateColumns = true;
                //dataGridView1.DataSource = context.Product.ToList();

                // Lade alle Datensätze aus der Tabelle Products
                List<Product> resultList = context.Product.ToList();
                //Bindetdie ERgebnisliste an die Oberfläche an
                bindingSource1.DataSource = resultList;
                dataGridView1.DataSource = bindingSource1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Wenn das DataGrid Selektiert wurde, zeige mir die Relationsdaten zu BillOfMaterials an
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Ist überhaupt ein Datensatz aus dataGrid1 (Products) selektiert
            if (this.bindingSource1.Current != null)
            {
                // Lese mir den selektierten Datensatz aus dem DateGrid1, bzw der daruner liegenden Liste heraus. 
                Product selektiertesProduct = (Product)bindingSource1.Current;

                // Lese die relationale Datensätze aus der DB aus
                using (AdventureWorks2017Entities context = new AdventureWorks2017Entities())
                {
                    // // Lese die relationale Datensätze aus der DB aus mithilfe des Keys ProductID
                    List<BillOfMaterials> billOfMaterialsList = context.BillOfMaterials.Where(n => n.Product.ProductID == selektiertesProduct.ProductID).ToList();
                    
                    // Gibt es relationale Daten
                    if (billOfMaterialsList.Count > 0)
                    {
                        //Binde die relationalen Daten an Grid2 
                        bindingSource2.DataSource = billOfMaterialsList;
                        dataGridView2.DataSource = bindingSource2;
                    }
                    else
                    {
                        //Wenn keine gefunden
                        dataGridView2.DataSource = null;
                    }
                }

            }
        }
    }
}
