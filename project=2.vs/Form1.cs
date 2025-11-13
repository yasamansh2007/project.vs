using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private string currentFile = "";

        public Form1()
        {
            InitializeComponent();
            mnuNew.ShortcutKeys = Keys.Control | Keys.N;
            mnuOpen.ShortcutKeys = Keys.Control | Keys.O;
            mnuSave.ShortcutKeys = Keys.Control | Keys.S;
            autosaveTimer.Interval = 30000;
            autosaveTimer.Start();
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
            currentFile = "";
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentFile = ofd.FileName;
                    string[] lines = System.IO.File.ReadAllLines(currentFile);
                    txtUser.Text = lines.Length > 0 ? lines[0] : "";
                    txtPass.Text = lines.Length > 1 ? lines[1] : "";
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            SaveToFile();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbSave_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSave.SelectedItem != null && cmbSave.SelectedItem.ToString() == "Save")
            {
                SaveToFile();
                cmbSave.SelectedIndex = -1;
            }
        }

        private void autosaveTimer_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFile))
            {
                System.IO.File.WriteAllLines(currentFile, new string[]
                {
                    txtUser.Text,
                    txtPass.Text
                });
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.SetData(txtUser.Text, txtPass.Text);
            f2.Show();
        }

        private void SaveToFile()
        {
            if (string.IsNullOrEmpty(currentFile))
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        currentFile = sfd.FileName;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            System.IO.File.WriteAllLines(currentFile, new string[]
            {
                txtUser.Text,
                txtPass.Text
            });
        }
    }
}
