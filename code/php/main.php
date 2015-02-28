<?php
/*$index=(intval($_GET['index']));
$pages = array(1=>"header.php",2=>"left.php",3=>"right.php",4=>"footer.php");
if($index>4)
{
header("Loction:main.php");
}
*/
?>
<html>
<head>
<title>
master page
</title>
</head>
<body>
<table height="100%" width="100%" border="1">
<tr>
<td height ="25%" colspan="3">
<?php include"header.php"; ?>
</td>
</tr>
<tr> <td width="25%" valign="top"><?php include "left.php" ?> </td>
<td width="50%" align="center" valign="top"> Main contents</td>
<td width="25%" align="left" valign="top"> <?php include "right.php" ?></td>
</tr>
<tr>
<td width ="100%" height="5%" colspan="3"> <?php include "footer.php"?>
</td>
</tr>
</table>
</body>
</html>