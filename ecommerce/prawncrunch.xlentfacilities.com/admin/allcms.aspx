<%@ Page Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="allcms.aspx.cs" Inherits="admin_allcms" Title="Untitled Page" %>
<%@ Register Assembly="FredCK.FCKeditorV2" Namespace="FredCK.FCKeditorV2" TagPrefix="FCKeditorV2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div align="center">
                <h2>Manage CMS</h2>
               
                <table>
                    <tr>
                        <td>
                     <b>   Select Page:</b>
                        </td>
                        <td>
                            <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="v1"  Width="150"
                                AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                            <asp:ListItem Text="Select" Value="Select"> </asp:ListItem>
                            <asp:ListItem Text="farm-fresh" Value="farm-fresh"></asp:ListItem>
                            <asp:ListItem Text="cooking-prawn" Value="cooking-prawn"></asp:ListItem>
                            <asp:ListItem Text="Quality Policy" Value="fresh-crunch"></asp:ListItem>
                            <asp:ListItem Text="about-us" Value="about-us"></asp:ListItem>
                            <asp:ListItem Text="contact-us" Value="contact-us"></asp:ListItem>
                                 <asp:ListItem Text="Return-policy" Value="Return-policy"></asp:ListItem>
                            <asp:ListItem Text="Privacy-policy" Value="Privacy-policy"></asp:ListItem>
                                  <asp:ListItem Text="Terms-Conditions" Value="Terms-Conditions"></asp:ListItem>
                         
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td>
                    <b>    Content:</b>
                        </td>
                        <td>
                                 <FCKeditorV2:FCKeditor ID="FCKeditor1" runat="server" Height="400px"  BasePath="~/fckeditor/" 
                                Width="800px">
                            </FCKeditorV2:FCKeditor>
                        </td>
                    </tr>
                    <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Add" onclick="Button1_Click" CssClass="submit" />
                        <asp:Button ID="Button2" runat="server" Text="Update" onclick="Button2_Click" CssClass="submit" />
                    </td>
                    </tr>
                </table>
                
                </div>
</asp:Content>

