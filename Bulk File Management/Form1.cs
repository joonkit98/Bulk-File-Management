using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bulk_File_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> fileList = new List<string>(),
            storeFileList = new List<string>();
        string _file, _filePath, _fileExt;
        bool status = true;

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            contextOpenFile.Show(btn.PointToScreen(new Point(0, btn.Height)));
        }

        private void toolStripFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == (DialogResult.OK))
            {
                int i = 0;
                textBox1.Text = "";
                _filePath = Path.GetDirectoryName(openFileDialog1.FileName);
                try
                {
                    foreach (string file in openFileDialog1.FileNames)
                    {
                        _file = Path.GetFileName(file);
                        fileList.Add(_file);
                        textBox1.Text += fileList[i] + " ";
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btn_Process.Enabled = true;
            }
        }

        private void toolStripFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == (DialogResult.OK))
            {
                int i = 0;
                textBox1.Text = "";
                _filePath = folderBrowserDialog1.SelectedPath;
                try
                {
                    foreach (string file in Directory.GetFiles(folderBrowserDialog1.SelectedPath))
                    {
                        _file = Path.GetFileName(file);
                        fileList.Add(_file);
                        textBox1.Text += fileList[i] + " ";
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btn_Process.Enabled = true;
            }
        }

        private void btn_Process_Click(object sender, EventArgs e)
        {
            if (radioChange.Checked)
            {
                changeFileExtension();
            }
            else if (radioRemove.Checked)
            {
                removeChar();
            }
            else if (radioRemoveMatch.Checked)
            {
                removeMatching();
            }
            else if (radioRemoveDoubleSpace.Checked)
            {
                removeDoubleSpace();
            }
            else if (radioRemoveSpeChar.Checked)
            {
                removeSpecificCharacters();
            }
            else if (radioAppendFolder.Checked)
            {
                getFolder();
            }
        }

        private void changeFileExtension()
        {
            if (textBox2.Text != "")
            {
                try
                {
                    storeFileList.Clear();
                    textBox1.Text = "";
                    string _fileName;
                    for (int i = 0; i < fileList.Count; i++)
                    {
                        _fileName = fileList[i];
                        DialogResult result = MessageBox.Show("If you change a file name extension, the file might become unusable. Are you sure you want to change it?", "Rename File", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            _fileExt = "." + textBox2.Text;
                            renameFile(_fileName, Path.GetFileNameWithoutExtension(_fileName) + _fileExt);
                            fileList[i] = storeFileList[i];
                            textBox1.Text += storeFileList[i] + " ";
                        }
                    }
                    completed(status);
                }
                catch (Exception ex)
                {
                    status = false;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter file name extension");
            }
        }

        private void removeChar()
        {
            if (textBox2.Text != "")
            {
                try
                {
                    storeFileList.Clear();
                    textBox1.Text = "";
                    string _fileName;
                    int num = int.Parse(textBox2.Text);
                    for (int i = 0; i < fileList.Count; i++)
                    {
                        _fileName = fileList[i];
                        _fileName = _fileName.Remove(0, num);
                        renameFile(fileList[i], _fileName);
                        fileList[i] = storeFileList[i];
                        textBox1.Text += storeFileList[i] + " ";
                    }
                    completed(status);
                }
                catch (Exception ex)
                {
                    status = false;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a number");
            }
        }

        private void removeMatching()
        {
            if (textBox2.Text != "")
            {
                try
                {
                    storeFileList.Clear();
                    textBox1.Text = "";
                    string _fileName;
                    string[] splitFileName;
                    for (int i = 0; i < fileList.Count; i++)
                    {
                        _fileName = fileList[i];
                        splitFileName = _fileName.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        _fileName = "";
                        for (int x = 0; x < splitFileName.Length; x++)
                        {

                            if (splitFileName[x] == textBox2.Text)
                            {
                                splitFileName[x] = splitFileName[x].Replace(splitFileName[x], "");
                            }
                            _fileName += splitFileName[x] + " ";
                        }
                        renameFile(fileList[i], _fileName);
                        fileList[i] = storeFileList[i];
                        textBox1.Text += storeFileList[i] + " ";
                    }
                    completed(status);
                }
                catch (Exception ex)
                {
                    status = false;
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a string");
            }
        }

        private void removeDoubleSpace()
        {
            try
            {
                storeFileList.Clear();
                textBox1.Text = "";
                string _fileName;
                for (int i = 0; i < fileList.Count; i++)
                {
                    _fileName = fileList[i];
                    _fileName = System.Text.RegularExpressions.Regex.Replace(_fileName, @"\s+", " ");
                    renameFile(fileList[i], _fileName);
                    fileList[i] = storeFileList[i];
                    textBox1.Text += storeFileList[i] + " ";
                }
                completed(status);
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void removeSpecificCharacters()
        {
            try
            {
                storeFileList.Clear();
                textBox1.Text = "";
                string _fileName;
                for (int i = 0; i < fileList.Count; i++)
                {
                    _fileName = fileList[i];
                    foreach (char c in textBox2.Text)
                    {
                        _fileName = _fileName.Replace(c.ToString(), string.Empty);
                    }
                    renameFile(fileList[i], _fileName);
                    fileList[i] = storeFileList[i];
                    textBox1.Text += storeFileList[i] + " ";
                }
                completed(status);
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void getFolder()
        {
            try
            {
                storeFileList.Clear();
                textBox1.Text = "";
                string _fileName;
                for (int i = 0; i < fileList.Count; i++)
                {
                    _fileName = fileList[i];
                    string folderName = Path.GetFileName(Path.GetDirectoryName(_filePath + "\\" + _fileName));
                    renameFile(fileList[i], folderName + "-" + _fileName);
                    fileList[i] = storeFileList[i];
                    textBox1.Text += storeFileList[i] + " ";
                }
                completed(status);
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void renameFile(string oldFileName, string newFileName)
        {
            try
            {
                File.Move(_filePath + "\\" + oldFileName, _filePath + "\\" + newFileName);
                storeFileList.Add(newFileName);
            }
            catch (Exception ex)
            {
                status = false;
                MessageBox.Show(ex.Message);
            }
        }

        private void completed(bool _status)
        {
            if (_status)
                MessageBox.Show("Done");
        }

        private void radioChange_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (radioChange.Checked || radioRemove.Checked || radioRemoveMatch.Checked || radioRemoveSpeChar.Checked)
                {
                    textBox2.ReadOnly = false;
                }
                else if (radioRemoveDoubleSpace.Checked || radioAppendFolder.Checked)
                {
                    textBox2.ReadOnly = true;
                    textBox2.Text = "";
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioRemove.Checked)
            {
                if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar)) { e.Handled = true; }

            }
        }
    }
}
