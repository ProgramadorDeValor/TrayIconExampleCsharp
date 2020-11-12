using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrayIconAppExample.Properties;

namespace TrayIconAppExample
{
    public partial class ExamepleForm : Form
    {
        public ExamepleForm()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(Resources.CUPCAKE_BLACK.GetHicon());
            this.Text = Resources.FORM_TITLE;
            txtBox.Text = Resources.TEXTBOX;
            txtBox.Enabled = false;
            txtBox.TextAlign = HorizontalAlignment.Center;
            btnRepository.Image = Resources.GITHUB;
            btnRepository.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnRepository_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Resources.REPOSITORY_URL);
        }
    }
}
