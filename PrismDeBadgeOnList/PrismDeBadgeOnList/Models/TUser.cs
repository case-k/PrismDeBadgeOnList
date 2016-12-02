using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismDeBadgeOnList.Models
{
    public class TUser : BindableBase
    {
        public int ID { get; set; }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private int _count;
        public int Count
        {
            get { return _count; }
            set { SetProperty(ref _count, value); }
        }
    }
}
