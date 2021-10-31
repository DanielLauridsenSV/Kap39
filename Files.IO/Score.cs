using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files.IO
{
    internal class Score
    {
        public int Scoreint { get; set; }
        public string Name { get; set; }

        public Score (int score,string name)
        {
            Scoreint = score;
            Name = name;
        }

    }

}
