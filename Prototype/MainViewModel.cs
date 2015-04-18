using Perspex.Editor.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class MainViewModel
    {
        private TextDocument document;

        public TextDocument Document
        {
            get { return document; }
            set { document = value; }
        }

    }
}
