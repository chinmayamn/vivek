<%@ Page Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="myprofile.aspx.cs" Inherits="myprofile"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<style type="text/css">
.bold
{
font-weight:bold;
}
</style>
<div class="full mid-bg">
	<div id="cont-mid">
    	<div id="content">
			<h1 style="font:bold 14px Arial, Helvetica, sans-serif; color:#666666; margin:0 0 5px 0;">My Profile</h1>
<table class="registration">
    <tr class="light">
        <td class="bold" width="200">Name :</td>
        <td><asp:Label ID="Label1" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
   
    <tr>
        <td class="bold">Email :</td>
        <td><asp:Label ID="Label3" runat="server" ></asp:Label>
        	<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="light">
        <td class="bold">Address :</td>
        <td>
        	<asp:Label ID="Label4" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Height="66px" TextMode="MultiLine" Width="240px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="bold">LandMark :</td>
        <td><asp:Label ID="Label5" runat="server" ></asp:Label>
        	<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="light">
        <td class="bold">Mobile :</td>
        <td><asp:Label ID="Label6" runat="server" ></asp:Label>
        	<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="bold">City :</td>
        <td>
        	<asp:Label ID="Label7" runat="server" ></asp:Label>
        	
         <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Text="Select"></asp:ListItem>
        <asp:ListItem Text="Bangalore"></asp:ListItem>
        </asp:DropDownList>
        
                <asp:RequiredFieldValidator
            ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Select city" ValidationGroup="v1" ControlToValidate="DropDownList1" InitialValue="Select">*</asp:RequiredFieldValidator>

        </td>
    </tr>
     

    <tr class="light" >
        <td class="bold">State :</td>
        <td>
        	<asp:Label ID="Label8" runat="server" ></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        </td>
    </tr>
    
     <tr >
        <td></td>
        <td>
            <asp:ImageButton ID="ImageButton1" runat="server"  ImageUrl="~/images/edit.jpg" 
                onclick="ImageButton1_Click"/>
                  <asp:ImageButton ID="ImageButton2" runat="server"  ImageUrl="~/images/update.jpg" 
                onclick="ImageButton2_Click"/>
        </td>
    </tr>
</table>
</div></div>
</div>
</asp:Content>

