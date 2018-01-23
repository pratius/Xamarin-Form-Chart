using Xamarin.Forms;

namespace ChartControl
{
    public partial class ChartControlPage : ContentPage
    {
      


        public ChartControlPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var param = sender as Button;
            if (param.CommandParameter=="Bar")
            {
                await Navigation.PushAsync(new Pages.BarChartPage());
            }
            else if (param.CommandParameter == "Bound")
            {
                await Navigation.PushAsync(new Pages.BoundChartPage());
            }
            else if (param.CommandParameter =="Combination")
            {
                await Navigation.PushAsync(new Pages.CombinationPage());
            }
            else if (param.CommandParameter == "Line")
            {
                await Navigation.PushAsync(new Pages.LineChartPage());
            }
            else if (param.CommandParameter == "Pie")
            {
                await Navigation.PushAsync(new Pages.PieChartPage());
            }
        }



    }
}
