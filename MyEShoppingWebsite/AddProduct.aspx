<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMasterPage.master" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="container">
        <div class="form-horizontal">
         <br />
            <br />
            <hr />
            <h2>Add Products</h2>
            <hr />

            <div class ="form-group">
                <asp:Label ID="Label1" runat="server" CssClass="col-md-2 control-label" Text="Product Name"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtProductName" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
           </div>
           
            <div class ="form-group">
             <asp:Label ID="Label2" runat="server" CssClass="col-md-2 control-label" Text="Price"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtPrice" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
         
            <div class ="form-group">
                <asp:Label ID="Label3" runat="server" CssClass="col-md-2 control-label" Text="SellingPrice"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtSellPrice" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            
             <div class="form-group">
               
                <asp:Label ID="Label4" runat="server" CssClass="col-md-2 control-label"  Text="Brand"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlBrand" CssClass="form-control" runat="server"></asp:DropDownList>
                </div>
            </div>

            
            <div class="form-group">
               
                <asp:Label ID="Label5" runat="server" CssClass="col-md-2 control-label"  Text="Category"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlCategory" AutoPostBack="true" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
            
             <div class="form-group">
               
                <asp:Label ID="Label6" runat="server" CssClass="col-md-2 control-label"  Text="SubCategory"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlSubCategory" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSubCategory_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
            
             <div class="form-group">
               
                <asp:Label ID="Label19" runat="server" CssClass="col-md-2 control-label"  Text="Gender"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlGender" CssClass="form-control"  runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlGender_SelectedIndexChanged"></asp:DropDownList>
                </div>
            </div>
            
             <div class="form-group">
                <asp:Label ID="Label7" runat="server" CssClass="col-md-2 control-label" Text="Size"></asp:Label>
                <div class="col-md-3">
                    <asp:CheckBoxList ID="CblSize" CssClass="form-control" RepeatDirection="Horizontal" runat="server"></asp:CheckBoxList>
                </div>
            </div>

           <div class ="form-group">
                <asp:Label ID="Label20" runat="server" CssClass="col-md-2 control-label" Text="Quantity"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtQuantity" type="number"  CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>

          <!--         <div class="form-group">
               
                <asp:Label ID="Label22" runat="server" CssClass="col-md-2 control-label"  Text="Quantity"></asp:Label>
                <div class="col-md-3">
                    <asp:DropDownList ID="ddlQuantity" ItemType="number" CssClass="form-control" runat="server">
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>-->



            
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" CssClass="col-md-2 control-label" Text="Description"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtDescription" TextMode="MultiLine" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>

           
           
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" CssClass="col-md-2 control-label" Text="Product Details"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtPDetail" TextMode="MultiLine"  CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
            
            
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" CssClass="col-md-2 control-label" Text="Materials and Care"></asp:Label>
                <div class="col-md-3">
                    <asp:TextBox ID="txtMatCare" TextMode="MultiLine"  CssClass="form-control" runat="server"></asp:TextBox>
                </div>
            </div>
          
         
              <div class="form-group">
                <asp:Label ID="Label11" runat="server" CssClass="col-md-2 control-label" Text="Upload Image"></asp:Label>
                <div class="col-md-3">
                    <asp:FileUpload ID="FuImg01" CssClass="control-label" runat="server" />
                </div>
          </div>
        
             <div class="form-group">
                <asp:Label ID="Label12" runat="server" CssClass="col-md-2 control-label" Text="Upload Image"></asp:Label>
                <div class="col-md-3">
                    <asp:FileUpload ID="FuImg02" CssClass="control-label" runat="server" />
                </div>
            </div>
          
               <div class="form-group">
                <asp:Label ID="Label13" runat="server" CssClass="col-md-2 control-label" Text="Upload Image"></asp:Label>
                <div class="col-md-3">
                    <asp:FileUpload ID="FuImg03" CssClass="control-label" runat="server" />
                </div>
            </div>
         
             <div class="form-group">
                <asp:Label ID="Label14" runat="server" CssClass="col-md-2 control-label" Text="Upload Image"></asp:Label>
                <div class="col-md-3">
                   <asp:FileUpload ID="FuImg04" CssClass="control-label" runat="server" />
                </div>
            </div>
           
             <div class="form-group">
                <asp:Label ID="Label15" runat="server" CssClass="col-md-2 control-label" Text="Upload Image"></asp:Label>
                <div class="col-md-3">
                   <asp:FileUpload ID="FuImg05" CssClass="control-label" runat="server" />
                </div>
            </div>
          
             <div class="form-group">
                <asp:Label ID="Label16" runat="server" CssClass="col-md-2 control-label" Text="Free Delivery"></asp:Label>
                <div class="col-md-3">
                    <asp:CheckBox ID="chFD" runat="server" />
                </div>
            </div>

             
             <div class="form-group">
                <asp:Label ID="Label17" runat="server" CssClass="col-md-2 control-label" Text="30 Days Return"></asp:Label>
                <div class="col-md-3">
                    <asp:CheckBox ID="ch30Ret" runat="server" />
                </div>
            </div>

              
             <div class="form-group">
                <asp:Label ID="Label18" runat="server" CssClass="col-md-2 control-label" Text="COD"></asp:Label>
                <div class="col-md-3">
                    <asp:CheckBox ID="cbCOD" runat="server" />
                </div>
            </div>
            <br />
              <div class="form-group">
                   <div class="col-md-2"></div>
                    <div class="col-md-6">
                       
                        <asp:Button ID="btnAdd" CssClass="btn btn-success"  runat="server" Text="Add Product" OnClick="btnAdd_Click"  />
                      
                    </div>      
                </div>

        </div>
        
    </div>
</asp:Content>

