using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToDoList
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoPage : ContentPage
    {

        public static string NewItemName;
        public ObservableCollection<Element_Task> lista ;
        public ToDoPage()
        {
            InitializeComponent();
            lista = new ObservableCollection<Element_Task>();
            listview.ItemsSource = lista;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(NewItemName != null)
            {
                lista.Add(new Element_Task { Name = NewItemName });
                NewItemName = null;
            }
            
        }
 
        private async  void AddTask(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Adaugare_Task(null));
        }

        private async void Edit_Task(object sender, EventArgs e)
        {
            Element_Task task = ((Button)sender).BindingContext as Element_Task;

            string oldName = task.Name;

            if (task == null)
            {
                return;
            }
            else
            {
                lista.Remove(task);
            }

            await Navigation.PushModalAsync(new Adaugare_Task(oldName));

        }

        private void Delete_Task(object sender, EventArgs e)
        {
             
            Element_Task task = ((Button)sender).BindingContext as Element_Task;
            if(task == null)
            {
                return;
            }else
            {
                lista.Remove(task);
            }
        }
    }
}