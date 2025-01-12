﻿using ExampleMaterialDesignControls.ViewModels;
using Xamarin.Forms;

namespace ExampleMaterialDesignControls.Pages
{
    public partial class MaterialEntryPage : ContentPage
    {
        public MaterialEntryPage()
        {
            InitializeComponent();

            this.BindingContext = new MaterialEntryViewModel { DisplayAlert = this.DisplayAlert };

            txtName.Focused += TxtName_Focused;
            txtName.Unfocused += TxtName_Unfocused;
        }

        private void TxtName_Unfocused(object sender, FocusEventArgs e)
        {
            txtName.LabelText = "Name* - Unfocused";
        }

        private void TxtName_Focused(object sender, FocusEventArgs e)
        {
            txtName.LabelText = "Name* - Focused";
        }
    }
}