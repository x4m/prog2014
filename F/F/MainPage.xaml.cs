using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using F.Resources;

namespace F
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            timer = new Timer(Callback, null, 500, 50);
            base.OnNavigatedTo(e);
        }
        Timer timer;

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            timer.Dispose();
            timer = null;
            base.OnNavigatedFrom(e);
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        private Button[,] _grid;
        Dictionary<Button,int> _numbers;
        double buttonSize;
        
        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            canvas.Children.Clear();
            var width = canvas.ActualWidth;
            
            buttonSize = width/4;
            _grid = new Button[4,4];
            _numbers = new Dictionary<Button, int>();
            for (int i = 0; i < 15; i++)
            {
                int x, y;
                x = i%4;
                y = i/4;
                var b = new Button {Width = buttonSize, Height = buttonSize};
                b.Content = new TextBlock {Text = (i+1).ToString("X")};
                b.BorderBrush = new SolidColorBrush(Colors.Red);
                canvas.Children.Add(b);
                Canvas.SetLeft(b,buttonSize*x);
                Canvas.SetTop(b,buttonSize*y);
                _grid[x, y] = b;
                _numbers[b] = i;
                b.Click+=BOnClick;
            }
        }

        private int cnt;
        Random rnd = new Random();
        
        private void Callback(object state)
        {
            Dispatcher.BeginInvoke(() =>
                                       {
                                           if (randomizeButton.IsPressed)
                                           {
                                               var button = _numbers.Keys.ElementAt(rnd.Next(0xf));
                                               while (!TryMoveButton(button))
                                               {
                                               }
                                           }
                                       });
            
        }

        private void BOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            TryMoveButton(sender);
        }

        private bool TryMoveButton(object sender)
        {
            var button = (Button) sender;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (_grid[x, y] == button)
                    {
                        if (x < 3 && _grid[x + 1, y] == null)
                        {
                            Canvas.SetLeft(button, Canvas.GetLeft(button) + buttonSize);
                            _grid[x + 1, y] = button;
                            _grid[x, y] = null;
                        }
                        else if (x > 0 && _grid[x - 1, y] == null)
                        {
                            Canvas.SetLeft(button, Canvas.GetLeft(button) - buttonSize);
                            _grid[x - 1, y] = button;
                            _grid[x, y] = null;
                        }
                        else if (y < 3 && _grid[x, y + 1] == null)
                        {
                            Canvas.SetTop(button, Canvas.GetTop(button) + buttonSize);
                            _grid[x, y + 1] = button;
                            _grid[x, y] = null;
                        }
                        else if (y > 0 && _grid[x, y - 1] == null)
                        {
                            Canvas.SetTop(button, Canvas.GetTop(button) - buttonSize);
                            _grid[x, y - 1] = button;
                            _grid[x, y] = null;
                        }

                        if (!randomizeButton.IsPressed)
                            CheckWin();

                        return true;
                    }
                }
            }
            return false;
        }

        private void CheckWin()
        {
            bool win = true;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    var button = _grid[x, y];
                    if(button == null)
                        continue;
                    var number = _numbers[button];
                    if (number != x + y*4)
                    {
                        win = false;
                        break;
                    }
                }
            }
            if (win)
                NavigationService.Navigate(new Uri("/WinPage.xaml",UriKind.Relative));
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void UIElement_OnHold(object sender, GestureEventArgs e)
        {
            
        }

        private void UIElement_OnKeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}