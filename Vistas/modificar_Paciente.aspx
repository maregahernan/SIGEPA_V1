<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="modificar_Paciente.aspx.cs" Inherits="SIGEPA.Vistas.modificar_Paciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
       <table>
            <tr>
                <td>Nombre y Apellido</td>
                <td>  
                    <asp:Label ID="lblNyA" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Obra Social</td>
                <td>
                    <asp:TextBox ID="TextObraSocial" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Cantidad de Sesiones</td>
                <td>
                    <asp:TextBox ID="TextCantidaSesiones" runat="server"  type="number" ></asp:TextBox>
                   
                </td>
            </tr>
            <tr>
                <td>Comienzo del Tratamiento</td>
                <td>
                    <asp:TextBox ID="FechaComi" runat="server"  placeholder="Ingrese una fecha"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fin del Tratamiento</td>
                <td>
                    <asp:TextBox ID="FechaFin" runat="server"  placeholder="Ingrese una fecha"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar"  onclick="btnModificar_Click"/>

                    <asp:Button ID="btnVolver" runat="server" Text="Cancelar"  onclick="btnVolver_Click"/>
                </td>
                
            </tr>
    </table>
</asp:Content>
