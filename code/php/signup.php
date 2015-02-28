<?php
$age= $_POST['age'];
echo "<br/>";
$name=$_POST['name'];
echo "<br/>";
$email=$_POST['email'];
echo "<br/>";
$gender = $_POST['gender'];
echo "<br/>";
$city =$_POST['city'];
echo "<br/>";
$skill = $_POST['skill'];
echo "<br/>";
echo $age;
echo "<br/>";
echo "$name <br/>";
echo "$email<br/>";
echo "$gender<br/>";
echo "$city";
echo "Your skills:";
echo "<br/>";
foreach($skill as $value)
{
    echo $value."<br/>";
}
if($age>=20 && $age<=30)
{
echo "eligible </br>";
}
else
echo "not eligible</br>";
function Eligible($skill)
{
    if(count($skill)==0)
    {
        echo "you have no any skills";
    }
}
Eligible($skill);
function IsEmpty($arr)
{
    if(!Is_array($arr))
    {
        echo "it should be array";
}
foreach($arr as $key => $value)
{
if(empty($value))
{
echo ucwords($key)."should not b empty";
}

echo $key."=$value<br>";
}
}

IsEmpty($_POST);

?>
