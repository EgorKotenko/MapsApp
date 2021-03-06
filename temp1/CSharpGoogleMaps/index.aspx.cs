using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Configuration;

using Maps;
using Utility;
using HtmlUtil = Utility.Html;

namespace CSharpGoogleMaps
{
	/// <summary>
	/// Summary description for index.
	/// </summary>
	public class index : System.Web.UI.Page
	{
		protected Html header;
		protected Maps.MapControl mapControl;
		protected Html footer;

		private void Page_Init(object sender, System.EventArgs e)
		{
			header.Add(HtmlUtil.htjs("/CSharpGoogleMaps/js/prototype.js"));
			header.Add(HtmlUtil.htjs("/CSharpGoogleMaps/js/map-ext.js"));
			header.Add(HtmlUtil.htjs("http://maps.google.com/maps?file=api&v=2&key=" + ConfigurationSettings.AppSettings["google_maps_key"]));

			Map map = mapControl.map;

			for(float i=30; i<40; i++) {
				for(float j=-90; j>-100; j--) {
					Marker m = new Marker(new LatLng((float)i, (float)j));
					map.addOverlay(m);
				}
			}

			footer.Add(mapControl.GetJavascript());
		}

		private void Page_Load(object sender, System.EventArgs e)
		{
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Init += new System.EventHandler(this.Page_Init);
			this.Load += new System.EventHandler(this.Page_Load);
		}
		#endregion
	}
}
