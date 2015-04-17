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
using Perspex.Editor.Document;
using System.IO;

namespace Prototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       private TextDocument Document { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            using (var fs = new System.IO.FileStream("c:\\main.cpp", System.IO.FileMode.Open, System.IO.FileAccess.Read, FileShare.Read))
            {
                using (var sr = new System.IO.StreamReader(fs))
                {
                   Document = new TextDocument(sr.ReadToEnd());
                }
            }            
        }
    }
}
