//Project Assignment 4 - WinForm Word Search
//Steven Duong and Edwin Coronado

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA4
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes all components in the application (buttons, textboxes, lists, etc)
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            String[] word_list = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            listBoxWords.BeginUpdate();
            listBoxWords.Items.Clear();
            foreach (string word in word_list)
                listBoxWords.Items.Add(word);

            listBoxWords.EndUpdate();
        }

        /// <summary>
        /// Locates a user specified word in the list box (word list)
        /// The parameter is text_str which is the word the user is trying to find
        /// Returns true or false if found
        /// </summary>
        /// <param name="text_str"></param>
        /// <returns></returns>
        private bool FindText (string text_str)
        {
            bool found = false;

            foreach (object word in listBoxWords.Items)
            {
                if (word.ToString().StartsWith(text_str, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxWords.SelectedIndex = listBoxWords.Items.IndexOf(word);
                    found = true;
                    break;
                }
            }
            return found;
        }

        /// <summary>
        /// Search through the list box (word list) for words that rhyme with a user specified word
        /// Add the rhymed words into a new list box (listBoxFinal)
        /// </summary>
        /// <param name="text_str"></param>
        private void FindRhyme (string text_str)
        {
            //go through each word in listBoxWords
            foreach (object word in listBoxWords.Items)
            {
                //if word ends with the same letters as entered string
                if (word.ToString().EndsWith(text_str, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxFinal.Items.Add(word);           //add rhyme words into 
                }
            }
        }

        /// <summary>
        /// Create a array that holds words from the list box (word list) whose word length is between 3 to 7
        /// Then search through the array and check if a word in the list box only contains the letters from a user entered word
        /// Add each scrabble word into the new list box (listBoxFinal)
        /// </summary>
        /// <param name="scrabbleWord"></param>
        private void FindScrabble (string scrabbleWord)
        {
            string[] wordBank = new string[23000];
            int i = 0;
            //This creates a shorter list to search for scrabbleWords
            foreach (object word in listBoxWords.Items)
            {
                if ((word.ToString().Length >= 3) && (word.ToString().Length <= 7))
                {
                    wordBank[i] = word.ToString();
                    i++;  
                }
            }
            i = 0;

            //scrabble words length cannot exceed the entered string
            while (wordBank[i] != null)
            {
                if((wordBank[i].Length <= scrabbleWord.Length))
                {
                    if (LettersAllowed(scrabbleWord, wordBank[i]))      //retrieves the scrabble word
                    {
                        listBoxFinal.Items.Add(wordBank[i]);
                    }
                }
                i++;
            }
        }

        /// <summary>
        /// Look through each letter in the word that is passed in from the array
        /// If the word shares a letter with scrabbleWord, remove that letter from scrabbleWord. This prevents duplicates
        /// Return true if the word uses only the available letters that are provided by the scrabble word
        /// </summary>
        /// <param name="scrabbleWord"></param>
        /// <param name="wordFromWordBank"></param>
        /// <returns></returns>
        private bool LettersAllowed (string scrabbleWord, string wordFromWordBank)
        {
            foreach (char letter in wordFromWordBank)
            {
                if(!scrabbleWord.Contains(letter.ToString()))
                {
                    return false;
                }
                else
                {
                    int indexScrabble = scrabbleWord.IndexOf(letter);
                    scrabbleWord = scrabbleWord.Remove(indexScrabble, 1);
                }
            }
            return true;
        }

        /// <summary>
        /// Go through each word in the list box (word list) and check if a word only differs by 1 letter compared to a user entered word
        /// Add the morph words into the new list box (listBoxFinal)
        /// </summary>
        /// <param name="morphWord"></param>
        private void FindMorph (string morphWord)
        {
            //full alphabet: both upper and lower
            string alpha = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            
            int j = 0;
            int k = 0;

            foreach (object word in listBoxWords.Items)
            {
                if (word.ToString().Length == morphWord.Length)
                {
                    for (j = 0; j < morphWord.Length; j++)
                    {
                        for (k = 0; k < alpha.Length; k++)
                        {
                            string temp = morphWord.Replace(morphWord[j], alpha[k]);
                            if ((string.Equals(temp, word.ToString()) == true) && (!string.Equals(morphWord, temp)))
                            {
                                listBoxFinal.Items.Add(word);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Fill the contents of the list box with all the words from the resource file "WordList"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFill_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnFill_List");
            String[] word_list = Properties.Resources.WordList.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            listBoxWords.BeginUpdate();
            listBoxWords.Items.Clear();
            foreach (string word in word_list)
                listBoxWords.Items.Add(word);

            listBoxWords.EndUpdate();
        }

        /// <summary>
        /// Empty all the contents in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnClear_Click");
            listBoxWords.Items.Clear();
        }

        /// <summary>
        /// When the button "find" is clicked, check if the user entered word is in the list box (word list)
        /// If word is present in the list box, go to that location in the list box
        /// If false, display a string warning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            bool found = false;

            Console.WriteLine("btnFind_Click");

            found = FindText(textBoxUser.Text);
            if(!found)
            {
                string msgStr = String.Format("Couldn't find the string '{0}'", textBoxUser.Text);
                MessageBox.Show(msgStr);
            }
        }

        /// <summary>
        /// When the button "rhyme" is clicked, retrieve all the words that rhymed with the user entered word
        /// Change the label above the list box to "Rhyme List"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRhyme_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnRhyme_Click");
            listBoxFinal.BeginUpdate();
            listBoxFinal.Items.Clear();

            FindRhyme(textBoxUser.Text);
          
            labelList.Text = "Rhyme List";
            listBoxFinal.EndUpdate();
        }
        /// <summary>
        /// When the button "scrabble" is clicked, retrieve all the scrabble words of the user entered word
        /// Change the label above the list box to "Scrabble List"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnScrabble_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnScrabble_Click");
            listBoxFinal.BeginUpdate();
            listBoxFinal.Items.Clear();
            FindScrabble(textBoxUser.Text);

            labelList.Text = "Scrabble List";
            listBoxFinal.EndUpdate();
        }

        /// <summary>
        /// When the button "morph" is clicked, retrieve all the morph words of the user entered word
        /// Change the label above the list box to "Rhyme List"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMorph_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnMorph_Click");
            listBoxFinal.BeginUpdate();
            listBoxFinal.Items.Clear();

            FindMorph(textBoxUser.Text);

            labelList.Text = "Morph List";
            listBoxFinal.EndUpdate();
        }

        /// <summary>
        /// Produce a message popup that contains information on how to use the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnHelp_Click");
            string msgStr = String.Format("To begin using this program, you need to click on the fill button to store the list.\n");
            msgStr += String.Format("\nEnter a word in the text box and click on one of the following buttons:\n");
            msgStr += String.Format("Find: Check if a specified word is present in the list\n");
            msgStr += String.Format("Rhyme: Display words that end in a string specified by the user \n");
            msgStr += String.Format("Scrabble: Display words that are constructed with the letters specified by the user.\n");
            msgStr += String.Format("Morph: Display words that differ from a specified word in only one letter\n");
            MessageBox.Show(msgStr);
        
        }

        /// <summary>
        /// Whenever user double clicks, the word that was clicked is put in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxWords_DoubleClick(object sender, EventArgs e)
        {
            textBoxUser.Text = listBoxWords.Text;
        }
    }
}
