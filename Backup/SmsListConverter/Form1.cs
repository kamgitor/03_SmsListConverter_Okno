using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
// using System.Diagnostics;

namespace SmsListConverter
{
    public partial class Form1 : Form
    {
        string filename = null;
        string char1 = null, char2 = null, char3 = null;


        // ****************************************************************
        // ret: 1 - poprawny poczatek wersa, 0 - kontynuacja
        static bool VerseTestStartLine(string verse)
        {
            int size;

            if (verse == "Date,Time,Type,Number,Name,Message")      // linijka specialna poczatkowa
                return true;

            size = verse.Length;

            if (size < 20)
                return false;

            if (verse[0] != '2')
                return false;           // nie poczatek

            if (verse[1] != '0')
                return false;

            if (verse[4] != '-')
                return false;

            if (verse[7] != '-')
                return false;

            if (verse[10] != ',')
                return false;

            if (verse[13] != ':')
                return false;

            if (verse[16] != ':')
                return false;

            if (verse[19] != ',')
                return false;

            return true;

        }   // VerseTestStartLine


        // ****************************************************************
        // ret: 1 - special znak, 0 - nit special znak
        static bool TestSpecial(char znak)
        {
            byte i;
            char[] tab = {   (char)0xD83C, (char)55357, (char)0xDE0A, (char)0xDE09,
                             (char)0xDE18, (char)0xDE42, (char)0xDE0D, (char)0xDE03,
                             (char)0xDE00, (char)0xDE13, (char)0xDE12, (char)0xDCA9,
                             (char)0xDC8F, (char)0xDC8B, (char)0xDC69, (char)0xDC36,
                             (char)0xDC25, 
                             (char)0 };

            for (i = 0; i < 100; i++)
            {
                if (tab[i] == 0)
                    break;  // return false;

                if (tab[i] == znak)
                    return true;
            }

            if (znak >= 0xDC23)
                // if (znak >= 0xDE00)
                return true;

            return false;

        }   // TestSpecial


        // *********************************************************
        private void MakeDefaultIniFiles()
        {
            TextWriter plik_wy = new StreamWriter("params.ini");
            plik_wy.WriteLine("sms.csv");
            plik_wy.WriteLine(",");
            plik_wy.WriteLine(";");
            plik_wy.WriteLine("_");
            plik_wy.Close();

        }   // MakeDefaultIniFiles


        // *********************************************************
        private void LoadParams()
        {
            TextReader plik_we = null;
            try
            {
                plik_we = new StreamReader("params.ini");
            }
            catch
            {
                MakeDefaultIniFiles();
                plik_we = new StreamReader("params.ini");
            }

            filename = plik_we.ReadLine();
            char1 = plik_we.ReadLine();
            char2 = plik_we.ReadLine();
            char3 = plik_we.ReadLine();
            plik_we.Close();

            txt_filename.Text = filename;
            char_1.Text = char1;
            char_2.Text = char2;
            char_3.Text = char3;

        }   // LoadParams


        // *********************************************************
        private void SaveParams()
        {
            TextWriter plik_wy = new StreamWriter("params.ini");
            plik_wy.WriteLine(txt_filename.Text);
            plik_wy.WriteLine(char_1.Text);
            plik_wy.WriteLine(char_2.Text);
            plik_wy.WriteLine(char_3.Text);
            plik_wy.Close();

        }   // SaveParams


        // *********************************************************
        public Form1()
        {
            InitializeComponent();

            LoadParams();

        }   // Form1


        // *********************************************************
        private void btn_convert_Click(object sender, EventArgs e)
        {
            string verse = null;
            string verse_out = null;
            short i, index = 0;
            char znak;
            byte comma_cnt;

            // Przepisanie parametrow z okna
            filename = txt_filename.Text;
            char1 = char_1.Text;
            char2 = char_2.Text;
            char3 = char_3.Text;

            SaveParams();

            // otwarcie pliku do odczytu
            StreamReader plik_we = File.OpenText(filename);

            // otwarcie pliku do zapisu
            TextWriter plik_wy = new StreamWriter("converted.txt");

            verse_out = null;
            comma_cnt = 0;

            for (; ;)        // przelot po wersach
            {
                verse = plik_we.ReadLine();
                if (verse == null)               // koniec pliku
                {
                    if (verse_out != null)
                        plik_wy.WriteLine(verse_out);
                    break;
                }

                index = 0;

                if (VerseTestStartLine(verse))      // verse poprawnie sie zaczyna
                {
                    if (verse_out != null)
                        plik_wy.WriteLine(verse_out);

                    verse_out = null;
                    comma_cnt = 0;
                }
                else      // vers jest kontynuacja
                {
                    verse_out += " ";       // dodanie spacji zeby wersy byly oddzielone
                }

                for (i = 0; i < verse.Length; i++)       // przelot po poszczegolnych znakach
                {
                    znak = verse[index++];

                    // if (znak == ',')
                    if (znak == char1[0])       // ','
                    {
                        if (comma_cnt < 5)
                        {
                            // verse_out += ";";
                            verse_out += char2;
                            ++comma_cnt;
                        }
                        else
                        {
                            verse_out += znak;
                        }
                    }
                    // else if (znak == ';')       
                    else if (znak == char2[0])   // jak w wejsciu jest srednik
                    {
                        // verse_out += '_';
                        verse_out += char3;
                    }
                    else if (znak == '\"')
                    {
                        verse_out += " ";
                    }
                    else if (znak == '\n')
                    {
                        break;
                    }
                    else if (TestSpecial(znak))
                        verse_out += " ";
                    else
                    {
                        verse_out += znak;
                    }

                }

            }

            plik_we.Close();
            plik_wy.Close();

            MessageBox.Show("Conversion success", "info", MessageBoxButtons.OK);

        }

        private void debug_Click(object sender, EventArgs e)
        {
 /*
            string test = "test";
            char [] oko;
            char znak;
            string test2 = null;

            // test = new string "test";

            // oko = test.ToCharArray();
            // znak = oko[0];

            // znak = test.to
            // znak = test2.to
            znak = char_1.GetCharFromPosition(;
            // znak = char_1[0];
            // znak = test.ToCharArray(0, 1);
*/ 
        }
    }
}
