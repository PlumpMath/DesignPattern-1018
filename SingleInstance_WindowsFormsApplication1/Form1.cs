using System;
using System.Windows.Forms;




namespace SingleInstance_WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        FormToolBox ftb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenToolBox();
        }

        private void OpenToolBox()
        {
            FormToolBox.GetInstance().Show();
        }
    }
}
