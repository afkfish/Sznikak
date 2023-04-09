namespace WinFormExpl
{
    public partial class MainForm : Form
    {
        // az utoljara betoltott file
        private FileInfo? loadedFile = null;
        // a counterunk az utolso betoltes ota
        int counter;
        // a counterunk kezdeti erteke
        readonly int counterInitialValue = 60;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            // az input dialog megnyilik
            var dlg = new InputDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // ha OK-val zarult akkor a listView-et frissitjuk
                string result = dlg.Path;
                if (result != null)
                {
                    // a file vagy directory szulo mappajanak informacioi
                    var parentDir = new DirectoryInfo(result);
                    // ha esetleg van felmappa akkor elmentjuk
                    var grandParent = parentDir.Parent;
                    listView1.Items.Clear();
                    try
                    {
                        // ha letezik a felmappa akkor rakunk a listView-be felmozgato linket
                        if (grandParent != null)
                        {
                            listView1.Items.Add(
                                new ListViewItem(
                                    new String[]
                                    {
                                        "..",
                                        "",
                                        grandParent.FullName,
                                    }
                                    )
                                );
                        }
                        // eloszor listazzuk a foldereket
                        foreach (var dir in parentDir.GetDirectories())
                        {
                            listView1.Items.Add(
                                new ListViewItem(
                                    new string[]
                                    {
                                dir.Name,
                                dir.CreationTime.ToString(),
                                dir.FullName
                                    }
                                )
                             );
                        }
                        // aztan a fileokat
                        foreach (FileInfo fi in parentDir.GetFiles())
                        {
                            listView1.Items.Add(
                                new ListViewItem(
                                    new string[]
                                    {
                                fi.Name,
                                fi.Length.ToString(),
                                fi.FullName
                                    }
                                )
                            );
                        }
                    }
                    catch (UnauthorizedAccessException)
                    {
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ha ki van valasztva egy file akkor kiirjuk a reszleteket
            if (listView1.SelectedItems.Count == 1)
            {
                var fullName = listView1.SelectedItems[0].SubItems[2].Text;
                var file = new FileInfo(fullName);
                lName.Text = file.Name;
                lCreated.Text = file.CreationTime.ToString();
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            // elmentjuk a kivalasztott filet es hogy directory-e vagy sem
            var selectedDir = new DirectoryInfo(listView1.SelectedItems[0].SubItems[2].Text);
            var attr = File.GetAttributes(listView1.SelectedItems[0].SubItems[2].Text);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                // a listView-et frissitjuk mert feljebb leptunk egy mappat
                listView1.Items.Clear();
                try
                {
                    // ha van felmappaja akkor rakunk egy felmozgato linket
                    if (selectedDir.Parent != null)
                    {
                        listView1.Items.Add(
                            new ListViewItem(
                                new String[]
                                {
                                        "..",
                                        "",
                                        selectedDir.Parent.FullName
                                }
                            )
                        );
                    }
                    // listazzuk a mappakat
                    foreach (var dir in selectedDir.GetDirectories())
                    {
                        listView1.Items.Add(
                            new ListViewItem(
                                new string[]
                                {
                                dir.Name,
                                dir.CreationTime.ToString(),
                                dir.FullName
                                }
                            )
                         );
                    }
                    // es a fileokat
                    foreach (FileInfo fi in selectedDir.GetFiles())
                    {
                        listView1.Items.Add(
                            new ListViewItem(
                                new string[]
                                {
                                fi.Name,
                                fi.Length.ToString(),
                                fi.FullName
                                }
                            )
                        );
                    }
                }
                catch (UnauthorizedAccessException)
                {
                }
            }
            else
            {
                // ha csak egy file volt amire duplan nyomtunk akkor kiirjuk a textBoxba a tartalmat
                var fullName = listView1.SelectedItems[0].SubItems[2].Text;
                tContent.Text = File.ReadAllText(fullName);
                counter = counterInitialValue;
                loadedFile = new FileInfo(fullName);
                reloadTimer.Start();
            }
        }

        private void reloadTimer_Tick(object sender, EventArgs e)
        {
            // csokkentjuk a szamlalonkat es ujrarajzoljuk a negyzeteket
            counter--;
            detailsPanel.Invalidate();

            // ha a timer lejar ujra olvassuk a file-t
            if (counter <= 0)
            {
                counter = counterInitialValue;
                tContent.Text = File.ReadAllText(loadedFile.FullName);
            }
        }

        private void detailsPanel_Paint(object sender, PaintEventArgs e)
        {
            // ha volt elotte betoltott file akkor rajzolunk negyzeteket
            if (loadedFile != null)
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Brown), new Rectangle(0, 0, (int)(125 * ((float)counter / (float)counterInitialValue)), 5));
            }
        }
    }
}