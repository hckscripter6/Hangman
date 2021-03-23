﻿using Microsoft.Xna.Framework;
using MonoGame.Extended;

namespace Hangman
{
    class LetterSelect
    {
        char letter;
        public RectangleF BoundingBox { get; set; }

        int occurrences = 0;

        public string answerStr;
        bool selected = false;

        bool letterExistsInString;

        public LetterSelect(char letter, RectangleF boundingBox, string answerStr)
        {
            this.letter = letter;
            this.answerStr = answerStr;
            BoundingBox = boundingBox;

            if (answerStr.Contains(letter.ToString()) || answerStr.Contains(letter.ToString().ToLower()))
                letterExistsInString = true;
            else
                letterExistsInString = false;
            
        }

        public char Char
        {
            get { return letter; }
        }

        public bool LetterExistsInString
        {
            get { return letterExistsInString; }
        }

        public bool Selected
        {
            get { return selected; }
            set { selected = value; }
        }

    }
}
