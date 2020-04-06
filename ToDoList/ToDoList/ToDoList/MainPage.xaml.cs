using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoList
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Logo.Source = ImageSource.FromResource("ToDoList.Imagini.undraw_Creation_process_ukbh.png");
        }

        private async void Button_Clicked_ToDoList(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new ToDoPage());
        }
    }
}
