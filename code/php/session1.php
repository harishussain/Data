<?php
session_start();
echo $_SESSION['user']."<br/>";
echo session_destroy();
echo $_SESSION['pwd']."<br/>";
echo date('y m d H:i:s',$_SESSION['time']);
echo '<br/> <a href ="session.php">page1</a>';
?>