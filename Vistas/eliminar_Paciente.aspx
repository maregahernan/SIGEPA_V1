<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="eliminar_Paciente.aspx.cs" Inherits="SIGEPA.Vistas.eliminar_Paciente" %>
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
                    <asp:Label ID="lblObraSocial" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Cantidad de Sesiones</td>
                <td>
                    <asp:Label ID="lblCantSesiones" runat="server" Text=""></asp:Label>
                   
                </td>
            </tr>
            <tr>
                <td>Comienzo del Tratamiento</td>
                <td>
                    <asp:Label ID="lblComiTra" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>Fin del Tratamiento</td>
                <td>
                    <asp:Label ID="lblFinTra" runat="server" Text=""></asp:Label>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnEliminiar" runat="server" Text="Eliminar" OnClick="btnEliminiar_Click"  />

                    <asp:Button ID="btnVolver" runat="server" Text="Cancelar"  OnClick="btnVolver_Click" />
                </td>
                
            </tr>
    </table>


</asp:Content>
