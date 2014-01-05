/*
 * H.Burak TUNGUT : info@buraktungut.com
 * Uğur Kılıç : ugrkilc@gmail.com
 */
using GST.Core;
using GST.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Match> result1 = GstManager.GreedyStringTiling(new Token("ugurl"), new Token("ugurlkkugurlkkjjkugurkkkugur"), 3);

            List<Match> result2 = GstManager.GreedyStringTiling(new Token("mput"), new Token("computeromputerecumpotertercumpoter"), 4);

            List<Match> result3 = GstManager.GreedyStringTiling(new Token("mado"), new Token("dondurmadondurmadondurma"), 4);
        }
    }
}
