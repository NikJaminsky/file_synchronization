using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace file_sync
{
    class BackSystem
    {
        private string dbFileName = @"Vault.db";
        SQLiteCommand command;
        SQLiteConnection conn;

        //Обновить записи в базе данных
        public void updateDB(List<string[]> data)
        {     
            conn = new SQLiteConnection(string.Format("Data Source={0};", dbFileName));

            conn.Open();
            foreach (string[] s in data)
            {
                FileInfo infoSource = new FileInfo(s[1]);
                string dateChangeSource = infoSource.LastWriteTime.ToString();
                double sizeSource = infoSource.Length;
                FileInfo infoVault = new FileInfo(s[2]);
                string dateChangeVault = infoVault.LastWriteTime.ToString();
                double sizeVault = infoVault.Length;

                command = new SQLiteCommand("UPDATE 'files' SET (date_change_source, date_change_vault, size_source, size_vault) = ('" + dateChangeSource + "', '" + dateChangeVault + "', '" + sizeSource + "' , '" + sizeVault + "') WHERE file_id = '" + s[0] + "';", conn);
                command.ExecuteNonQuery();
            }
            conn.Close();
        }

        //Перенести записи базы данных в список
        public void DBToList(List<string[]> data)
        {
            conn = new SQLiteConnection(string.Format("Data Source={0};", dbFileName));

            conn.Open();
            command = new SQLiteCommand("SELECT * FROM 'files';", conn);
            SQLiteDataReader reader = command.ExecuteReader();
            data.Clear();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
                data[data.Count - 1][6] = reader[6].ToString();
            }
            reader.Close();
            conn.Close();
        }

        //Заполнить таблицу на форме из списка
        public void fillTable(DataGridView dgv, List<string[]> data)
        {
            dgv.Rows.Clear();
            dgv.Refresh();
            foreach (string[] s in data)
                dgv.Rows.Add(s);
        }

        //Синхронизировать файлы
        public void syncFile(string id, List<string[]> data)
        {
            foreach (string[] s in data)
                if (id.ToString() == s[0])
                {
                    FileInfo fileInfS = new FileInfo(s[1]);
                    fileInfS.CopyTo(s[2], true);
                }
        }

        //Сравнить файлы
        public void compareFile(List<string[]> data, DataGridViewRowCollection row)
        {
            int i = 0;
            foreach (string[] s in data)
            {
                if ((compareSizeFile(s) == false) | (compareDateChangeFile(s) == false))
                    row[i].DefaultCellStyle.BackColor = Color.Red;                          //файлы не равны                                      
                else
                    row[i].DefaultCellStyle.BackColor = Color.Green;                        //файлы равны 
                i++;
            }
        }

        //Сравнить размер файлов
        private bool compareSizeFile(string[] str)
        {
            if (str[5] == str[6])
                return true;
            else
                return false;
        }

        //Сравнить дату изменения файлов
        private bool compareDateChangeFile(string[] str)
        {
            if (str[3] == str[4])
                return true;
            else
                return false;
        }
    }
}
