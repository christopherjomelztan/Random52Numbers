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
        private Validator _validator;

        public List<int> myList {
            get { return _myList; }
        }
        public ListOperation()
        {
            _validator = new Validator();
            _myList = new List<int>();
        }

        private int Limit(int low, int high)
        {
            return high - (low - 1);
        }

        private int GiveMeANumber(int low, int high)
        {
            var exclude = myList;
            var range = Enumerable.Range(low, Limit(low,high)).Where(i => !exclude.Contains(i));
            var rand = new System.Random();
            int index = rand.Next(0, (Limit(low, high)) - exclude.Count);
            return range.ElementAt(index);
        }

        public void PopulateList(int low, int high)
        {
            if (_validator.IntRangeValidator(low, high) == 0)
                return;

            if (_myList.Count >= (high - (low - 1)))
                return;

            _myList.Add(GiveMeANumber(low, high));
            PopulateList(low,high);
        }
    }
}
