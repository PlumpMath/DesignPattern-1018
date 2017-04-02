using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleInstance_WindowsFormsApplication1
{
    public partial class FormToolBox : Form
    {
        private static FormToolBox instance=null;

        private FormToolBox()
        {
            InitializeComponent();
        }

        public static FormToolBox GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance=new FormToolBox();
                instance.MdiParent = Form1.ActiveForm;
            }
            return instance;
        }

        private void FormToolBox_Load(object sender, EventArgs e)
        {

        }
    }
}
