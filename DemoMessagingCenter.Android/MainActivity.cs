using Android.App;
using Android.Widget;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;

namespace DemoMessagingCenter.Droid
{
    [Activity(Label = "DemoMessagingCenter", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;


            MessagingCenter.Subscribe<Message>(this, "AddItem", message => {
                ShowAlert("Item adicionado");
            });

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public void ShowAlert(string message)
        {
            Toast.MakeText(ApplicationContext, message, ToastLength.Long).Show();
        }
    }
}