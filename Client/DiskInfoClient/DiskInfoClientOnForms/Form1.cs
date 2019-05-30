using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DiskInfoClientOnForms.DiskInfoServiceReference;

namespace DiskInfoClientOnForms
{
    public partial class Form1 : Form
    {
        DiskInfoContractClient proxy = new DiskInfoContractClient();
        BindingSource source;
        public Form1()
        {
            InitializeComponent();
            dataGridViewDiskInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDiskInfo.AutoGenerateColumns = true;
            List<DataInfo> dataInfos = new List<DataInfo>();
            source = new BindingSource();
            source.DataSource = dataInfos;
            dataGridViewDiskInfo.DataSource = source;
        }
        private void buttonShowDiskInfo_Click(object sender, EventArgs e)
        {
            if(source.Count!=0)
                source.Clear();
            if (textBoxPath.Text!="")
            {
                string[] pathContent = proxy.GetDiskInfo(textBoxPath.Text);
                if (pathContent != null)
                {
                    foreach (var item in pathContent)
                    {
                        string ext = Path.GetExtension(item);
                        if (ext.Length > 1 && ext.Length < 7)
                            source.Add(new DataInfo {  Name = item, Type = "file" });
                        else
                            source.Add(new DataInfo { Name = item, Type = "folder" });
                    }
                }
                else
                {
                    MessageBox.Show("Server returned null. Perhaps your path is wrong.");
                }
            }
            else
            {
                MessageBox.Show("The path is invalid because it does not contain characters.");
            }
        }
    }
}
