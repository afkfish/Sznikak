using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WinFormExpl;
using System.Xml.Linq;

namespace WinFormExpl
{
    public partial class InputDialog : Form
    {
        // egy property, amit a formon beállítunk
        public string Path
        { get; set; }
        public InputDialog()
        {
            InitializeComponent();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            // ha a felhasználó OK-t nyom, akkor a Path property értéke a textbox tartalma
            Path = textBox1.Text;
        }
    }
}