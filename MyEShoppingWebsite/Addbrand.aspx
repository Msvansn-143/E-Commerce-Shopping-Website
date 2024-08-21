<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddBrand.aspx.cs" Inherits="Addbrand" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <hr />
        <div class="container">
            <div class="form-horizontal">
                <h2>Add Brand</h2>
                <hr />
                <div class="form-group">
                    <asp:Label ID="Label1" CssClass="col-md-2 control-label" runat="server" Text="BrandName"></asp:Label>   
                    <div class="col-md-3">
                        <asp:TextBox ID="txtBrandname" CssClass="form-control" runat="server"></asp:TextBox>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorBrandName" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Brandname" ControlToValidate="txtBrandname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>

           
                

                 <div class="form-group">
                   <div class="col-md-2"></div>
                    <div class="col-md-6">
                       
                        <asp:Button ID="btnAddBrand" CssClass="btn btn-success"  runat="server" Text="Add" OnClick="btnAddBrand_Click"  />
                        
                    </div>      
                </div>

              

            </div>
            <h1>Brands</h1>
            <hr />

            <div class="panel panel-default">
                <div class="panel-heading">All Brands</div>


                <asp:Repeater ID="rptrBrands"  runat="server">

                <HeaderTemplate>
                     <table class="table">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Brand</th>
                            <th>Edit</th>
                        </tr>
                    </thead>

                    <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                     <tr>
                            <th> <%# Eval("BrandID") %></th>
                            <td> <%# Eval("Name") %> </td>
                            <td>Edit</td>
                        </tr>
                </ItemTemplate>

                <FooterTemplate>
                      </tbody>


                </table>

                </FooterTemplate>
                    </asp:Repeater>

               
                       
                  
                

            </div>



        </div>

</asp:Content>

