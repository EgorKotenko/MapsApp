using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Collections;

using Utility;

namespace CSharpGoogleMaps
{

	public class Html : System.Web.UI.WebControls.WebControl
	{
		public ArrayList html = new ArrayList();

		public void Add(ArrayList lst) {
			html.AddRange(lst);
		}

		public void Add(string str) {
			html.Add(str);
		}

		protected override void Render(HtmlTextWriter output)
		{
			output.Write(Util.implode(html, "\n"));
		}
	}
}
