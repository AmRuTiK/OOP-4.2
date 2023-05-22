using System.Windows.Forms;

namespace OOP_4._2
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            model = new Model();
            model.observers += new System.EventHandler(this.UpdateModel);
            model.set_c(Properties.Settings.Default.c);
            model.set_b(Properties.Settings.Default.b);
            model.set_a(Properties.Settings.Default.a);
        }
        public void UpdateModel(object sender, EventArgs e)
        {
            textBoxa.Text = model.get_a().ToString();
            textBoxb.Text = model.get_b().ToString();
            textBoxc.Text = model.get_c().ToString();
            numericUpDowna.Value = model.get_a();
            numericUpDownb.Value = model.get_b();
            numericUpDownc.Value = model.get_c();
            trackBara.Value = model.get_a();
            trackBarb.Value = model.get_b();
            trackBarc.Value = model.get_c();
        }
        private void textBoxa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.set_a(Int32.Parse(textBoxa.Text));
        }
        private void textBoxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.set_b(Int32.Parse(textBoxb.Text));
        }
        private void textBoxc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                model.set_c(Int32.Parse(textBoxc.Text));
        }
        private void numericUpDowna_ValueChanged(object sender, EventArgs e)
        {
            model.set_a(Decimal.ToInt32(numericUpDowna.Value));
        }
        private void numericUpDownb_ValueChanged(object sender, EventArgs e)
        {
            model.set_b(Decimal.ToInt32(numericUpDownb.Value));
        }
        private void numericUpDownc_ValueChanged(object sender, EventArgs e)
        {
            model.set_c(Decimal.ToInt32(numericUpDownc.Value));
        }
        private void trackBara_Scroll(object sender, EventArgs e)
        {
            model.set_a(trackBara.Value);
        }
        private void trackBarb_Scroll(object sender, EventArgs e)
        {
            model.set_b(trackBarb.Value);
        }
        private void trackBarc_Scroll(object sender, EventArgs e)
        {
            model.set_c(trackBarc.Value);
        }
        public class Model
        {
            private int a, b, c;
            public System.EventHandler observers;
            public void set_a(int a)
            {
                if (a < 0) { this.a = 0; observers.Invoke(this, null); return; }
                else if (a > c) { this.a = b; observers.Invoke(this, null); return; }
                if (a <= c && a > b)
                    b = a;
                this.a = a;
                observers.Invoke(this, null);
            }
            public void set_b(int b)
            {
                if (b >= a && b <= c)
                    this.b = b;
                else this.b = (b < a) ? a : c;
                observers.Invoke(this, null);
            }
            public void set_c(int c)
            {
                if (c > 100) { this.c = 100; observers.Invoke(this, null); return; }
                else if (c < a) { this.c = b; observers.Invoke(this, null); return; }
                if (c >= a && c < b)
                    b = c;
                this.c = c;
                observers.Invoke(this, null);
            }
            public int get_a() { return a; }
            public int get_b() { return b; }
            public int get_c() { return c; }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.a = model.get_a();
            //Properties.Settings.Default.b = model.get_b();
            Properties.Settings.Default.c = model.get_c();
            Properties.Settings.Default.Save();
        }
    }
}