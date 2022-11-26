using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WndApp.Temp;

namespace WndApp
{
    public partial class FrmPerson : Form
    {
        string firstName, lastName;
        Form1 _frm;
        public FrmPerson(Form1 frm,string name, string surname)
        {
            _frm= frm;
            InitializeComponent();
            firstName = name;
            lastName = surname;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            _frm.PersonID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Close();
        }

        private void FrmPerson_Load(object sender, EventArgs e)
        {
            AdvWorksDB db = new AdvWorksDB();
            dataGridView1.DataSource= db.PersonLists(firstName, lastName);
        }
    }
}
