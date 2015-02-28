<?php
session_start();
echo "well come to my page!";
$_SESSION['user'] = 'haris';
$_SESSION['pwd'] = 'cat';
$_SESSION['time'] = time();
session_destroy();
$_SESSION=array();
echo '<br/> <a href = "session.php">page </a>';
echo '<br/> <a href = "session1.php'.SID.'">page2</a>';

?>