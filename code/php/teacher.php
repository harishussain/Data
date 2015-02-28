<?php
$xml  = simplexml_load_file("teacher.xml");
var_dump($xml);
echo "</br>";
echo "</br>";
echo "</br>";
foreach($xml->book as $book)
{
printf("%s is %s",$book->author,$book->author->attributes());
echo "</br>";
}

echo $xml->book[1]->author->attributes();


?>