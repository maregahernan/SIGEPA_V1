<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2_Nuevo_Usuario.aspx.cs" Inherits="SIGEPA.Vistas._2_Nuevo_Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
       
    <link href="Recursos/CSS/StylesHMM.css" rel="stylesheet"/>

    <title>Nuevo Usuario</title>
</head>
<body>
 
        <div class="container">
            <form id="form1" runat="server">
              <div class ="form" >
                   <div class="titulo">
                      <h1>Sistema de pacientes</h1>
                  </div>
                  <div class="col-md-6 text-center mb-5 titulo">
                      <asp:Label class="h3" ID="lblBienvenida" runat="server" Text="Bienvenido"></asp:Label>
                      <br />
                      <asp:Label class="h3" ID="Label1" runat="server" Text="Ingresa un Nuevo Usuario"></asp:Label>
                  </div>
                  <div class="input">
                      <asp:Label ID="LabelUser" runat="server" Text="Usuario: "></asp:Label>
                      <asp:TextBox ID="TextBoxUser" MinLength=5 MaxLength=15 CssClass="form-control" runat="server" placeholder="Usuario"></asp:TextBox>
                  </div>
                  <br />
                  <div class="input">
                      <asp:Label ID="LabelPass" runat="server" Text="Password: "></asp:Label>
                      <asp:TextBox ID="TextBoxPass" MinLength=5 MaxLength=15 CssClass="form-control" TextMode="Password" runat="server" placeholder="Password" ></asp:TextBox>
                  </div>
                  <br />
                  <div class="row">
                      <asp:Label ID="lblError" CssClass="alert-danger" runat="server" ></asp:Label>
                  </div>

                  <br />
                  <div class="row">
                      <asp:Button ID="BtnIngresar" CssClass="btn btn-primary btn-dark" runat="server" Text="Registrar Nuevo Usuario" onClick="BtnIngresarNuevoUsuario" />
                  </div>
                    <br />
                  <div class="row">
                      <asp:Button ID="Volver" CssClass="btn btn-primary btn-dark" runat="server" Text="Volver" OnClick="BtnVolver" />
                  </div>
                     
              </form>
                    
               </div>
                  
         
   
</body>
</html>
