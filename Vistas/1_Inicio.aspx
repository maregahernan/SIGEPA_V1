<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="1_Inicio.aspx.cs" Inherits="SIGEPA._1_Inicio" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:GridView ID="GridPacientes" AutoGenerateColumns="false" runat="server" OnRowCommand="GridPacientes_RowCommand">
        <Columns>

            <asp:TemplateField HeaderText="Editar"  >
                  <ItemTemplate >
                      <asp:ImageButton CausesValidation="false"  ID="btnEdit"  runat="server" ImageUrl="\Imagenes\editar.png" height="25px" Width="25px" 
                          CommandName="Editar" CommandArgument='<%# Eval("Nombre_Apellido") %>'/>
                  </ItemTemplate>
              </asp:TemplateField>

            <asp:TemplateField HeaderText="Eliminar" >
                  <ItemTemplate>
                      <asp:ImageButton CausesValidation="false" ID="btnDelete" runat="server"  ImageUrl="\Imagenes\delete.png" height="25px" Width="25px" 
                          CommandName="Eliminar" CommandArgument='<%# Eval("Nombre_Apellido") %>'/>
                  </ItemTemplate>
            </asp:TemplateField>


              <asp:BoundField ItemStyle-Width="200px" HeaderText="Nombre y Apellido" DataField="Nombre_Apellido"/>
              <asp:BoundField ItemStyle-Width="200px" HeaderText="Obra Social" DataField="Obra_Social" />
              <asp:BoundField ItemStyle-Width="200px" HeaderText="Cantidad de Sesiones" DataField="Cant_de_seciones"/>
              <asp:BoundField ItemStyle-Width="200px" HeaderText="Comienzo del Tratamiento" DataField="Fecha_Comienzo"/>
              <asp:BoundField ItemStyle-Width="200px" HeaderText="Fin del Tratamiento" DataField="Fecha_Fin"/>
        </Columns>
    </asp:GridView>
</asp:Content>
