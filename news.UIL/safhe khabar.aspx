<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="safhe khabar.aspx.cs" Inherits="news.UIL.safhe_khabar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="https://code.jquery.com/jquery-3.5.1.min.js" integrity="sha256-9/aliU8dGd2tb6OSsuzixeV4y/faTqgFtohetphbbj0=" crossorigin="anonymous"></script>
        <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
        <script src="script/bootstrap/bootstrap.min.js"></script>
        <script src="script/jquery-3.6.0.min.js"></script>
        <link href="style/bootstrap css/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>

<style>
table.GeneratedTable {
  width: 100%;
  background-color: #ffffff;
  border-collapse: collapse;
  border-width: 2px;
  border-color: #ffcc00;
  border-style: solid;
  color: #000000;
}

table.GeneratedTable td, table.GeneratedTable th {
  border-width: 2px;
  border-color: #ffcc00;
  border-style: solid;
  padding: 3px;
}

table.GeneratedTable thead {
  background-color: #ceb450;
}
</style>

<table class="GeneratedTable"  >
  <thead>
    <tr style="text-align:right">
      <th class="col-lg-9" >متن</th>
      <th class="col-lg-2">عنوان</th>
      <th class="col-lg-1">شماره</th>
    </tr>
  </thead>
  <tbody>
    <tr style="text-align:right">
      <td><asp:textbox runat="server" ID="newsid"> </asp:textbox> </td>
      <td><asp:textbox runat="server" ID="title"> </asp:textbox></td>
      <td><asp:textbox runat="server" ID="textbox"> </asp:textbox></td>
    </tr>
    
  </tbody>
</table>
            <asp:Button runat="server" ID="nextbuttom" text="بعدی" OnClick="nextbuttom_click"/>
            

        </div>
    </form>
</body>
</html>
