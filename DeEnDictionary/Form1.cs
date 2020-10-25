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

namespace DeEnDictionary
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<string>> germanToEnglishDictionary = new Dictionary<string, List<string>>();
        string csvFile = @"C:\Vedran\CC\Dictionarywoerter.csv";


        public Form1()
        {
            InitializeComponent();
            if (File.Exists(csvFile))
            {
                readCSV(csvFile);
                UpdateTranslations();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var germanWord = tbGermanWord.Text;
            var englishWord = tbEnglishWord.Text;
            var spanishWord = tbSpanishWord.Text;

            if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord)|| !string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(spanishWord))
            {
                germanToEnglishDictionary.Add(germanWord, new List<string> { englishWord, spanishWord });
                UpdateTranslations();
        }
    }

        private void UpdateTranslations()
        {
            lBoxGermanWords.DataSource = germanToEnglishDictionary.Keys.ToList();
        }


        private void lBoxGermanWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWord = lBoxGermanWords.SelectedItem as string;
            if (!string.IsNullOrEmpty(selectedWord) && germanToEnglishDictionary.ContainsKey(selectedWord))
            {
                List<string> newList = new List<string>();
                if (germanToEnglishDictionary.TryGetValue(selectedWord, out newList))
                {
                    tbTranslationEnglish.Text = newList[0];
                    tbTranslationSpanish.Text = newList[1];
                }
            }
        }

        private void btnExportToCsv_Click(object sender, EventArgs e)
        {
            var words = germanToEnglishDictionary;
            String csv = String.Join(
                Environment.NewLine,
                germanToEnglishDictionary.Select(d => $"{d.Key};{d.Value[0]};{d.Value[1]};"));
            System.IO.File.AppendAllText(@"C:\Vedran\CC\Dictionarywoerter.csv", csv.ToString());
        }

        public  string[][] readCSV(string path)
        {
            string[] lines = File.ReadAllLines(path, Encoding.Default);
            string[][] result = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                result[i] = lines[i].Split(';');
                var germanWord = result[i].ElementAt(0);
                var englishWord = result[i].ElementAt(1);
                var spanishWord = result[i].ElementAt(2);
                if (!string.IsNullOrEmpty(germanWord) && !string.IsNullOrEmpty(englishWord))
                {
                    germanToEnglishDictionary.Add(germanWord, new List<string> { englishWord, spanishWord });
                }
            }
            return result;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var textSearch = tbSearch.Text;
            if (germanToEnglishDictionary.ContainsKey(textSearch))
            {
                List<string> listSearch = new List<string>();
                             if (germanToEnglishDictionary.TryGetValue(textSearch, out listSearch))                 
                {
                    tbFindEN.Text = listSearch[0];
                    tbFindES.Text = listSearch[1];
                }
            } else
            {
                tbFindEN.Text = "no luck";
                tbFindES.Text = "no tienes suerte";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.IO.File.Delete(csvFile);
            if (File.Exists(csvFile))
            {
                readCSV(csvFile);
                UpdateTranslations();
            }
        }
    }
}
//Icons made by <a href="https://www.flaticon.com/authors/freepik" title="Freepik">Freepik</a> from <a href="https://www.flaticon.com/" title="Flaticon"> www.flaticon.com</a>