<?php echo '$_REQUEST["name"]','$_REQUEST["email"]','$_REQUEST["website"]','$_REQUEST["comment"]','$_REQUEST["gender"]';

if (isset($gender) && $gender=="female") 
echo "checked";

if (isset($gender) && $gender=="male") echo "checked";

?>