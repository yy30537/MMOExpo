<?PHP

$user = $_POST["user"];
$name = $_POST["name"];
$pass = $_POST["password"];

$servername = "fdb29.awardspace.net";
$username = "3749050_mmoexpoauth";
$password = "T6q#4N7mwzr54Jt";
$dbname = "3749050_mmoexpoauth";

$conn = mysqli_connect($servername, $username, $password, $dbname);
if (mysqli_connect_errno()) {
	die("Failed to connect to MySQL: " . mysqli_connect_error());
}


$check_if_exist = mysqli_query($conn, "SELECT * FROM MMOEXPOAuth WHERE `user`='".$user."'");
$numrows = mysqli_num_rows($check_if_exist);

if ($numrows == 0)
{
	$pass = md5($pass); 
	$query = "INSERT INTO  `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, '".$user."', '".$name."', '".$pass."'); ";
	$ins = mysqli_query($conn, $query);


	if ($ins)
		die ("Succesfully Created User!");
	else
		die ("php Error: " . mysqli_error($conn));
}
else
{
	die("User allready exists!");
}


?>