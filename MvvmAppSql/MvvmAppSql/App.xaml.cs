
using MvvmAppSql.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmAppSql
{
	public partial class App : Application
	{
		public const string DATABASE_NAME = "friends.db";
		public static FriendsRepository database;
		

		public static FriendsRepository Database
		{
			get
			{
				if (database == null)
				{
					database = new FriendsRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
				}
				return database;
			}
		}

		

		public App()
		{
			InitializeComponent();

			MainPage = new NavigationPage(new DBLisatPage());
			//MainPage = new NavigationPage(new FriendsListPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
