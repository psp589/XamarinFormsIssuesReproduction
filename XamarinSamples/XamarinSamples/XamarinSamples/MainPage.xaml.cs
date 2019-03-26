using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinSamples.ViewModels;

namespace XamarinSamples
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            var viewModel = this.BindingContext as MainPageViewModel;
            viewModel.ObservableCollectionTest[1].IsVisible = !viewModel.ObservableCollectionTest[1].IsVisible;
            viewModel.ObservableCollectionTest[2].IsVisible = !viewModel.ObservableCollectionTest[2].IsVisible;
            viewModel.ObservableCollectionTest[3].IsVisible = !viewModel.ObservableCollectionTest[3].IsVisible;
            viewModel.ObservableCollectionTest[4].IsVisible = !viewModel.ObservableCollectionTest[4].IsVisible;
            viewModel.ObservableCollectionTest[5].IsVisible = !viewModel.ObservableCollectionTest[5].IsVisible;
            viewModel.ObservableCollectionTest[6].IsVisible = !viewModel.ObservableCollectionTest[6].IsVisible;
            viewModel.ObservableCollectionTest[7].IsVisible = !viewModel.ObservableCollectionTest[7].IsVisible;
            viewModel.ObservableCollectionTest[8].IsVisible = !viewModel.ObservableCollectionTest[8].IsVisible;
            viewModel.ObservableCollectionTest[9].IsVisible = !viewModel.ObservableCollectionTest[9].IsVisible;
            viewModel.ObservableCollectionTest[10].IsVisible = !viewModel.ObservableCollectionTest[10].IsVisible;
            viewModel.ObservableCollectionTest[11].IsVisible = !viewModel.ObservableCollectionTest[11].IsVisible;
            viewModel.ObservableCollectionTest[12].IsVisible = !viewModel.ObservableCollectionTest[12].IsVisible;
            viewModel.ObservableCollectionTest[13].IsVisible = !viewModel.ObservableCollectionTest[13].IsVisible;
            viewModel.ObservableCollectionTest[14].IsVisible = !viewModel.ObservableCollectionTest[14].IsVisible;
            viewModel.ObservableCollectionTest[15].IsVisible = !viewModel.ObservableCollectionTest[15].IsVisible;
            viewModel.ObservableCollectionTest[16].IsVisible = !viewModel.ObservableCollectionTest[16].IsVisible;
            viewModel.ObservableCollectionTest[17].IsVisible = !viewModel.ObservableCollectionTest[17].IsVisible;
            viewModel.ObservableCollectionTest[18].IsVisible = !viewModel.ObservableCollectionTest[18].IsVisible;
            viewModel.ObservableCollectionTest[19].IsVisible = !viewModel.ObservableCollectionTest[19].IsVisible;
            viewModel.ObservableCollectionTest[20].IsVisible = !viewModel.ObservableCollectionTest[20].IsVisible;
        }
    }
}
