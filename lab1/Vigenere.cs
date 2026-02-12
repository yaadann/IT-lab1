using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    internal class Vigenere
    {
        private string key;
        private string text;
        private string result;
        private const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private const int N = 33;
        public Vigenere(string text, string key) 
        {
            this.text = text;
            this.key = key;
        }

        private char ChangeRegister(char ch)
        {
            if (ch == 'ё')
                return 'Ё';
            return (char)(ch - 'а' + 'А');
        }

        private string ChangeWordRegister(string text)
        {
            string correctText = "";
            for (int i = 0; i < text.Length; i++)
                if (text[i] >= 'А' && text[i] <= 'Я' || text[i] == 'Ё')
                    correctText += text[i];
                else if (text[i] >= 'а' && text[i] <= 'я' || text[i] == 'ё')
                    correctText += ChangeRegister(text[i]);

            return correctText;
        }

        private string CaesarRot(string text, int k)
        {
            char[] newText = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char next = Convert.ToChar(text[i] + k);
                if (next == ('Ё' + 1))
                    newText[i] = Convert.ToChar('Е' + k);
                else
                    newText[i] = next;
            }
            string result = new string(newText);
            return result;
        }

        private string ModifyKey(string key)
        {
            int length = text.Length;
            char[] newKey = new char[length];
            int i = 0;
            while (i < length)
            {
                for (int j = 0; j < key.Length && i < length; j++)
                {
                    newKey[i] += key[j];
                    i++;
                }
                if (i != length)
                    key = CaesarRot(key, 1);
            }
            
            string result = new string(newKey);
            return result;
        }

        private string EncodingSymbols()
        {
            char[] cipherText = new char[text.Length];
            for (int i = 0; i < cipherText.Length; i++)
            {
                int m = FindAlphabetPosition(text[i]) + 1;
                int k = FindAlphabetPosition(key[i]) + 1;

                int index = (m + k) % N;
                if (index == 0)
                    index = N;

                cipherText[i] = Alphabet[index - 1];
            }
            string result = new string(cipherText);
            return result;
        }

        private string EncodeText()
        {
            text = ChangeWordRegister(text);
            key = ChangeWordRegister(key);
            key = ModifyKey(key);

            return EncodingSymbols();
        }

        private int FindAlphabetPosition(char ch)
        {
            int index = 0;
            for (int i = 0; i < Alphabet.Length; i++)
            {
                if (ch == Alphabet[i])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private string DecodingSymbols()
        {
            char[] plainText = new char[text.Length];
            for (int i = 0; i < plainText.Length; i++)
            {
                int c = FindAlphabetPosition(text[i]) + 1;
                int k = FindAlphabetPosition(key[i]) + 1;

                int index = (c - k + N) % N;
                if (index == 0)
                    index = N;

                plainText[i] = Alphabet[index - 1];
            }
            string result = new string(plainText);
            return result;
        }

        private string DecodeText()
        {
            text = ChangeWordRegister(text);
            key = ChangeWordRegister(key);
            key = ModifyKey(key);

            return DecodingSymbols();
        }

        public string GetDecoded()
        {
            result = DecodeText();
            return result;
        }

        public string GetEncoded()
        {
            result = EncodeText();
            return result;
        }

        public static bool CheckCorrect(string text)
        {
            bool correct = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] >= 'а' &&  text[i] <= 'я' ||  text[i] >= 'А' && text[i] <= 'Я')
                {
                    correct = true; 
                    break;
                }
            }
            return correct;
        }
    }
}
