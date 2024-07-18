﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Button_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid myGrid = new Grid();
            this.Content = myGrid;

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 100;
            myButton.Background = Brushes.Beige;

            WrapPanel myWrapPanel = new WrapPanel();

            TextBlock textBlock1 = new TextBlock();
            textBlock1.Text = "Hello";
            textBlock1.Background = Brushes.LightGreen;
            myWrapPanel.Children.Add(textBlock1);

            TextBlock textBlock2 = new TextBlock();
            textBlock2.Text = "World!";
            textBlock2.Background = Brushes.Red;
            myWrapPanel.Children.Add(textBlock2);

            TextBlock textBlock3 = new TextBlock();
            textBlock3.Text = "World!";
            textBlock3.Background = Brushes.BlueViolet;
            myWrapPanel.Children.Add(textBlock3);

            myButton.Content = myWrapPanel;

            myGrid.Children.Add(myButton);
        }
    }
}