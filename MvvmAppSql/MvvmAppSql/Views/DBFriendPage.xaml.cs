using MvvmAppSql.Models;
using Plugin.Messaging;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

namespace MvvmAppSql
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DBFriendPage : ContentPage
	{
		
			public DBFriendPage()
			{
				InitializeComponent();
			}

			void Loobu_Clicked(System.Object sender, System.EventArgs e)
			{
				Navigation.PopAsync();
			}

			void Kustuta_Clicked(System.Object sender, System.EventArgs e)
			{
				Friend friend = (Friend)BindingContext;
				App.Database.DeleteItem(friend.Id);
				Navigation.PopAsync();
			}

			void Salvesta_Clicked(System.Object sender, System.EventArgs e)
			{
				Friend friend = (Friend)BindingContext;
				if (!String.IsNullOrEmpty(friend.Name))
				{
					App.Database.SaveItem(friend);
				}
				this.Navigation.PopAsync();
			}
			void sms_btn_Clicked(System.Object sender, System.EventArgs e)
        {
            var sms = CrossMessaging.Current.SmsMessenger;

            if (sms.CanSendSms)
            {
                string phoneNumber = Phone.Text;  // Get the phone number from the entry field
                string messageText = text.Text;   // Get the text message from the entry field

                sms.SendSms(phoneNumber, messageText);
            }
        }


    }


}