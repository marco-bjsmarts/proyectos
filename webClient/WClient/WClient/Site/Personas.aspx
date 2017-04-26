<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="WClient.Site.Personas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link data-require="bootstrap-css@2.3.2" data-semver="2.3.2" rel="stylesheet" href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" />
    <script data-require="angular.js@1.1.5" data-semver="1.1.5" src="http://code.angularjs.org/1.1.5/angular.min.js"></script>
    <script data-require="angular-ui-bootstrap@0.3.0" data-semver="0.3.0" src="http://angular-ui.github.io/bootstrap/ui-bootstrap-tpls-0.3.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="grdPersonas" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
