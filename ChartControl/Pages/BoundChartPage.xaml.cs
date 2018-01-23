using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ChartControl.Pages
{
    public partial class BoundChartPage : ContentPage
    {
        public BoundChartPage()
        {
            InitializeComponent();
            this.BindingContext = new BoundChartViewModel();
        }
    }
}
