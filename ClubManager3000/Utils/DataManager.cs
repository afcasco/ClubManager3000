using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManager3000.Utils
{
    // Classe que s'encarrega de interactuar amb un fitxer per carregar i guardar dades, mostrant el missatge adient en un textbox.
    internal class DataManager
    {
        private string FileName;
        private TextBox _statusTextBox;

        public  DataManager(string fileName, TextBox statusTextBox)
        {
            FileName = fileName;
            _statusTextBox = statusTextBox;
        }


        // Carregar dades
        public List<Soci> LoadData()
        {
            List<Soci> sociList = new List<Soci>();
            try
            {
                if (File.Exists(FileName))
                {
                    sociList =  File.ReadAllLines(FileName)
                        .Select(Soci.ParseSoci)
                        .OrderBy(soci => soci.Name)
                        .ToList();

                    _statusTextBox.Text = "Dades carregades correctament";

                    return sociList;

                }
                else
                {
                    _statusTextBox.Text = "Error carregant dades: L'arxiu dades.txt no exiteix!";
                    return new List<Soci>();
                }
               
            } catch {
           
                _statusTextBox.Text = "Error carregant dades: Format incorrecte!";
                return new List<Soci>();
            }    
            
        }


        // Guardar dades
        public void SaveData(List<Soci> sociList)
        {
            using (var writer = new StreamWriter(FileName))
            {
                sociList.ForEach(soci => writer.WriteLine(Soci.convertToText(soci)));
            }
        }
    }
}
