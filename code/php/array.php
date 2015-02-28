<html>
<head>
</head>
<body>
<?php
$days = array("mon"=>"monday","tues"=>"tuesday","wed"=>"wednesday","thu"=>"thursday","fri"=>"friday","sat"=>"saturday","sun"=>"sunday"); //array declaration an assignment;
#using foreach loop to access and display days.
foreach($days as $key => $day)
{
 print "$key<>$day</br>";
}
?>
</body>
</html>