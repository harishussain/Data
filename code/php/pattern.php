<?php
if($_POST['posted']) {
    $newbcolor = $POST['NewBcolor'];
    $newtcolor = $POST['NewTcolor'];
    setcookie("Bcolor", "$newbcolor", time() + 3600);
    setcookie("Tcolor", "$newtcolor", time() + 3600);
    $Bcolor = $_COOKIE['Bcolor'];
    $Tcolor = $_COOKIE['Tcolor'];
    if ($Bcolor = "" || $Tcolor = "")
    {
        $Bcolor = "white";
        $Tcolor = "black";
    }
    echo $newbcolor;
    echo "<br>";
    echo $newtcolor;
    echo "<br/>";
    echo $Bcolor;
    echo "<br/>";
    echo $Tcolor;
    }
?>