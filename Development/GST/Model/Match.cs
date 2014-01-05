using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GST.Model
{
    /// <summary>
    /// This class uses for result of algorithm computing.
    /// </summary>
    public class Match
    {
        /// <summary>
        /// It indicates that matched value position in pattern string.
        /// </summary>
        public int PatternPosition { get; set; }

        /// <summary>
        /// It indicates that matched value position in text string.
        /// </summary>
        public int TextPosition { get; set; }

        /// <summary>
        /// It indicates that matched value (total char) length.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// It indicates that matched value, itself.
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// All fields are mandatory fields in this class.
        /// </summary>
        /// <param name="patternPosition"></param>
        /// <param name="textPosition"></param>
        /// <param name="length"></param>
        public Match(int patternPosition, int textPosition, int length, string value)
        {
            this.PatternPosition = patternPosition;
            this.TextPosition = textPosition;
            this.Length = length;
            this.Value = value;
        }
    }
}
