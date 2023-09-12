<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="CSharpASP_MVC.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<table class="table">
  <thead>
    <tr>
      <th scope="col">#</th>
      <th scope="col">First</th>
      <th scope="col">Last</th>
      <th scope="col">Handle</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th scope="row" style="height: 31px">1</th>
      <td style="height: 31px">Mark</td>
      <td style="height: 31px">Otto</td>
      <td style="height: 31px">@mdo</td>
    </tr>
    <tr>
      <th scope="row">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>@fat</td>
    </tr>
    <tr>
      <th scope="row">3</th>
      <td colspan="2">Larry the Bird</td>
      <td>@twitter</td>
    </tr>
  </tbody>
</table>
    <asp:GridView ID="gridViewProductList" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID">
            <HeaderStyle Width="50px" />
            </asp:BoundField>
            <asp:BoundField DataField="productName" HeaderText="Name" >
            <HeaderStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="productDescription" HeaderText="Description" >
            <HeaderStyle Width="100px" />
            </asp:BoundField>
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("productImage") %>' />
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="price" HeaderText="Price" >
            <HeaderStyle Width="50px" />
            </asp:BoundField>
        </Columns>
    </asp:GridView>
</asp:Content>

