<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddSize.aspx.cs" Inherits="AddSize" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <hr />
        <div class="container">
            <div class="form-horizontal">
                <h2>Add Size</h2>
                <hr />
                <div class="form-group">
                    <asp:Label ID="Label1" CssClass="col-md-2 control-label" runat="server" Text="Size"></asp:Label>   
                    <div class="col-md-3">
                        <asp:TextBox ID="txtSize" CssClass="form-control" runat="server"></asp:TextBox>  
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSize" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Size" ControlToValidate="txtSize" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>


                 <div class="form-group">
                    <asp:Label ID="Label2" CssClass="col-md-2 control-label" runat="server" Text="Brand"></asp:Label>   
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlBrand" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorddlBrand" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Brand" ControlToValidate="ddlBrand" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>

                 <div class="form-group">
                    <asp:Label ID="Label3" CssClass="col-md-2 control-label" runat="server" Text="Category"></asp:Label>   
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlCategory" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorddlCategory" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter  Category" ControlToValidate="ddlCategory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>


                 <div class="form-group">
                    <asp:Label ID="Label4" CssClass="col-md-2 control-label" runat="server" Text="Sub Category"></asp:Label>   
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlSubCategory" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSubCategory" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Sub Category" ControlToValidate="ddlSubCategory" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>


                 <div class="form-group">
                    <asp:Label ID="Label5" CssClass="col-md-2 control-label" runat="server" Text="Gender"></asp:Label>   
                    <div class="col-md-3">
                        <asp:DropDownList ID="ddlGender" CssClass="form-control" runat="server"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorddlGender" runat="server" CssClass="text-danger" ErrorMessage=" Please Enter Gender" ControlToValidate="ddlGender" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>      
                </div>





           
                

                 <div class="form-group">
                   <div class="col-md-2"></div>
                    <div class="col-md-6">
                       
                        <asp:Button ID="btnAddSize" CssClass="btn btn-success"  runat="server" Text="Add Size" OnClick="btnAddSize_Click"    />
                        
                    </div>      
                </div>

              

            </div>

            
             <h1>Sizes</h1>
            <hr />

            <div class="panel panel-default">
                <div class="panel-heading">All Sizes</div>


                <asp:Repeater ID="rptrSize"  runat="server">

                <HeaderTemplate>
                     <table class="table">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Size</th>
                            <th>Brand</th>
                            <th>Category</th>
                            <th>SubCategory</th>
                            <th>Gender</th>
                            <th>Edit</th>
                        </tr>
                    </thead>

                    <tbody>
                </HeaderTemplate>

                <ItemTemplate>
                     <tr>
                            <th> <%# Eval("SizeID") %></th>
                            <td> <%# Eval("SizeName") %> </td>
                              <td> <%# Eval("Name") %> </td>
                              <td> <%# Eval("CatName") %> </td>
                          <td> <%# Eval("SubCatName") %> </td>
                          <td> <%# Eval("GenderName") %> </td>
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

