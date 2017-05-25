using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows;
using Maps;
using MapsJavascript;

namespace temp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MapControl mapControl = new MapControl();

            Map map = mapControl.map;

            for (float i = 30; i < 40; i++)
            {
                for (float j = -90; j > -100; j--)
                {
                    Marker m = new Marker(new LatLng((float)i, (float)j));
                    m.addInfoWindowTab(new InfoWindowTab("Profile", "My name is Peter.\n" +
                            "I am 23 years old."));
                    m.addInfoWindowTab(new InfoWindowTab("Location", "I live in the United States."));
                    map.addOverlay(m);
                }
            }

            JavascriptFactory fact = JavascriptFactory.create();

            Utility.Html h = new Utility.Html();            
            //h.Add(mapControl.GetJavascript());
    
    /*        HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0];
            HtmlElement scriptEl = webBrowser1.Document.CreateElement("script");
IHTMLScriptElement element = (IHTMLScriptElement)scriptEl.DomElement;
element.text = "function sayHello() { alert('hello') }";
head.AppendChild(scriptEl);
webBrowser1.Document.InvokeScript("sayHello");
      */
           // HtmlDo
            webBrowser1.Document;
        }
    }
}
