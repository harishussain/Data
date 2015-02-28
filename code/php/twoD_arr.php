<?php
#exploring 2D array;
$Employee = array("Employee1"=> array("Name"=>"haris",
                                     "designation"=>"Programmer"
				     ),
                  "Employee2"=>array("Name"=>"saman",
                                     "designation"=>"system analyst"),"OneD","Other"
                  );             
foreach($Employee as $Emp)
{
if(is_array($Emp))
{
foreach($Emp as $key=>$value)
{
print "$key = $value <br/>";
}
}
}
echo "<br/>";
echo "<br/>";
echo "<br/>";
echo "<br/>";
echo "<pre>";
print_r($Employee);
echo "</pre>";
?>