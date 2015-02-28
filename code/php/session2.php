<?php
if(isset($_POST['login']))
{

if($_POST['remember']=="on")
{
$name = $_POST['username'];
setcookie("Username","$name",time()+3600);
$username = $_COOKIE['Username'];
echo $username;
//header("Location:link.php");
}


}
?>