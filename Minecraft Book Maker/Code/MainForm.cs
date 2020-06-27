using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minecraft_Book_Maker
{
    public partial class MainForm : Form
    {

        private string[] pages;
        private int pagesLength = 0;
        int selectedPage = 0;

        public MainForm()
        {
            InitializeComponent();
        }


        private void ConvertButtonClick(object sender, EventArgs e)
        {
            string alphabet = "аАбБвВгГдДеЕёЁжЖзЗиИйЙкКлЛмМнНоОпПрРсСтТуУфФхХцЦчЧшШщЩЪъЫыЬьЭэЮюЯя.,0123456789";
            //string[] mass;
            ArrayList words = new ArrayList(); 
            //string[] mass = new string[2000];
            int n = -1;
            bool flag = false;

            string text = inputTextbox.Text.Replace("\r\n"," ");

            for (int j = 0; j < text.Length; j++)
            {
                char ch = text[j];

                if (alphabet.IndexOf(ch) != -1)
                {

                    if (!flag) {
                        n++;
                        //mass[n] = "";
                        words.Add("");
                    }
                    words[n] = (string)words[n] + ch;
                    //mass[n] += ch;
                    flag = true;
                }
                else flag = false;
            }
            n++;


            int i = -1;
            flag = false;

            int list = 0;
            pages = new string[1000];
            for (int j = 0; j < pages.Length; j++)
            {
                pages[j] = "";
            }


            int line = 1;
            int symbol = 0;
            //StringBuilder sb = new StringBuilder();

            for (int j = 0; j < text.Length; j++)
            {
                char ch = text[j];
                if (alphabet.IndexOf(ch) != -1)
                {

                    if (!flag)
                    {
                        i++;


                        if (symbol + ((string)words[i]).Length > 18)
                        {
                            symbol = ((string)words[i]).Length;
                            line++;
                            //sb.Append("\r\n");
                            
                            if (line > 14)
                            {
                                line = 1;
                                list++;
                                //sb.Append("==============\r\n");
                                //cout << "==============" << endl;
                            } else
                            {
                                pages[list] += "\r\n";
                            }

                        }
                        else
                        {
                            symbol += ((string)words[i]).Length;
                        }
                        pages[list] += (string)words[i];
                        //sb.Append(mass[i]);
                        //cout << mass[i];
                    }
                    //mass[n]+=ch;
                    flag = true;
                }
                else
                {
                    flag = false;

                    if (symbol + 1 > 18)
                    {
                        symbol = 1;
                        line++;
                        //sb.Append("\r\n");
                        if (line > 14)
                        {
                            line = 1;
                            list++;
                            //sb.Append("==============\r\n");
                            //cout << "==============" << endl;
                        } else
                        {
                            pages[list] += "\r\n";
                        }
                    }
                    else
                    {
                        symbol += 1;
                    }
                    if (ch == ' ' && symbol == 1)
                    {
                        symbol = 0;
                    }
                    else pages[list] += ch;
                    //sb.Append(ch);
                    //cout << ch;
                }
            }
            pagesLength = list + 1;
            selectedPage = 0;
            //sb.Append("==============\r\n");
            //cout << endl << endl << list;

            this.selectedPage = 0;
            displayToOutput();
        }

        private void goLeftPageButton_Click(object sender, EventArgs e)
        {
            if (this.selectedPage - 1 < 0) return;
            this.selectedPage--;
            displayToOutput();
        }

        private void goRightPageButton_Click(object sender, EventArgs e)
        {
            if (this.selectedPage + 1 >= pagesLength) return;
            this.selectedPage++;
            displayToOutput();
        }

        private void displayToOutput()
        {
            outputLabel.Text = "====== " + (selectedPage + 1) + "/" + (pagesLength) + " ======\r\n" + pages[selectedPage];
        }

        private async void outputLabel_Click(object sender, EventArgs e)
        {
            if (pages == null) return;
            if (pages[selectedPage] != "") Clipboard.SetText(pages[selectedPage]);

            outputLabel.BackColor = Color.LightGray;
            await Task.Run(() => {
                System.Threading.Thread.Sleep(200);
                outputLabel.BackColor = Color.White;
            });
        }
    }
}
