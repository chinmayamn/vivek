<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="news.aspx.cs" Inherits="news"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<script src="js/jquery.js" type="text/javascript">

</script>
<%--<script type="text/javascript">
    $(function() {

        $('div.title').css('cursor', 'pointer');

        $('div.contents').hide(); // Answers initially hidden
        $('div.title').click(function() {

            $("#extender").hide("normal");

            // Show answer for clicked question
            var answer = $(this).next('div.contents');
            var visible = $('div.contents:visible').not(answer); // Find another visible one
            if (visible.length) { // If there
                visible.fadeOut(function() { // Hide it
                    answer.fadeIn("slow"); // Then show the new one
                });
            }
            else {
                answer.fadeIn("slow"); // Show the new one
            }
        });



    });
</script>--%>
<div class="full mid-bg">
    	<div id="cont-mid">
        	<div id="content">
            
            
            	
                <!-- Right Navigation	-->
                <div id="right-nav1" >
                	<h1 style="background:#007CC2; width:970px; border:#888 solid 1px; -moz-border-radius:5px; border-radius:5px; line-height:29px; font-family:Arial, Helvetica, sans-serif; font-weight:bold; font-size:14px; font-style:italic; color:#fff; padding:0px 10px;">
                        News</h1>
                    
                    <asp:DataList ID="DataList1" runat="server"  RepeatDirection="Vertical">
                    <ItemTemplate>
                    <div class="title" style="font-size:12px; font-weight:bold; padding-left:10px;"><%#Eval("sub") %></div>
                  
                      <div class="contents" style="text-align: justify; padding-left:15px;">   <asp:Label ID="Label2" runat="server" Text=<%#Server.HtmlDecode( Eval("cont").ToString()) %> ></asp:Label>
                    </div>
                  <br />
                    </ItemTemplate>
                    </asp:DataList>
                    <center>
                        <asp:Label ID="Label1" runat="server" Text="News will be updated soon"></asp:Label>
                    </center>
                </div>
                <!-- End of Right Nav	-->
            
            </div>
        </div>
    </div>
</asp:Content>

