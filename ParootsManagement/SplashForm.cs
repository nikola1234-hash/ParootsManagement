using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParootsManagement
{
    public partial class SplashForm : Form
    {


        public SplashForm()
        {
            InitializeComponent();
            this.Shown += SplashForm_Shown;
        }

        private void SplashForm_Shown(object sender, EventArgs e)
        {
            Task.Delay(3000).Wait();
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            pictureBox.Image = Image.FromFile(Environment.CurrentDirectory + @"\Resources\parrot.jpg");
            pictureBox.Refresh();
        }


    }
}
