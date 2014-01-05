using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GST.Model
{
    /// <summary>
    /// TokenItem creates and uses for each char in the 'Content' string of 'Token' instances.
    /// Each char in the 'Content' property equals to a TokenItem.
    /// </summary>
    public class TokenItem
    {
        /// <summary>
        /// It includes content of the instance as char.
        /// </summary>
        public char Content { get; set; }

        /// <summary>
        /// It indicates that char has processed or hasn't.
        /// </summary>
        public bool IsMarked { get; set; }

        /// <summary>
        /// Content is a mandatory field for getting TokenItem instance.
        /// </summary>
        /// <param name="content"></param>
        public TokenItem(char content)
        {
            this.Content = content;
            this.IsMarked = false;
        }
    }
}
