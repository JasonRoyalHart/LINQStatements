using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQStatements
{
    class DuplicateRemover
    {
        public List<String> RemoveDuplicates (List<String> originalList)
        {
            return originalList.Distinct().ToList();
        }
    }
}
