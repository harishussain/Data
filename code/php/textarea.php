<?php
$_POST['txt'];
$count = 1;

while($count<6)
{
$text= htmlspecialchars($_POST['txt']);
echo "$text";
echo "<br/>";
$count++;
}
?>
