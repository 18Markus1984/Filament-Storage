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
using MySql.Data.MySqlClient;

namespace FilamentLagerung
{
    public class SQLConnection
    {
        static MySqlConnection sqlConnect = new MySqlConnection(        //Daten für die Verbindung mit dem Datensatz
                "SERVER=localhost;" +
                "DATABASE=filamentlagerung;" +
                "UID=root;" +
                "PASSWORD=;");

        public DataSet ds;  
        public MySqlDataAdapter dataAdapter;
        public string dataBank;                                         //Name der Tabele

        public SQLConnection(string dataBank)                           //Der Konstruktor, der die Verbindung zur entsprechenden Tabele erstellt
        {
            this.dataBank = dataBank;
            dataAdapter = CreateSqlDataAdapter(dataBank);
            ds = ReadData(dataBank);
        }

        public MySqlDataAdapter CreateSqlDataAdapter(string dataBank)       //Wird benutzt um Datenadapter mit einem CommandBuilder zu verknüpfen um direkt die update funktion nutzen zu können 
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommandBuilder cmdBuilder = new MySqlCommandBuilder(adapter);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.SelectCommand = new MySqlCommand("SELECT * FROM " + dataBank, sqlConnect);

            return adapter;
        }

        public DataSet ReadData(string dataBank)            //Daten aus der Tabele auslesen von der der Name gespeichert wurde
        {
            DataSet ds = new DataSet();
            dataAdapter.SelectCommand = new MySqlCommand("SELECT * FROM " + dataBank, sqlConnect);      //Hierzu wird ein SQL-Command benutzt
            dataAdapter.Fill(ds, dataBank);                             //Hier werden die Daten die wir mit dem DataAdapter ausgelesen haben in ein Dataset geschrieben
            return ds;
        }

        public void SaveData()
        {
            dataAdapter.Update(ds, dataBank);           //Hier können wir beim Updaten der Datentabele einfach update benutzen, da wir den Commandbuilder benutzen
        }

        public void DeleteData(DataRow dataRow)         //Löschen einer Reihe bzw. eines Filaments
        {
            sqlConnect.Open();                          //eine Sql Verbindung wird geöffnet
            MySqlCommand command = new MySqlCommand();
            if (ds.Tables[0].TableName == "filament")       //Hier wird zwischen den Tabelen unterschieden, da es nie zu 100% funktioniert hat cascade zu benutzen, da manche Dinge in 
            {
                command = new MySqlCommand("DELETE FROM filament WHERE Filament_ID = " + dataRow[0], sqlConnect);
            }
            else if (ds.Tables[0].TableName == "material")
            {
                command = new MySqlCommand("DELETE FROM material WHERE NameM = '" + dataRow[0]+"'", sqlConnect);
            }
            else if (ds.Tables[0].TableName == "unternehmen")
            {
                command = new MySqlCommand("DELETE FROM unternehemen WHERE NameU = '" + dataRow[0]+"'", sqlConnect);
            }

            command.ExecuteNonQuery();          //Der Befehl wird ausgeführt.
            sqlConnect.Close();
            ds.Tables[0].Rows.Remove(dataRow);  //Die Reihe wird aus dem Dataset gelöscht.
        }

    }
}
