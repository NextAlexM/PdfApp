using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PdfApp.Models;
using PdfApp.Views;
using PdfApp.ViewModels;

namespace PdfApp.Views
{
    using Xamarin.Essentials;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class ItemsPage : ContentPage
    {
        public ItemsPage()
        {
            this.InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Task.Run(async () =>
            //{
            //    await Browser.OpenAsync("file:///android_asset/pdfjs/web/viewer.html?file=file:///android_asset/Content/BookPreview2-Ch18-Rel0417.pdf", new BrowserLaunchOptions
            //    {
            //        LaunchMode = BrowserLaunchMode.SystemPreferred,
            //        TitleMode = BrowserTitleMode.Show,
            //        PreferredToolbarColor = Color.AliceBlue,
            //        PreferredControlColor = Color.Violet
            //    });
            //});
        }
    }
}