using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;
using Xamarin.Forms;

namespace Exam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void Button_OnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(entrusername.Text))
            {
                await DisplayAlert("Error", "Please Enter Your User Name!", "OK");
            }
            if (string.IsNullOrEmpty(entryuserpass.Text))
            {
                await DisplayAlert("Error", "Please Enter Your PassWord!", "OK");
            }

            var user = new TBL_Login
            {
                username = entrusername.Text,
                pass = entryuserpass.Text
            };
            await TBL_Login.Insert(user);
            await DisplayAlert("Success", "You've Successfully Registered", "OK");
        }
    }
}

  