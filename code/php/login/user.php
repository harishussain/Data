<?php
if(!($_SESSION['login'] && empty($_SESSION['username'])))
{
    header("Location:login.php");
}


?>
    <html>
    <head>
        <title>
            user login
        </title>
    </head>
    <body>
    <h3> welcome <?= $_SESSION['username']?> to user pannel</h3>
<a href = "login.php"> logout </a>
</body>
</html>