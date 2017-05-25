<%@ Page language="c#" Codebehind="index.aspx.cs" AutoEventWireup="false" Inherits="CSharpGoogleMaps.index" %>
<%@ Register TagPrefix="CSharpGoogleMaps" Namespace="CSharpGoogleMaps" Assembly="CSharpGoogleMaps"%>
<%@ Register TagPrefix="Maps" Namespace="Maps" Assembly="Maps"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html>
	<head>
		<title>Google Maps in C#</title>
		<CSharpGoogleMaps:Html id="header" runat="server" />
	</head>
	<body>
		<Maps:MapControl id="mapControl" containerId="map" width="600" height="350" runat="server" />
		<CSharpGoogleMaps:Html id="footer" runat="server" />
	</body>
</html>
