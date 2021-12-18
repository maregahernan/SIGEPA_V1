<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SIGEPA.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <link href="Recursos/CSS/StylesHMM.css" rel="stylesheet"/>
   
    <title></title>
</head>
<body >
    
    <div class="container">
            <form id="form1" runat="server">
              <div class ="form"  >
                  <div class="titulo">
                      <h1>Sistema de pacientes</h1>
                  </div>
                  <div class="col-md-6 text-center mb-5 titulo1">
                      <asp:Label class="h3" ID="lblBienvenida" runat="server" Text="Bienvenido"></asp:Label>
                 
                      <asp:Label class="h3" ID="Label1"  runat="server" Text="Ingresa tus Credenciales"></asp:Label>
                  </div>
                  <div class="input">
                      <asp:Label ID="LabelUser" runat="server" Text="Usuario: "></asp:Label>
                      <asp:TextBox ID="TextBoxUser" CssClass="form-control" runat="server" placeholder="Usuario"></asp:TextBox>
                  </div>
                  <br />
                  <div class="input">
                      <asp:Label ID="LabelPass" runat="server" Text="Password: "></asp:Label>
                      <asp:TextBox ID="TextBoxPass" CssClass="form-control" TextMode="Password" runat="server" placeholder="Password" ></asp:TextBox>
                  </div>
                  <br />
                  <div class="row">
                      <asp:Label ID="lblError" CssClass="alert-danger" runat="server" ></asp:Label>
                  </div>
                  <br />
                  <div class="row">
                      <asp:Button ID="BtnIngresar"  runat="server" Text="Ingresar" OnClick="BtnIngresar_Click" />
                  </div>
                    <br />
                  <div class="row">
                      <asp:Button ID="BtnNuevoUser" CssClass="btn btn-primary btn-dark" runat="server" Text="Nuevo Usuario" onclick="BtnNuevoUsuario" />
                  </div>
              </div>
              </form>
       
    </div>
    
</body>
</html>

