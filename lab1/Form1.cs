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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encode_Click(object sender, EventArgs e)
        {
            string text = text1.Text;
            string key = keyText.Text;
            if (Playfair.CheckCorrect(text) && Playfair.CheckCorrect(key))
            {
                Playfair playfair = new Playfair(text, key);
                playfair.Operation = 1;
                text2.Text = playfair.GetEncoded();
            }
            else
                text2.Text = "";
        }

        private void decode_Click(object sender, EventArgs e)
        {
            string text = text1.Text;
            string key = keyText.Text;
            if (Playfair.CheckCorrect(text) && Playfair.CheckCorrect(key))
            {
                Playfair playfair = new Playfair(text, key);
                playfair.Operation = -1;
                text2.Text = playfair.GetDecoded();
            }
            else
                text2.Text = "";
        }

        private void fileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    text1.Text = fileContent;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(fileName, text2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void encodeVig_Click(object sender, EventArgs e)
        {
            string text = text1Vig.Text;
            string key = keyVig.Text;
            if (Vigenere.CheckCorrect(text) && Vigenere.CheckCorrect(key))
            {
                Vigenere vigenere = new Vigenere (text, key);
                text2Vig.Text = vigenere.GetEncoded();
            }
            else
            {
                text2Vig.Text = "";
            }
        }

        private void decodeVig_Click(object sender, EventArgs e)
        {
            string text = text1Vig.Text;
            string key = keyVig.Text;
            if (Vigenere.CheckCorrect(text) && Vigenere.CheckCorrect(key))
            {
                Vigenere vigenere = new Vigenere(text, key);
                text2Vig.Text = vigenere.GetDecoded();
            }
            else
            {
                text2Vig.Text = "";
            }
        }

        private void saveVig_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    File.WriteAllText(fileName, text2.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void fileButtonVig_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string fileContent = System.IO.File.ReadAllText(filePath);
                    text1Vig.Text = fileContent;
                }
            }
        }
    }
}
