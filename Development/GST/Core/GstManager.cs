using GST.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GST.Core
{
    public static class GstManager
    {
        /// <summary>
        /// Computes matching given pattern and text strings using Greedy String Tiling algorithm.
        /// </summary>
        /// <param name="pattern">The string to searching for.</param>
        /// <param name="text">The string to searching in.</param>
        /// <param name="minimumMatchLength">The minimum length of the matched texts. Texts of the smaller than that doesn't show in result.</param>
        /// <returns></returns>
        public static List<Match> GreedyStringTiling(Token pattern, Token text, int minimumMatchLength)
        {
            List<Match> tiles = new List<Match>();

            int maxMatch = minimumMatchLength;

            do
            {
                List<Match> matches = new List<Match>();

                for (int i = 0; i < pattern.TokenItems.Count; i++)
                {
                    for (int j = 0; j < text.TokenItems.Count; j++)
                    {
                        int count = 0;
                        bool check = false;

                        while ((!check && pattern.TokenItems[i + count].Content == text.TokenItems[j + count].Content))
                        {

                            if (text.TokenItems[j].IsMarked && pattern.TokenItems[i].IsMarked)
                            {
                                break;
                            }

                            count++;

                            if ((count + i) > pattern.TokenItems.Count - 1)
                            {
                                check = true;
                            }
                            else
                            {
                                pattern.TokenItems[count + i].IsMarked = true;
                            }

                            if ((count + j) > text.TokenItems.Count - 1)
                            {
                                check = true;
                            }
                            else
                            {
                                text.TokenItems[count + j].IsMarked = true;
                            }
                        }

                        if (count == maxMatch)
                        {
                            string deger = null;

                            for (int z = 0; z < count; z++)
                            {
                                deger += pattern.TokenItems[i + z].Content.ToString();
                            }

                            matches.Add(new Match(i, j, count, deger));
                        }
                        else if (count > maxMatch)
                        {
                            string value = null;

                            for (int z = 0; z < count; z++)
                            {
                                value += pattern.TokenItems[i + z].Content.ToString();
                            }

                            matches.Add(new Match(i, j, count, value));
                        }
                    }
                }

                foreach (var item in matches)
                {
                    for (int a = 0; a < maxMatch - 1; a++)
                    {
                        pattern.TokenItems[item.PatternPosition + a].IsMarked = true;
                        text.TokenItems[item.TextPosition + a].IsMarked = true;
                    }

                    tiles.Add(item);
                }

            } while (maxMatch > minimumMatchLength);

            return tiles;
        }
    }
}
