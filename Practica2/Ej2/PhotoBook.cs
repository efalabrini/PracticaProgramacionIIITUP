using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2.Ej2
{
    public class PhotoBook
    {
        protected int _numPages;

        public int GetNumberPages()
        {
            return _numPages;
        }

        public PhotoBook()
        {
            _numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            _numPages=numPages;
        }
    }
}
