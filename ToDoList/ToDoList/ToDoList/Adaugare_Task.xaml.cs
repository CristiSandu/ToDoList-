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
        bool isEdit = false;
        string oldName;

        public Adaugare_Task(string oldName)
        {
            InitializeComponent();
            
            if (oldName!=null)
            {
                isEdit = true;
                Intrare.Text = oldName;
                this.oldName = oldName;
            }

          
        } 


        private async void Save_Task(object sender, EventArgs e)
        {
            if (isEdit)
            {
                ToDoPage.OldItemName = oldName;
            }
            ToDoPage.NewItemName = Intrare.Text;            
            await Navigation.PopModalAsync();
        }

        private async void Cancel_Task(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}