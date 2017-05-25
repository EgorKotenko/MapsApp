using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Maps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            strPlace.Text = "";
            strTo.Text = "";
            strFrom.Text = "";
            browser.DocumentText = "<html><head><script src=\"http://maps.google.com/maps?file=api&v=2&key=ABQIAAAA9YKPhzOjdbEVOCFTSVq05xToMEnqC92VGeHFeJcD-XHURsJQqhQ5T9KapBFpl4ltMOeNIl0slIfSug\" type=\"text/javascript\"></script></head><body bgcolor=\"Lavender\"> <div id=\"map_canvas\" style=\"width: 465px; height: 360px\"><script type=\"text/javascript\"> var map = new GMap2(document.getElementById(\"map_canvas\")); map.enableDoubleClickZoom(); map.enableScrollWheelZoom(); map.enableContinuousZoom(); map.setCenter(new GLatLng(59.933688,30.300206), 10); map.addControl(new GMapTypeControl()); </script> </div></body></html>";
            strPlace.Focus();
        }

        private void placeSearchButton_Click(object sender, EventArgs e)
        {
            searchMode = true;
            turnSearchModeOn();          
        }

        private void routeButton_Click(object sender, EventArgs e)
        {
            searchMode = false;
            turnRouteModeOn();
        }

        private void enterEvent()
        {
            if (searchMode)
            {
                if (strPlace.Text != "")
                {
                    try
                    {
                        String x = analyser.GetLongitude(strPlace.Text);
                        String y = analyser.GetLatitude(strPlace.Text);
                        showPlace(x, y);
                    }
                    catch (SystemException)
                    {
                        errorPanel.Visible = true;
                        errorOKbutton.Focus();
                    }
                }
            }
            else
            {
                if (strFrom.Text != "" && strFrom.Text != "")
                {
                    try
                    {
                        String x1 = analyser.GetLongitude(strFrom.Text);
                        String y1 = analyser.GetLatitude(strFrom.Text);
                        String x2 = analyser.GetLongitude(strTo.Text);
                        String y2 = analyser.GetLatitude(strTo.Text);
                        showRoute(x1, y1, x2, y2);
                    }
                    catch (SystemException)
                    {
                        errorPanel.Visible = true;
                        errorOKbutton.Focus();
                    }
                }
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            enterEvent();
        }
        
        private void turnSearchModeOn()
        {
            errorPanel.Visible = false;
            strTo.Visible = false;
            strFrom.Visible = false;
            labelFrom.Visible = false;
            labelTo.Visible = false;
            strPlace.Visible = true;
            labelPlace.Visible = true;
            strPlace.Focus();
        }

        private void turnRouteModeOn()
        {
            errorPanel.Visible = false;
            strPlace.Visible = false;
            labelPlace.Visible = false;
            strTo.Visible = true;
            strFrom.Visible = true;
            labelFrom.Visible = true;
            labelTo.Visible = true;
            strFrom.Focus();
        }

        private void showPlace(String x, String y) 
        {
            browser.DocumentText = "<html><head><script src=\"http://maps.google.com/maps?file=api&v=2&key=ABQIAAAA9YKPhzOjdbEVOCFTSVq05xToMEnqC92VGeHFeJcD-XHURsJQqhQ5T9KapBFpl4ltMOeNIl0slIfSug\" type=\"text/javascript\"></script></head><body bgcolor=\"Lavender\"><div id=\"map_canvas\" style=\"width: 465px; height: 360px\"><script type=\"text/javascript\"> var map = new GMap2(document.getElementById(\"map_canvas\"));  map.enableDoubleClickZoom(); map.enableContinuousZoom(); map.enableScrollWheelZoom(); map.setCenter(new GLatLng(59.933688,30.300206), 10); map.addControl(new GMapTypeControl()); var point1 = new GLatLng(" + x + "," + y + "); var marker1 = new GMarker(point1); map.addOverlay(marker1); </script> </div></body></html>";   
        }

        private void showRoute(String x1, String y1, String x2, String y2)
        {
            browser.DocumentText = "<html><head><script src=\"http://maps.google.com/maps?file=api&v=2&key=ABQIAAAA9YKPhzOjdbEVOCFTSVq05xToMEnqC92VGeHFeJcD-XHURsJQqhQ5T9KapBFpl4ltMOeNIl0slIfSug\" type=\"text/javascript\"></script></head><body bgcolor=\"Lavender\"><div id=\"map_canvas\" style=\"width: 465px; height: 360px\"><script type=\"text/javascript\"> var map = new GMap2(document.getElementById(\"map_canvas\"));  map.enableDoubleClickZoom(); map.enableContinuousZoom(); map.enableScrollWheelZoom(); map.setCenter(new GLatLng(59.933688,30.300206), 10); map.addControl(new GMapTypeControl()); var point1 = new GLatLng(" + x1 + "," + y1 + "); var marker1 = new GMarker(point1); map.addOverlay(marker1); var point2 = new GLatLng(" + x2 + "," + y2 + "); var marker2 = new GMarker(point2); map.addOverlay(marker2); </script> </div></body></html>";
        }

        private Boolean searchMode = true;
        private Analyser analyser = new Analyser();

        private void errorOKbutton_Click_1(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
            strPlace.Focus();
            strTo.Focus();
        }

        private void strPlace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterEvent();
            }
            
        }

        /*private void strFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterEvent();
            }

        }

        private void strTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                enterEvent();
            }

        }*/
    }
}

