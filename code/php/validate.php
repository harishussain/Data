<?php
$email = trim($_POST['email']);
$phone = trim($_POST['phone']);
$a = trim($_POST['nic']);
//validation of form
if(preg_match("/^[^@]+@[^@]+\.[^@\.]+$/",$email))
{
    echo "your email is valid <br/>";
}
else
{
    echo "your email is invalid </br>";
}
if(preg_match("/^\d{11}$/",$phone))
{
    echo "your phone number is valid<br/>";
}
else
{
echo "your phone number is not valid</br>";
}
if(preg_match("/^\d{5}-\d{7}-\d$/",$a))
{
    echo "your cnic no is valid";
    echo "<br/>";

}
else {
    echo "invalid cnic token in the field";
}


?>