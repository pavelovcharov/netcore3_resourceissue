using NUnit.Framework;
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

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            ResourceDictionary rd = (ResourceDictionary)Application.LoadComponent(new Uri("/WpfApp1;component/TestResource.xaml", UriKind.RelativeOrAbsolute));
        }
    }

    public class TestControl : Control {

    }

    [TestFixture]
    public class TestClass {
        [Test]
        public void Test00() {
            ResourceDictionary rd = (ResourceDictionary)Application.LoadComponent(new Uri("/WpfApp1;component/TestResource.xaml", UriKind.RelativeOrAbsolute));
            Assert.IsNotNull(rd);
        }
    }

}
