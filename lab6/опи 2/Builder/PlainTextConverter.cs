using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using опи_2.ProductClass;

namespace опи_2.Builder
{
    class PlainTextConverter: TextConverter
    
    {
        Product _productText = new Product(); // отображения rtf на экране

        public void GetText(string text)
        {
            string delPattern = @"\{.+\}";
            text = Regex.Replace(text, delPattern, String.Empty);

            string pattern = @"(?<defaultText>\s+(\w|\d|\s)+)|(?<boldText>\\b0|\\b)|(?<italicText>\\i0|\\i)|(?<underlineText>\\ulnone|\\ul)|(?<parTag>\\par)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            if (matches.Count > 0)
            {
                string editedString = "";
                foreach (Match match in matches)
                {
                    if (match.Groups["defaultText"].Value != "")
                    {
                        editedString = ConvertText(match.Groups["defaultText"].Value);
                    }
                    else if (match.Groups["boldText"].Value != "")
                    {
                        editedString = ConvertBold(match.Groups["boldText"].Value);
                    }
                    else if (match.Groups["italicText"].Value != "")
                    {
                        editedString = ConvertItalic(match.Groups["italicText"].Value);
                    }
                    else if (match.Groups["underlineText"].Value != "")
                    {
                        editedString = ConvertUnderline(match.Groups["underlineText"].Value);
                    }
                    else if (match.Groups["parTag"].Value != "")
                    {
                        editedString = Paragraph(match.Groups["parTag"].Value);
                    };
                    _productText.Add(editedString);
                }
            }
        }

        public string ConvertBold(string str)// для определения полужирного фрагмента 
        {
            string editingText = "";
            string boldTags = @"(?<boldCloseTag>\\b0)|(?<boldOpenTag>\\b)";
            Regex regex = new Regex(boldTags);
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    if (match.Groups["boldCloseTag"].Value != "")
                    {
                        editingText = "";
                    }
                    else if (match.Groups["boldOpenTag"].Value != "")
                    {
                        editingText = "";
                    }
                }
            }
            return editingText;
        }

        public string ConvertText(string str)//Для слов вне служебных инструкций
        {
            string editingText = "";
            editingText = str;
            return editingText;
        }

        public string ConvertItalic(string str)
        {
            string editingText = "";
            string boldTags = @"(?<italicCloseTag>\\i0)|(?<italicOpenTag>\\i)";
            Regex regex = new Regex(boldTags);
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    if (match.Groups["italicCloseTag"].Value != "")
                    {
                        editingText = "";
                    }
                    else if (match.Groups["italicOpenTag"].Value != "")
                    {
                        editingText = "";
                    }
                }
            }
            return editingText;
        }

        public string ConvertUnderline(string str)
        {
            string editingText = "";
            string boldTags = @"(?<underlineCloseTag>\\ulnone)|(?<underlineOpenTag>\\ul)";
            Regex regex = new Regex(boldTags);
            MatchCollection matches = regex.Matches(str);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    if (match.Groups["underlineCloseTag"].Value != "")
                    {
                        editingText = "";
                    }
                    else if (match.Groups["underlineOpenTag"].Value != "")
                    {
                        editingText = "";
                    }
                }
            }
            return editingText;
        }

        public string Paragraph(string str)
        {
            string editingText = str;
            string pattern = @"\\par";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(editingText);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                    editingText = "\n";
            }
            return editingText;
        }

        public Product GetProduct()
        {
            return _productText;
        }

        public void Reset()
        {
            _productText = new Product();
        }
    
}
}
