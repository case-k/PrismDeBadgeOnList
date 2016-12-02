using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using PrismDeBadgeOnList.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PrismDeBadgeOnList.ViewModels
{
    public class MainPageViewModel : BindableBase
    {

        public ObservableCollection<TUser> Users { get; } = new ObservableCollection<TUser>
        {
            new TUser
            {
                ID = 0,
                Name = "ピコ太郎",
                Count = 26
            },
            new TUser
            {
                ID = 1,
                Name = "ウソ太郎",
                Count = 0
            },
            new TUser
            {
                ID = 2,
                Name = "すし太郎",
                Count = 1
            },
            new TUser
            {
                ID = 3,
                Name = "博士太郎",
                Count = 10
            },
        };


        public MainPageViewModel()
        {

        }

    }
}
