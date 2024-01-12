using MvvmAppSql.Models;
using MvvmAppSql.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmAppSql
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DBLisatPage : ContentPage
	{
		public DBLisatPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			friendsList.ItemsSource = App.Database.GetItems();
			base.OnAppearing();
		}

		private async void friendsList_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			Friend selectedfriend = (Friend)e.SelectedItem;
			DBFriendPage friendPage = new DBFriendPage();
			friendPage.BindingContext = selectedfriend;
			await Navigation.PushAsync(friendPage);
		}

		private async void Lisa_Clicked(System.Object sender, System.EventArgs e)
		{
			Friend friend = new Friend();
			DBFriendPage friendPage = new DBFriendPage();
			friendPage.BindingContext = friend;
			await Navigation.PushAsync(friendPage);
		}
	}
}