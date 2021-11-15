﻿using System;
using System.Collections.Generic;
using ExampleMaterialDesignControls.ViewModels;
using Xamarin.Forms;

namespace ExampleMaterialDesignControls.Pages
{
    public partial class MaterialCheckBoxesPage : ContentPage
    {
        public MaterialCheckBoxesPage()
        {
            InitializeComponent();
            this.BindingContext = new MaterialCheckboxViewModel { DisplayAlert = this.DisplayAlert };
        }
    }
}
