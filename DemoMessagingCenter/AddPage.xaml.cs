using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DemoMessagingCenter
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EntryItem.Text))
            {
                MessagingCenter.Send(new Message { Title = "New Item", Value = EntryItem.Text }, "AddItem");
            }
        }
    }
}
