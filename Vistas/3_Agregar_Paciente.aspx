<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="3_Agregar_Paciente.aspx.cs" Inherits="SIGEPA.Vistas._3_Agregar_Paciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <script src="../JS/Alert_JS.js"></script>
    <script>
        function registro_OK(){
            Swal.fire(
                'Paciente Registrado!',
                'MUY BIEN!',
                'success'
            )
            
        }

        function volverInicio() {
            location.href = "1_Inicio.aspx";
        }
    </script>
    <table>
        <br />
            <tr>
                <td>Nombre y Apellido</td>
                <td>
                    <asp:TextBox ID="TextNyA" runat="server"></asp:TextBox>
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
                    <asp:TextBox ID="FechaComi" runat="server" type="date" placeholder="Ingrese una fecha"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Fin del Tratamiento</td>
                <td>
                    <asp:TextBox ID="FechaFin" runat="server" type="date" placeholder="Ingrese una fecha"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td></td>
                <td>
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar"  OnClick="btnAgregar_Click"/>

                    <asp:Button ID="btnVolver" runat="server" Text="Cancelar"  OnClick="btnVolver_Click"/>
                </td>
                
            </tr>
    </table>

</asp:Content>
