using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random52Numbers
{
    public class ListOperation
    {
        private List<int> _myList;
        public List<int> myList {
            get { return _myList; }
        }

        public ListOperation()
        {
            _myList = new List<int>();
        }
        private int GiveMeANumber(int low, int high)
        {
            var exclude = myList;
            var range = Enumerable.Range(low, high - (low - 1)).Where(i => !exclude.Contains(i));
            var rand = new System.Random();
            int index = rand.Next(0, (high - (low - 1)) - exclude.Count);
            return range.ElementAt(index);
        }

        public void PopulateList(int low, int high)
        {
            Validator validator = new Validator();
            if (validator.IntRangeValidator(low, high) == 0)
            {
                return;
            }

            if (_myList.Count >= (high - (low - 1)))
                return;

            _myList.Add(GiveMeANumber(low, high));
            PopulateList(low,high);
        }
    }
}
