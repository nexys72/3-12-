using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            const string message = "Вы действительно хотите выйти?";
            const string caption = "Выход";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                MessageBox.Show("Палиндро́м (от др.-греч. πάλιν — «назад, снова» и др.-греч. δρóμος — «бег, движение»), пе́ревертень[1] — число, буквосочетание, слово или текст, одинаково читающееся в обоих направлениях. Например, число 101; слова «топот» в русском языке и фин. saippuakivikauppias (продавец мыла; торговец щёлоком) — самое длинное слово-палиндром в мире; текст «а роза упала на лапу Азора» и пр.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string text = textBox1.Text;
                char[] obrtext = text.ToCharArray();
                Array.Reverse(obrtext);
                string finaltext = new string(obrtext);
                if (text == finaltext)
                {
                    MessageBox.Show("Данная запись является палиндромом.");
                }
                if (text != finaltext)
                {
                    MessageBox.Show("Данная запись не является палиндромом.");
                }



            }
        }
    }
}
