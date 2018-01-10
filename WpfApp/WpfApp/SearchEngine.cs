using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    class SearchEngine
    {
        //public string TryGetName(string title)
        //{
        //    Search search = new Search(title);
        //    return search.Input;
        //}
        public bool TryGetName(string title, out string name)
        {
            Search search = new Search(title);
            search.ShowDialog();
            name = search.Input;
            return !String.IsNullOrWhiteSpace(name);
        }
    }
}
