<?php
$str = "hello world";
$str1 = str_replace("world","haris",$str);
echo $str1;
echo "first character accurance at postion".strpos($str,"r");
$A= str_repeat("$str",3);
echo $A;
echo "<br/>".md5($str);
echo "<br/>";
echo date("Y");
echo date("D/F/Y , h:i:s a");
echo "<br/>";
$y=checkdate(12,31,2014);
echo $y;
echo htmlspecialchars(nl2br("let <H1> us C \n by rober<H1/> lafore"));
echo "<br/>";
echo "Now".date("m-d-Y");
echo "<br/>";
$next_2week = time() + (14*24*60*60);
echo "next week".date("m-d-Y",$next_2week);
?>
