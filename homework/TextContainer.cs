using System;

namespace Homework
{
    class TextContainer
    {
        private string[] text;
        private int lineCount;

        public int LineCount
        {
            get { return lineCount; }
            private set { lineCount = value; }
        }

        public TextContainer(string[] inputLines)
        {
            text = inputLines;
            LineCount = text.Length;
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < LineCount)
                    return text[index];
                else
                    return "Індекс поза межами!";
            }
            set
            {
                if (index >= 0 && index < LineCount)
                    text[index] = value;
            }
        }


    }
}