using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DemoMessagingCenter
{
    public partial class ListPage : ContentPage
    {
        ObservableCollection<string> list = new ObservableCollection<string>();
        public ListPage()
        {
            InitializeComponent();
            ListItem.ItemsSource = list;

            MessagingCenter.Subscribe<Message>(this, "AddItem", message => {
                list.Add(message.Value);
            });

        }
    }
}
