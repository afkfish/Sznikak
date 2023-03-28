using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace HelloWorldWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bUpdateText_Click(object sender, EventArgs e)
        {
            tbDemoText.Text = "Hello";
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbDemoText_TextChanged(object sender, EventArgs e)
        {

        }

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string? pszSubIdList);


        private void MainForm_Load(object sender, EventArgs e)
        {
            var root = treeView1.Nodes.Add("Local Disk (C:)");
            root.Tag = new DirectoryInfo(@"C:\");
            root.Nodes.Add("");

            SetWindowTheme(treeView1.Handle, "explorer", null);
            SetWindowTheme(listView1.Handle, "explorer", null);

            // Eltünteti a csomópontokat összekötő vonalakat
            treeView1.ShowLines = false;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var parentDI = e.Node?.Tag as DirectoryInfo;
            if (parentDI == null)
                return;

            e.Node?.Nodes.Clear();
            try
            {
                foreach (var di in parentDI.GetDirectories())
                {
                    var node = new TreeNode(di.Name);
                    node.Tag = di;
                    node.Nodes.Add("");
                    e.Node?.Nodes.Add(node);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // lenyeljük a hibát, így úgy fog tűnni, mintha üres lenne a mappa
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var parentDI = e.Node?.Tag as DirectoryInfo;
            if (parentDI == null)
                return;

            listView1.Items.Clear();
            try
            {
                foreach (FileInfo fi in parentDI.GetFiles())
                {
                    listView1.Items.Add(
                        new ListViewItem(
                            new string[]
                            {
                                fi.Name,
                                fi.Length.ToString(),
                                fi.LastWriteTime.ToString(),
                                fi.FullName
                            }
                        )
                    );
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // lenyeljük a hibát, így úgy fog tűnni, mintha üres lenne a mappa
            }
            tbDemoText.Text = parentDI.FullName;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 1)
                return;

            var fullName = listView1.SelectedItems[0].SubItems[3].Text;
            if (fullName != null)
            {
                Process.Start(new ProcessStartInfo(fullName) { UseShellExecute = true });
            }
        }
    }
}