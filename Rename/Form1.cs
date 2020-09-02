using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        string src_name;
        string des_name;
        string pathDir;
        string pathResize;
        string pathSave;
        UInt32 number;
        const UInt16 NUM_DIGIT = 6;
        UInt16 len = NUM_DIGIT;
        #endregion
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pathDir = BrowseFolder(textBoxDir, labelComplete);
        }

        private void textBoxDir_TextChanged(object sender, EventArgs e)
        {
            pathDir = textBoxDir.Text;
            if (pathDir.EndsWith("\\"))
            {
                pathDir = pathDir.Remove(pathDir.Length - 1, 1);
            }
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            //des_name = textBoxName.Text;
            //len = Convert.ToUInt16(textBoxLength.Text);
            //if (len <= des_name.Length)
            //{
            //    len = (UInt16)(des_name.Length + 1);
            //    textBoxLength.Text = len.ToString();
            //}
            //else
            //{
            //    len = (UInt16)des_name.Length;
            //    textBoxLength.Text = len.ToString();
            //}
            pBar1.Value = 0;
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            des_name = textBoxName.Text;
            if (des_name == "")
            {
                MessageBox.Show("New name of file can't empty!!!");
                return;
            }
            if (!IsNumeric(des_name))
            {
                MessageBox.Show("Rename file error. Require only number in name!!!");
                return;
            }
            number = Convert.ToUInt32(des_name);
            try
            {

                DirectoryInfo dir = new DirectoryInfo(pathDir);
                FileInfo[] Files = dir.GetFiles("*");
                if (Files.Length != 0)
                {
                    pBar1.Maximum = Files.Length;
                    foreach (FileInfo file in Files)
                    {
                        src_name = file.FullName;
                        des_name = Getnewname(number);
                        number += 1;
                        string newpath = pathDir + "\\" + des_name + file.Extension;
                        if (!File.Exists(newpath)) file.MoveTo(newpath);
                        pBar1.Value += 1;
                    }
                    ResetValue();
                    MessageBox.Show(Convert.ToString(Files.Length) + " files have been renamed ", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("ERROR");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab==tabRename) pathDir = BrowseFolder(textBoxDir, labelComplete);
            if (tabControl1.SelectedTab==tabResize) pathResize = BrowseFolder(textBoxLoad, labelInfo);
        }
        public string Getnewname(UInt32 num)
        {
            string format = "D" + len.ToString();
            return num.ToString(format);
        }
        public void ResetValue()
        {
            des_name = textBoxName.Text;
            number = Convert.ToUInt32(des_name);
        }
        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {
            string temp = textBoxLength.Text;
            len = Convert.ToUInt16(temp);
        }
        public void BrowseFolder()
        {
            string path = textBoxDir.Text;

            if (path == "")
            {
                FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog()
                {
                    Description = "Select destination folder"
                };
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxDir.Text = FolderBrowserDialog.SelectedPath;
                    path = textBoxDir.Text;
                }
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    var mes = MessageBox.Show("Directory not availble!\r\nYes - choose directory with browse folder.\r\nNo - repair directory!!!",
                                     "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mes == DialogResult.Yes)
                    {
                        FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog()
                        {
                            Description = "Select destination folder"
                        };
                        if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            textBoxDir.Text = FolderBrowserDialog.SelectedPath;
                            path = textBoxDir.Text;
                            ShowLabel(labelComplete, "STATUS", Color.Transparent);
                        }
                        else ShowLabel(labelComplete, "STATUS", Color.Transparent);
                    }
                    else ShowLabel(labelComplete, "Please check the directory!", Color.Yellow);
                }
                else ShowLabel(labelComplete, "STATUS", Color.Transparent);
            }

        }

        public void ShowLabel(Label label, string message, Color backcolor)
        {
            label.Text = message;
            label.BackColor = backcolor;
        }
        public void ShowTrue(Label label)
        {
            label.Text = "STATUS";
            label.BackColor = Color.Transparent;
        }
        public void ShowFailse(Label label)
        {
            label.Text = "Please check the directory!";
            label.BackColor = Color.Yellow;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRename;
        }

        public static bool IsNumeric(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c) && c != '.')
                {
                    return false;
                }
            }
            return true;
        }

        private void useToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHelp f2 = new FormHelp();
            f2.ShowDialog(); // Shows Form2
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.ShowDialog();
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabRename;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabResize;
        }
        Image MyResize(Image image, int with, int hight)
        {
            Bitmap bmp = new Bitmap(with, hight);
            Graphics graphic = Graphics.FromImage(bmp);
            graphic.DrawImage(image, 0, 0, with, hight);
            graphic.Dispose();
            return bmp;
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            pathResize = BrowseFolder(textBoxLoad, labelInfo);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            pathSave = BrowseFolder(textBoxSave, labelInfo);
        }
        public string BrowseFolder(TextBox txtBox, Label label)
        {
            string path = txtBox.Text;

            if (path == "")
            {
                FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog()
                {
                    Description = "Select destination folder"
                };
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBox.Text = FolderBrowserDialog.SelectedPath;
                    path = txtBox.Text;
                    return path;
                }
                else return "";
            }
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                {
                    var mes = MessageBox.Show("Directory not availble!\r\nYes - choose directory with browse folder.\r\nNo - repair directory!!!",
                                     "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mes == DialogResult.Yes)
                    {
                        FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog()
                        {
                            Description = "Select destination folder"
                        };
                        if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            txtBox.Text = FolderBrowserDialog.SelectedPath;
                            path = txtBox.Text;
                            ShowTrue(label);
                            return path;
                        }
                        else { ShowTrue(label); return "";} 
                    }
                    else { ShowFailse(label); return "";}                      
                }
                else { ShowTrue(label); return path;}
            }
        }

        private void buttonResize_Click(object sender, EventArgs e)
        {
            UInt32 count = 0;
            int w, h;
            string newpath;
            w = Convert.ToInt16(textBoxWith.Text);
            h = Convert.ToUInt16(textBoxHight.Text);
            pBarResize.Value = 0;
            Image img_in, img_out;
            if (textBoxSave.Text == ""|| !System.IO.Directory.Exists(textBoxSave.Text))
            {
                newpath = pathResize + "\\" + "resized" + "\\";
            }
            else newpath = textBoxSave.Text+"\\";

            if (!System.IO.Directory.Exists(newpath))
                System.IO.Directory.CreateDirectory(newpath);
            try
            {

                DirectoryInfo dir = new DirectoryInfo(pathResize);
                FileInfo[] files = dir.GetFiles("*");
                if (files.Length != 0)
                {
                    pBarResize.Maximum = files.Length;
                    foreach(FileInfo file in files)
                    {
                        img_in = Image.FromFile(file.FullName);
                        if (img_in.Size.Height<h || img_in.Size.Width<w)
                        {
                            img_out = MyResize(img_in, w, h);
                            if (!File.Exists(newpath + file.Name))
                            {
                                img_out.Save(newpath + file.Name);
                                count++;
                            }
                            else
                            {
                                img_out.Save(newpath + "resized_" + file.Name);
                                count++;
                            }
                        }
                        pBarResize.Value += 1;
                    }
                    //ResetValue();
                    MessageBox.Show(Convert.ToString(count) + " files resized !!!", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Folder not contain any files!","ERROR");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLoad_TextChanged(object sender, EventArgs e)
        {
            pathResize = textBoxLoad.Text;
            if (pathResize.EndsWith("\\"))
            {
                pathResize = pathResize.Remove(pathResize.Length - 1, 1);
            }
        }

        private void textBoxSave_TextChanged(object sender, EventArgs e)
        {
            pathSave = textBoxSave.Text;
            if (pathSave.EndsWith("\\"))
            {
                pathSave = pathSave.Remove(pathSave.Length - 1, 1);
            }
        }
    }
}
