<html>
<head></head>
<body><?php
$City = $_POST['city'];
echo " City is : ".$City;
echo "<br/>";
$Color = $_POST['colors']; 
foreach($Color as $color)
{
echo $color;
}
?>

</body>
</html>