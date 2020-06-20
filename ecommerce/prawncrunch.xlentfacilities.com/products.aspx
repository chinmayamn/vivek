<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="products.aspx.cs" Inherits="products"  %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            <div class="main-left">
            	<!-- Latest News	-->
                <div id="lat-news">
                	<h1 class="heading">Latest News</h1>
                    <ul class="news">
                    <asp:DataList ID="DataList2" runat="server">
                        <ItemTemplate>
                        
                       
                        <li>
                            <asp:Label ID="Label5" runat="server" Text=<%#Eval("sub") %>></asp:Label>
                            
                            </li> </ItemTemplate>
                        </asp:DataList>
                   
                             	</ul>
                    <a href="news.aspx" title="Read More" class="more">Read More</a>
                </div>
                <!-- End of Latest News	-->
            	<div id="lat-news">
                	<h1 class="heading">Discounts</h1>
					<ul class="spe-list">
                    	<li>0-5 days no discount</li>
						<li>5-10 days 5%</li>
						<li>10-20 days 7%</li>
						<li>21-32 days 10%</li>
						<li>above 31 days 10%</li>
                    </ul>
                </div>
                
                <img src="images/guarantee.gif" width="100%" alt=""  />
                
                </div>
                
                <!-- Right Navigation	-->
                <div id="right-nav">
                	<h1>
                        <asp:Label ID="Label2" runat="server"></asp:Label></h1>
                    
                    <div id="pros">
                        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                            <ItemTemplate>
                                <div class="pro">
                                         <a href="product-details.aspx?id=<%#Eval("id") %>" title="">
                                             <asp:Image ID="Image1" runat="server"  ImageUrl=<%#Eval("pimage") %>/>
                                          
                                        </a>
                                 </div>
                                   <h2><%#Eval("pname") %></h2>
                            </ItemTemplate>
                        </asp:DataList>
                        <asp:Label ID="Label1" runat="server" Text="Products for this category will be updated soon"></asp:Label>
                   <%-- 	<div class="pro">
                            <a href="product-details.html" title="">
                                <img src="images/pro1.jpg" alt="" />
                                <h2>Product Name</h2>
                            </a>
                        </div>
                    	<div class="pro">
                            <a href="product-details.html" title="">
                                <img src="images/pro1.jpg" alt="" />
                                <h2>Product Name</h2>
                            </a>
                        </div>
                    	<div class="pro">
                            <a href="product-details.html" title="">
                                <img src="images/pro1.jpg" alt="" />
                                <h2>Product Name</h2>
                            </a>
                        </div>
                    	<div class="pro">
                            <a href="product-details.html" title="">
                                <img src="images/pro1.jpg" alt="" />
                                <h2>Product Name</h2>
                            </a>
                        </div>
                    	<div class="pro">
                            <a href="product-details.html" title="">
                                <img src="images/pro1.jpg" alt="" />
                                <h2>Product Name</h2>
                            </a>
                        </div>--%>
                    </div>
                    
                </div>
                <!-- End of Right Nav	-->
            
            </div>
        </div>
    </div>
</asp:Content>

