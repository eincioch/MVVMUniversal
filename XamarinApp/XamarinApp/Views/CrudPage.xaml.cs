﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Views.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CrudPage : ContentPage
    {
        public CrudPage()
        {
            InitializeComponent();
        }
    }
}