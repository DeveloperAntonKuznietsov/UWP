using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace universalGrid10X
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       public MainPage()
        {
            try
            {
                this.InitializeComponent();
                myframe.Navigate(typeof(drg1));
                textheader.Text = "Age of Dragons";
            }
            catch(Exception e)
            {
                
            }

        }

        private void btnGamburger_Click(object sender, RoutedEventArgs e)
        {
            mySplitview.IsPaneOpen = !mySplitview.IsPaneOpen;

        }

        private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dragnItemOne.IsSelected) { myframe.Navigate(typeof(drg1)); textheader.Text = "Blue Dragon"; }
            if (dragnItemTwo.IsSelected) { myframe.Navigate(typeof(drg2)); textheader.Text = "Gold Dragon"; }
            if (dragnItemThree.IsSelected) { myframe.Navigate(typeof(drg3)); textheader.Text = "Dragon of Dуath"; }
            if (dragnItemFour.IsSelected) { myframe.Navigate(typeof(drg4)); textheader.Text = "Dragon of Peace"; }
            if (dragnItemFive.IsSelected) { myframe.Navigate(typeof(drg5)); textheader.Text = "Fire Dragon"; }
        }

        private void bntHome_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(drg1));
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (myframe.CanGoBack) myframe.GoBack();
        }

        private void btnForward_Click(object sender, RoutedEventArgs e)
        {
            if (myframe.CanGoForward) myframe.GoForward();
        }

        private void btnBottomHome_Click(object sender, RoutedEventArgs e)
        {
            myframe.Navigate(typeof(drg1));
        }
    } 
}
