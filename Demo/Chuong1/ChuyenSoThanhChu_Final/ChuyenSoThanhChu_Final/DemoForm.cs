using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ChuyenSoThanhChu_Final
{
    public partial class DemoForm : Form
    {
        private MakeToString _mk;
        public DemoForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnreadfull_Click(object sender, EventArgs e)
        {
            var temp = txtinput.Text;
            var check = false;
            for (var i = 0; i < temp.Length; i++)
            {
                check=Char.IsLetter(temp, i);
                break;
            }
            if (!check & temp.Length <= 15)
            {
                _mk = new MakeToString(Convert.ToDouble(temp));
                _mk.BlockProcessing();

                lblblock1.Text = Convert.ToString(_mk.BlockNum[0]);
                lblblock2.Text = Convert.ToString(_mk.BlockNum[1]);
                lblblock3.Text = Convert.ToString(_mk.BlockNum[2]);
                lblblock4.Text = Convert.ToString(_mk.BlockNum[3]);
                lblblock5.Text = Convert.ToString(_mk.BlockNum[4]);
                txtrichtext.Text = _mk.ReadThis() + " ";
            }
            else
            {
                txtrichtext.Text = "Dãy vừa nhập không phải là số hoặc bạn đã nhập quá 15 chữ số !";
                
            }
        }

        private void chươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form a = new AboutBox();
            //a.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void lbldatetime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbldatetime.Text = Convert.ToString(DateTime.Now);
        }

        private void bntlinked_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/profile.php?id=100010778263012"); 
        }

        private void txtrichtext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
