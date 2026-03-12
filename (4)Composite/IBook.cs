using System;
using System.Collections.Generic;
using System.Text;

namespace _4_Composite
{
    internal interface IBook
    {
        void ShowDetails(int indent = 0);
        int GetPages();
    }
}
