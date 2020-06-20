<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="product-details.aspx.cs" Inherits="product_details"  %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script type="text/javascript" src="js/jquery.js"></script>

<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
                
            	<!-- Latest News	-->
                <div id="lat-news">
                	<h1 class="heading">Latest News</h1>
                    <ul class="news">
                        <asp:DataList ID="DataList1" runat="server">
                        <ItemTemplate>
                        
                       
                        <li>
                            <asp:Label ID="Label5" runat="server" Text=<%#Eval("sub") %>></asp:Label>
                            
                            </li> </ItemTemplate>
                        </asp:DataList>
                 	</ul>
                    <a href="news.aspx" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Latest News	-->
            	
                <!-- Right Navigation	-->
                <div id="right-nav">
                	<h1>
                       <a id="a1" runat="server"> 
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="White" 
                            Font-Size="Larger" ></asp:Label>
                      </a>
                        <asp:Label ID="Label4" runat="server" ></asp:Label>
                        </h1>
                    
                    <!-- Content about Products	-->
                    <div class="pro-details">
                    	
                        <div class="fck">
                            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                        </div>
                    	<div class="pro-right">
                    		<%--<img src="images/pro1.jpg" width="235" height="198" alt="" class="det-img" />
                          --%>  <asp:Image ID="Image1"   runat="server" width="235" height="198" alt="" class="det-img" />
                       </div>
                        <div class="carting">
                        	<h2>Add to Cart - 
                                <asp:Label ID="Label7" runat="server" ></asp:Label></h2>
                            
                            <table cellpadding="0" cellspacing="0" class="cart">
                            	<tr>
                                	<td><b>Select City :</b></td>
                                	<td>
                                    	<%--<select class="list-drop">
                                        	<option>Bangalore</option>
                                        	<option>Mumbai</option>
                                        	<option>Chennai</option>
                                        </select>--%>
                                        <table>
                                        <tr>
                                            <td>
                                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                        <ContentTemplate>
                                        
                                    
                                        <asp:DropDownList ID="DropDownList1" runat="server"  class="list-drop" 
                                            AutoPostBack="True" 
                                         
                                            ValidationGroup="v1" 
                                                onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                                            <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                                            <asp:ListItem Text="Bangalore" Value="Bangalore"></asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                                            ErrorMessage="Select City" InitialValue="Select" ValidationGroup="v1" 
                                            ControlToValidate="DropDownList1">*</asp:RequiredFieldValidator>
                                       
                                           </ContentTemplate>
                                        </asp:UpdatePanel>
                                            </td>
                                       
                                        </tr>
                                        </table>
                                    
                                        
                                       
                                    	<%--<select class="list-drop">
                                        	<option>Malleshwaram</option>
                                        	<option>BTM</option>
                                        	<option>Jayanagar</option>
                                        </select>--%>
                                    </td>
                                </tr>
                                <tr>
                                	<td><b>Quantity :</b></td>
                                	<td>
                                    	<%--<select class="list-drop">
                                        	<option>1 KG</option>
                                        	<option>2 KG</option>
                                        	<option>3 KG</option>
                                        	<option>4 KG</option>
                                        </select>--%>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                                            ErrorMessage="Quantity required" ValidationGroup="v1" 
                                            ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
                                            
                                            
                                            
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                                            ErrorMessage="Invalid quantity" ValidationExpression="^\d+$" 
                                            ValidationGroup="v1" ControlToValidate="TextBox1">*</asp:RegularExpressionValidator>
                                    </td>
                                </tr>
                                <tr>
                                	<td><b>Price/ Kg. :</b></td>
                                	<td>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                         <ContentTemplate>
                                         
                                         
                                        
                                        <asp:Label ID="Label3" runat="server" ></asp:Label>
                                         </ContentTemplate>
                                        </asp:UpdatePanel>
                                        
                                        </td>
                                </tr>
                                
                                <tr>
                                	<td colspan="2">
                                	<%--<a href="#" title="Add to Cart" class="add">Add to Cart</a>--%>
                                	<div id="temp">
                                        <asp:Button ID="Button1" runat="server" Text="Add to Cart" class="add" 
                                            ValidationGroup="v1" onclick="Button1_Click"/><br />
                                            
                                      <b>  <asp:Label ID="Label6" runat="server" Text="Product currently unavailable"></asp:Label></b>
                                            </div>
                                	</td>
                                </tr>
                                <tr>
                                <td colspan="2">
                                <b>Note:</b>
                                <ol>
                                <li>
                                Delivery charges extra. Exact charges will be charged at the time of delivery. For first 2 Km free, there afterwards 3 Rs/Km.
                              
                                </li>
                                <li>
                              Discount option will be provided at the last stage of checkout.

                                </li>
                                </ol>
                               
                                </td>
                                </tr>	
                                <tr>
                                	<td colspan="2">
                                	    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
                                            ShowMessageBox="True" ShowSummary="False" ValidationGroup="v1" />
                                	</td>
                                </tr>	
                            </table>
                             
                        </div>
                    </div>
                    <!-- End of Content About Products	-->
                    
                    
                </div>
                <!-- End of Right Nav	-->
            
            </div>
        </div>
    </div>
</asp:Content>

