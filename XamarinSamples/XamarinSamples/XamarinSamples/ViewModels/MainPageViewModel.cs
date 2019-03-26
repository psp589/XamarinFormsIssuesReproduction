using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinSamples.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public class Item : INotifyPropertyChanged
        {
            private bool _isVisible;

            public Item(string text)
            {
                Text = text;
                IsVisible = true;
            }
            public string Text { get; set; }
            public bool IsVisible
            {
                get => _isVisible;
                set
                {
                    _isVisible = value;
                    RaisePropertyChanged();
                }
            }
            protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
            {
                var handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
            }
            public event PropertyChangedEventHandler PropertyChanged;
        }
        public static string ObservableCollectionTestPropertyName() { return nameof(ObservableCollectionTest); }
        private ObservableCollection<Item> _ObservableCollectionTest = new ObservableCollection<Item>(new List<Item>()
        {
            new Item("test 1")
            , new Item("test 2")
            , new Item("test 3")
            , new Item("test 4")
            , new Item("test 5")
            , new Item("test 6")
            , new Item("test 7")
            , new Item("test 8")
            , new Item("test 9")
            , new Item("test 10")
            , new Item("test 11")
            , new Item("test 12")
            , new Item("test 13")
            , new Item("test 14")
            , new Item("test 15")
            , new Item("test 16")
            , new Item("test 17")
            , new Item("test 18")
            , new Item("test 19")
            , new Item("test 20")
            , new Item("test 21")
            , new Item("test 22")
            , new Item("test 24")
            , new Item("test 25")
            , new Item("test 26")
            , new Item("test 27")
            , new Item("test 28")
            , new Item("test 29")
            , new Item("test 30")
            , new Item("test 31")
            , new Item("test 32")
            , new Item("test 33")
            , new Item("test 34")
            , new Item("test 35")
            , new Item("test 36")
            , new Item("test 37")
            , new Item("test 38")
            , new Item("test 39")
            , new Item("test 40")
        });

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Item> ObservableCollectionTest
        {
            get
            {
                return _ObservableCollectionTest;
            }
            set
            {
                _ObservableCollectionTest = value;
                RaisePropertyChanged();
            }
        }
        protected virtual void RaisePropertyChanged(
            [CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
