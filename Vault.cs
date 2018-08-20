using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace file_sync
{
    class Vault
    {
        private string dbName = @"Vault.db";            //База данных
        SQLiteConnection conn;                          
        SQLiteCommand command;    

        private string pathSource;                      //Путь к исходному файлу
        private string pathVault;                       //Путь к хранимому файлу

        public Vault() { }

        public Vault(string pathSource, string pathVault)
        {
            this.pathSource = pathSource;
            this.pathVault = pathVault;
        }

        //Добавить запись в базу данных 
        public void addDataInDB()
        {
            conn = new SQLiteConnection(string.Format("Data Source={0};", dbName));

            FileInfo infoSource = new FileInfo(pathSource);
            string dateChangeSource = infoSource.LastWriteTime.ToString();
            double sizeSource = infoSource.Length;
            FileInfo infoVault = new FileInfo(pathVault);
            string dateChangeVault = infoVault.LastWriteTime.ToString();
            double sizeVault = infoVault.Length;

            conn.Open();
            command = new SQLiteCommand("INSERT INTO 'files' (path_source, path_vault, date_change_source, date_change_vault, size_source, size_vault) VALUES ('" + pathSource + "', '" + pathVault + "', '" + dateChangeSource + "', '" + dateChangeVault + "', '" + sizeSource + "' , '" + sizeVault + "');", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Удалить запись из базы данных
        public void removeDataInDB(string idInTable)
        {
            conn = new SQLiteConnection(string.Format("Data Source={0};", dbName));

            conn.Open();
            command = new SQLiteCommand("DELETE FROM 'files' WHERE file_id='" + idInTable + "';", conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
