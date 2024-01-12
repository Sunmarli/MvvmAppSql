﻿using MvvmAppSql.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmAppSql.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendViewModel ViewModel { get; set; }
        public FriendPage( FriendViewModel viewModel)
        {
            InitializeComponent();
            ViewModel=viewModel;
            BindingContext= ViewModel;
        }
    }
}