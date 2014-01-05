using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GST.Model
{
    /// <summary>
    /// It uses instead of the strings in algorithm.
    /// Every 'Token' comprises a lot 'TokenItem' that as count of words contained.
    /// </summary>
    public class Token
    {
        /// <summary>
        /// List of TokenItems. That includes each char of instance's Content.
        /// </summary>
        public List<TokenItem> TokenItems { get; set; }

        /// <summary>
        /// Content is a mandatory field for getting Token instance.
        /// </summary>
        /// <param name="content"></param>
        public Token(string content)
        {
            TokenItems = new List<TokenItem>(content.Count());

            foreach (var item in content)
            {
                TokenItems.Add(new TokenItem(item));
            }
        }
    }
}
