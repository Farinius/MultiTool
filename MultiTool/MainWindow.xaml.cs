using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;
using MahApps.Metro;
using System.Collections.ObjectModel;

namespace MultiTool
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ChangeAppStyle(string color, string background)
        {
            Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);

            ThemeManager.ChangeAppStyle(Application.Current,
                                     ThemeManager.GetAccent(color),
                                     ThemeManager.GetAppTheme(background));

        }

        private void MetroWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> colorList = GetColorList();
            List<string> bgList = GetBGList();

            foreach (var item in colorList)
            {
                MenuItem newMenuItem2 = new MenuItem();
                MenuItem newExistMenuItem = (MenuItem)Styles.Items[0];
                newMenuItem2.Header = item;
                newMenuItem2.Click += NewMenuItem2_Click;
                newExistMenuItem.Items.Add(newMenuItem2);
            }

            foreach (var item in bgList)
            {
                MenuItem newMenuItem2 = new MenuItem();
                MenuItem newExistMenuItem = (MenuItem)Styles.Items[2];
                newMenuItem2.Header = item;
                newMenuItem2.Click += NewMenuItem2_Click1; ;
                newExistMenuItem.Items.Add(newMenuItem2);
            }
        }

        private void NewMenuItem2_Click1(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;

            string bgColor = mnu.Header.ToString();

            Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);

            ChangeAppStyle(appStyle.Item2.Name, bgColor);
        }

        private void NewMenuItem2_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)sender;

            string color = mnu.Header.ToString();

            Tuple<AppTheme, Accent> appStyle = ThemeManager.DetectAppStyle(Application.Current);

            ChangeAppStyle(color, appStyle.Item1.Name);
        }

        private List<string> GetColorList()
        {
            List<string> colorList = new List<string>();

            colorList.Add("Red");
            colorList.Add("Green");
            colorList.Add("Blue");
            colorList.Add("Purple");
            colorList.Add("Orange");
            colorList.Add("Lime");
            colorList.Add("Emerald");
            colorList.Add("Teal");
            colorList.Add("Cyan");
            colorList.Add("Cobalt");
            colorList.Add("Indigo");
            colorList.Add("Violet");
            colorList.Add("Pink");
            colorList.Add("Magenta");
            colorList.Add("Crimson");
            colorList.Add("Amber");
            colorList.Add("Yellow");
            colorList.Add("Brown");
            colorList.Add("Olive");
            colorList.Add("Steel");
            colorList.Add("Mauve");
            colorList.Add("Taupe");
            colorList.Add("Sienna");

            return colorList;
        }

        private List<string> GetBGList()
        {
            List<string> bgList = new List<string>();

            bgList.Add("BaseLight");
            bgList.Add("BaseDark");

            return bgList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Farinius/MultiTool");
        }
    }
}
