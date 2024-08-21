<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddSubCategoryaspx.aspx.cs" Inherits="AddSubCategoryaspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <hr />
    <br />
        <div class="container">
            <div class="form-horizontal">
                <h2>Add SubCategory</h2>
                <hr />

                 <div class="form-group">
                    <asp:Label ID="Label2" CssClass="col-md-2 control-label" runat="server" Text="Main CategoryID"></asp:Label>   
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlMainCatID" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorMainCatID" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Main CategoryID" ControlToValidate="ddlMainCatID" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>





                <div class="form-group">
                    <asp:Label ID="Label1" CssClass="col-md-2 control-label" runat="server" Text="SubCategoryName"></asp:Label>   
                    <div class="col-md-3">
                        <asp:TextBox ID="txtSubCategoryname" CssClass="form-control" runat="server"></asp:TextBox>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSubCategoryName" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter SubCategoryname" ControlToValidate="txtSubCategoryname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>

           
                

                 <div class="form-group">
                   <div class="col-md-2"></div>
                    <div class="col-md-6">
                       
                        <asp:Button ID="btnSubAddCategory" CssClass="btn btn-success"  runat="server" Text="Add SubCategory" OnClick="btnSubAddCategory_Click"  />
                        
                    </div>      
                </div>

              

            </div>

              <h1>SubCategories</h1>
            <hr />

            <div class="panel panel-default">
                <div class="panel-heading">All SubCategories</div>


                <asp:Repeater ID="rptrSubCategories"  runat="server">

                <HeaderTemplate>
                     <table class="table">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Sub-Categories</th>
                            <th>Main-Category</th>
                            <th>Edit</th>

                        </tr>
                    </thead>

                    <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                     <tr>
                            <th> <%# Eval("SubCatID") %></th>
                            <td> <%# Eval("SubCatName") %> </td>
                            <td> <%# Eval("CatName") %> </td>
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

