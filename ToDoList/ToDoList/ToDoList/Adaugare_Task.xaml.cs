using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Adaugare_Task : ContentPage
    {
        public Adaugare_Task(string oldName)
        {
            /*
            if(oldName!=null)
            {
                Intrare.Text = oldName;
            }
            */

            InitializeComponent();
          
        } 


        private async void Save_Task(object sender, EventArgs e)
        {

            ToDoPage.NewItemName = Intrare.Text;            
            await Navigation.PopModalAsync();
        }

        private async void Cancel_Task(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}