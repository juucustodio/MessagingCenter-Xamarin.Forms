using Xamarin.Forms;

namespace DemoMessagingCenter
{
    public partial class MainPage : TabbedPage
    {
        int cont = 0;
        public MainPage()
        {
            InitializeComponent();
            

            MessagingCenter.Subscribe<Message>(this, "AddItem", message => {
                cont++;
                ContItem.Text = cont.ToString();
            });

        }
    }
}
