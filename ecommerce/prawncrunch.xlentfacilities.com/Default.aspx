<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link type="text/css" href="date/jquery-ui-1.7.2.custom.css" rel="stylesheet" />
	<script type="text/javascript" src="date/jquery-1.3.2.js"></script>
	<script type="text/javascript" src="date/ui.core.js"></script>
	<script type="text/javascript" src="date/ui.datepicker.js"></script>
	<link type="text/css" href="date/demos.css" rel="stylesheet" />
	<script type="text/javascript">
	$(function() {
		$('#datepicker').datepicker({
			changeMonth: true,
			changeYear: true
		});
	});
	</script>
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="datepicker" runat="server"></asp:TextBox>
    </div>
    </form>
</body>
</html>
