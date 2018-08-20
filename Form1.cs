using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace file_sync
{
    public partial class Form1 : Form
    {
        private OpenFileDialog way;
        private BackSystem bs;
        private Vault v;

        private List<string[]> data = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }       

        private void Form1_Load(object sender, EventArgs e)
        {
            backFillTable();
        }

        //Заполнить, обновить таблицу
        private void backFillTable()
        {
            bs = new BackSystem();
            bs.DBToList(data);
            bs.updateDB(data);
            bs.DBToList(data);
            bs.fillTable(dgvFiles, data);
            bs.compareFile(data, dgvFiles.Rows);
        }

        private void btnPathSource_Click(object sender, EventArgs e)
        {
            way = new OpenFileDialog();
            way.ShowDialog();
            tbPathSource.Text = way.FileName;
        }

        private void btnPathVault_Click(object sender, EventArgs e)
        {
            way = new OpenFileDialog();
            way.ShowDialog();
            tbPathVault.Text = way.FileName;
        }

        private void btnAddFile_Click(object sender, EventArgs e)
        {
            v = new Vault(tbPathSource.Text, tbPathVault.Text);
            v.addDataInDB();

            backFillTable();
        }

        private void btnRemoveFile_Click(object sender, EventArgs e)
        {
            string id = dgvFiles.CurrentCell.Value.ToString();
            v = new Vault();
            v.removeDataInDB(id);

            backFillTable();
        }

        private void btnSync_Click(object sender, EventArgs e)
        {
            string id = dgvFiles.CurrentCell.Value.ToString();
            bs = new BackSystem();
            bs.syncFile(id, data);

            backFillTable();
        }
    }
}
