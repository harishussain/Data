<html>
<head>
<title> login </title>
</head>
<body>

<form method="POST" action = "logincheck.php">
<table border="1">
<tr><td colspan="2" >Login</td> </tr>
<tr> <td align="right"></td><td>user: <input type="text" name="username"/></td></tr>
<tr> <td align="right"></td><td>user: <input type="password" name="userpass"/></td></tr>
<tr><td align="center" colspan="2"><input type="submit" name="login" value="login"/><td></tr>
<tr><td colspan="2" align="right"><input type="checkbox" name="chkbox"/></td></tr>
</table>
<form>
<?php
if(isset($_POST['submit']))
{
if($_POST['username']=="" || $_POST['userpass']=="")
{
echo "fill the input fields";
}

}
?>
</body>

<html>