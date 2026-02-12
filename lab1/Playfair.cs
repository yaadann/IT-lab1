namespace lab1
{
    internal class Playfair
    {
        private string key;
        private string text;
        private string result;
        private char[,] table;

        public int Operation { get; set; }
        public Playfair(string text, string key)
        {
            this.text = text;
            this.key = key;
        }

        private bool IsTableContains(char c)
        {
            if (c == 'J')
                c = 'I';
            bool contains = false;
            foreach (char c2 in table)
            {
                if (c2 == c)
                {
                    contains = true;
                    break;
                }
            }
            return contains;
        }

        private char[,] GenerateTable()
        { 
            table = new char[5,5];
            int keyCursor = 0;
            char alphabetCursor = 'A';
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (keyCursor != key.Length)
                    {
                        while(keyCursor != key.Length && (IsTableContains(key[keyCursor]) || !CheckChar(key[keyCursor])))
                            keyCursor++;
                        if (keyCursor != key.Length)
                        {
                            table[i, j] = key[keyCursor];
                            keyCursor++;
                        }
                    }
                    else
                    {
                        while (IsTableContains(alphabetCursor))
                            alphabetCursor++;
                        table[i, j] = alphabetCursor;
                        alphabetCursor++;
                    }
                }
            }
            return table;
        }

        private bool FindSymbol(ref int a, ref int b, char c)
        {
            if (c == 'J')
                c = 'I';
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == c)
                    {
                        a = i;
                        b = j;
                        return true;
                    }
                }
            }
            return false;
        }

        private int NextI(int i)
        {
            switch (Operation)
            {
                case 1:
                    if (i + Operation < table.GetLength(0))
                        return i + Operation;
                    else
                        return 0;
                case -1:
                    if (i + Operation >= 0)
                        return i + Operation;
                    else
                        return table.GetLength(0) - 1;
                default:
                    return 0;
            }
        }

        private int NextJ(int j)
        {
            switch (Operation)
            {
                case 1:
                    if (j + Operation < table.GetLength(1))
                        return j + Operation;
                    else
                        return 0;
                case -1:
                    if (j + Operation >= 0)
                        return j + Operation;
                    else
                        return table.GetLength(1) - 1;
                default:
                    return 0;
            }
        }

        private string SameRow(int j1, int j2, int i) { 
            return $"{table[i, NextJ(j1)]}" + $"{table[i, NextJ(j2)]}"; }

        private string SameCol(int i1, int i2, int j) {
            return $"{table[NextI(i1),j]}" + $"{table[NextI(i2), j]}"; }

        private string Another(int i1, int i2, int j1, int j2)
        {
            return $"{table[i1, j2]}" + $"{table[i2, j1]}";
        }


        private string ChangePair(char c1, char c2)
        {
            if (c1 == 'J')
                c1 = 'I';
            if (c2 == 'J')
                c2 = 'I';

            int i1 = 0, i2 = 0, j1 = 0, j2 = 0;
            FindSymbol(ref i1, ref j1, c1);
            FindSymbol(ref i2, ref j2, c2);
            if (i1 == i2)
                return SameRow(j1, j2, i1);
            else if (j2 == j1)
                return SameCol(i1, i2, j1);
            else
                return Another(i1, i2, j1, j2);
        }

        private void ChangeSize()
        {
            if (text.Length % 2 == 0)
                return;
            else
                text += 'X';
        }

        private char ChangeRegister(char ch)
        {
            return (char)(ch - 'a' + 'A');
        }

        private string ChangeWordRegister(string text)
        {
            string correctText = "";
            for (int i = 0; i < text.Length; i++)
                if (text[i] >= 'A' && text[i] <= 'Z')
                    correctText += text[i];
                else if (text[i] >= 'a' && text[i] <= 'z')
                    correctText += ChangeRegister(text[i]);

            return correctText;
        }


        private void ModifyText()
        {
            text = ChangeWordRegister(text);
            for (int i = 0; i < text.Length - 1; i++)
                if (text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, "X");
                    i++;
                }
            ChangeSize();
        }

        private string ChangeSymbols()
        {
            string newText = "";
            for (int i = 0; i < text.Length; i+=2)
                newText += ChangePair(text[i], text[i+1]);
            return newText;
        }

        private string CalcEncodedText()
        {
            key = ChangeWordRegister(key);
            table = GenerateTable();
            ModifyText();
            string text = ChangeSymbols();
            return text;
        }

        public string GetEncoded()
        {
            result = CalcEncodedText();
            return result;
        }

        private string CalcDecodedText()
        {
            key = ChangeWordRegister(key);
            table = GenerateTable();
            ModifyText();
            string text = ChangeSymbols();
            return text;
        }

        public string GetDecoded()
        {
            result = CalcDecodedText();
            return result;
        }

        private static bool CheckChar(char ch)
        {
            return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
        }

        public static bool CheckCorrect(string text)
        {
            bool correct = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (CheckChar(text[i]))
                {
                    correct = true;
                    break;
                }
            }
            return correct;
        }

    }
}
