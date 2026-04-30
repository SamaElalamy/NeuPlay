using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NeuPlay
{
    internal class LevelManager
    {
        //implementing array of objects concept
        public WordItem[] LoadLevel(string path)
        {
            //Exception Handling
            try
            {
                //file handling
                //reading text files
                string[] lines = File.ReadAllLines(path);
                //counting number of items in the file
                int number_of_lines = lines.Length;
                //null array of WordItem elements
                WordItem[] words_of_level = new WordItem[number_of_lines];
                for (int i = 0; i < number_of_lines; i++)
                {
                    //assigning value to the array elements
                    words_of_level[i] = new WordItem(lines[i]);
                }
                return words_of_level;
            }
            catch(Exception ex)
            {
                //Avoiding error that can occur during program's execution
                MessageBox.Show("File not found\n" + ex.Message);
                return null;
            }
            
        }
    }
}
