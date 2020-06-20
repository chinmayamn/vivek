<%@ Control Language="C#" AutoEventWireup="true" CodeFile="product-details.ascx.cs" Inherits="product_details" %>
   	<h1>
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></h1>
                    
                    <!-- Content about Products	-->
                    <div class="pro-details">
                    	
                        <div class="fck">
                            <asp:Label ID="Label2" runat="server" ></asp:Label>
                        </div>
                    	<div class="pro-right">
                    	<%--	<img src="images/pro1.jpg" width="235" height="198" alt="" class="det-img" />
                       --%>     <asp:Image ID="Image1" runat="server" width="235" height="198" alt="" class="det-img" />
                        </div>
                        <div class="carting">
                        	<h2>Add to Cart</h2>
                            
                            <table cellpadding="0" cellspacing="0" class="cart">
                            	<%--<tr>
                                	<td width="120"><b>Stock Available :</b></td>
                                	<td width="500">YES</td>
                                </tr>--%>
                                <tr>
                                	<td><b>Quantity :</b></td>
                                	<td>
                                    	<%--<select class="list-drop">
                                        	<option>1 KG</option>
                                        	<option>2 KG</option>
                                        	<option>3 KG</option>
                                        	<option>4 KG</option>
                                        	<option>5 KG</option>
                                        	<option>6 KG</option>
                                        	<option>7 KG</option>
                                        	<option>8 KG</option>
                                        	<option>9 KG</option>
                                        	<option>10 KG</option>
                                        	
                                        </select>--%>
                                        
                                        <asp:DropDownList ID="DropDownList1" runat="server">
                                        <asp:ListItem>1</asp:ListItem>
                                         <asp:ListItem>2</asp:ListItem>
                                          <asp:ListItem>3</asp:ListItem>
                                           <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                             <asp:ListItem>6</asp:ListItem>
                                              <asp:ListItem>7</asp:ListItem>
                                              <asp:ListItem>8</asp:ListItem>
                                             
                                              <asp:ListItem>9</asp:ListItem>
                                              <asp:ListItem>10</asp:ListItem>
                                     
                                        </asp:DropDownList>KG
                                    </td>
                                </tr>
                                <tr>
                                	<td><b>Price :</b></td>
                                	<td>Rs.<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                                        /-</td>
                                </tr>
                                <tr>
                                	<td><b>Select Place :</b></td>
                                	<td>
                                    	<select class="list-drop">
                                        	<option>Bangalore</option>
                                        	<option>Mumbai</option>
                                        	<option>Chennai</option>
                                        </select>
                                    	<select class="list-drop">
                                        	<option>Malleshwaram</option>
                                        	<option>BTM</option>
                                        	<option>Jayanagar</option>
                                        </select>
                                    </td>
                                </tr>
                                <tr>
                                	<td colspan="3"><%--<a href="#" title="Add to Cart" class="add">Add to Cart</a>--%>
                                        <asp:Button ID="Button1" runat="server" Text="Add to Cart" 
                                            onclick="Button1_Click" />
                                	</td>
                                </tr>	
                            </table>
                             
                        </div>
                    </div>
                    <!-- End of Content About Products	-->