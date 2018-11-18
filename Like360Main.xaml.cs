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
using System.Windows.Shapes;

namespace _360UI
{
  /// <summary>
  /// Like360Main.xaml 的交互逻辑
  /// </summary>
  public partial class Like360Main : Window
  {
    public Like360Main()
    {
      InitializeComponent();



    }
    public void fnTest()
    {
      string txt = "世界引世界";
      string keys = "能源,技术,世界";
      string res = fn是否包含(keys, txt);
    }
    public string fn是否包含(string keys, string input)
    {
      string[] arrKey = keys.Split(',');
      foreach (string key in arrKey)
      {
        if (input.IndexOf(key) >= 0)
        {
          return "1";
        }
      }
      return "0";

    }

    private void closeButton_Click(object sender, RoutedEventArgs e)
    {
      this.Close();
    }

    private void maxButton_Click(object sender, RoutedEventArgs e)
    {
      if (WindowState == WindowState.Normal)
        WindowState = WindowState.Maximized;
      else
        WindowState = WindowState.Normal;
    }

    private void mniButton_Click(object sender, RoutedEventArgs e)
    {
      this.WindowState = WindowState.Minimized;
    }

    private void menuButton_Click(object sender, RoutedEventArgs e)
    {
      Menu.IsOpen = true;
    }

    private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
    {
      //拖动
      this.DragMove();
    }

    private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      int index = this.tab360.SelectedIndex;
      if (index == 0)
      {
        //可以设置TransitionType WpfPage 来更改界面出入的动画效果
        //this.pTransitionControl_1.TransitionType = WpfPageTransitions.PageTransitionType.SpinAndFade;
        pages.index newPage = new pages.index();
        this.pTransitionControl_1.ShowPage(newPage);

      }

      else if (index == 1)
      {
        pages.scan newPage = new pages.scan();
        this.pTransitionControl_1.ShowPage(newPage);
      }
      else if (index == 2)
      {
        pages.scan newPage = new pages.scan();
        this.pTransitionControl_1.ShowPage(newPage);
      }
      else
      {
        pages.index newPage = new pages.index();
        this.pTransitionControl_1.ShowPage(newPage);
      }
    }
  }
}