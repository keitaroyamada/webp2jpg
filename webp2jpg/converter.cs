using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace webp2jpg
{
    internal class converter
    {
        //properties
        internal string direction { get; set; }
        internal List<string>? path_ims { get; set; }

        //methods
        internal void convert()
        {
            if (path_ims == null)
            {
                return;
            }

            foreach (var path_im in path_ims)
            { 

            }
        }
    }
}
