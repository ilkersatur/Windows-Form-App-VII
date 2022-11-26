using WndApp.DAL;
using WndApp.Model;

namespace WndApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KitapDB db = new KitapDB();

            comboBox1.DataSource = db.Yazarlar.Listele();
            comboBox1.DisplayMember = "YazarAdi";
            comboBox1.ValueMember = "YazarID";

            comboBox2.DataSource = db.Kategoriler.Listele();
            comboBox2.DisplayMember = "KategoriAdi";
            comboBox2.ValueMember = "KategoriID";

        }

        public string PersonID{
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmPerson frm = new FrmPerson(this,textBox1.Text,textBox2.Text);

            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox5.Text = openFileDialog1.FileName;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(monthCalendar1.SelectionStart.ToString());

            MessageBox.Show(dateTimePicker1.Value.ToString());

            KitapDB db = new KitapDB();

            Kitap kitap = new Kitap();
            kitap.KitapAdi = textBox4.Text;
            kitap.YazarID = Convert.ToInt32(comboBox1.SelectedValue);
            kitap.KategoriID = Convert.ToInt32(comboBox2.SelectedValue);
            kitap.Fiyat = numericUpDown1.Value;
            kitap.KapakResmi = textBox5.Text;
            kitap.EklendigiTarih = dateTimePicker1.Value;
            
            db.Kitaplar.Ekle(kitap);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            KitapDB db = new KitapDB();

            DialogResult dr = MessageBox.Show("Emin misiniz?", "", MessageBoxButtons.YesNo);
            if(dr== DialogResult.Yes)
            db.Kategoriler.Sil(Convert.ToInt32(comboBox2.SelectedValue));

            //ComboBox içerisindeki deðerleri tazele...

        }
    }
}