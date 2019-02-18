using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CODE_TEST_MUHAMMAD_SULEMAN
{
    public static class TextMatching
    {
        private const string upper_alphabates = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890,'.;:;@!#~ ";
        private const string lower_alphabates = "abcdefghijklmnopqrstuvwxyz";
        /// <summary>
        /// Find all occurances of subtext in the text string
        /// </summary>
        /// <param name="text"></param>
        /// <param name="subtext"></param>
        /// <returns></returns>
        public static ArrayList FindSubString(this string text, string subtext)
        {            
            if (String.IsNullOrEmpty(text))
                throw new ArgumentException("the string to find may not be empty", "text");

            if (String.IsNullOrEmpty(subtext))
                throw new ArgumentException("the string to find may not be empty", "subtext");     

            string text_Charater_Number = Convert_string_character_into_alpabate_number(text);
            string subtext_Charater_Number = Convert_string_character_into_alpabate_number(subtext);
            return Text_Matching(text_Charater_Number, subtext_Charater_Number);
        }

        private static string Convert_string_character_into_alpabate_number(string text)
        {           
            int lenght_Lower_alphabates = lower_alphabates.Length;
            string number_string = "";            

            for (int i = 0; i < text.Length; i++)
            {                
                for (int j = 0; j < upper_alphabates.Length; j++)
                {
                    if (text[i] == upper_alphabates[j])
                    {
                        number_string += j.ToString() + " ";                        
                    }
                    else if(j < lenght_Lower_alphabates && text[i] == lower_alphabates[j])
                    {
                        number_string += j.ToString() + " ";
                    }
                }
            }
            return number_string;
        }

        private static ArrayList Text_Matching(string text, string subtext)
        {
            IList<string> arraytext = new List<string>();
            IList<string> arraysubtext = new List<string>();
            Convert_string_into_list(text, arraytext);
            Convert_string_into_list(subtext, arraysubtext);

            ArrayList occurs = new ArrayList();
            int occursIndex = 0;
            int arraysubtextCount = 0;
            for (int j = 0; j < arraytext.Count;)
            {
                for (int i = 0; i < arraysubtext.Count; i++)
                {
                    if (arraysubtext[i] == arraytext[j])
                    {
                        if (occursIndex == 0)
                        {
                            occursIndex = (j + 1);
                        }
                        j++;
                        arraysubtextCount++;
                    }
                    else
                    {
                        j++;
                        break;
                    }
                }

                if (arraysubtextCount == arraysubtext.Count)
                {
                    occurs.Add(occursIndex);
                }
                arraysubtextCount = 0;
                occursIndex = 0;
            }

            if (occurs.Count == 0)
            {
                occurs.Add("<no matches>");
            }

            return occurs;
        }

        private static void Convert_string_into_list(string text, IList<string> arraytext)
        {
            string tmp = "";
            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] != ' ')
                {
                    tmp = tmp + text[i];
                    continue;
                }

                arraytext.Add(tmp);
                tmp = "";
            }            
        }
       
    }
}
