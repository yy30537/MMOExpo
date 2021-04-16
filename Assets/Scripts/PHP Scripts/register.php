<?PHP

$user = $_POST["user"];
$name = $_POST["name"];
$pass = $_POST["password"];

$servername = "fdb29.awardspace.net";
$username = "3749050_mmoexpoauth";
$password = "68XFBVmk5Q99ytCo";
$dbname = "3749050_mmoexpoauth";

$conn = mysqli_connect($servername, $username, $password, $dbname);
if (mysqli_connect_errno()) {
	die("Failed to connect to MySQL: " . mysqli_connect_error());
}

//$query = "INSERT INTO  `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, '".$user."', '".$name."', '".$pass."'); ";

$query = "INSERT INTO  `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, 'testusername1', 'testname1', '123'); ";

/*
$check_if_exist = mysqli_query($conn, "SELECT * FROM MMOEXPOAuth WHERE `user`='".$user."'");
$numrows = mysqli_num_rows($check_if_exist);

if ($numrows == 0)
{
	$pass = md5($pass); 
	//$query = "INSERT INTO  `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, '".$user."', '".$name."', '".$pass."'); ";

	$query = "INSERT INTO  `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, 'testusername1', 'testname1', '123'); ";
	$ins = mysqli_query($conn, $query);

	// INSERT INTO `MMOEXPOAuth` (`id`, `user`, `name`, `pass`) VALUES (NULL, 'test user manual insert 2', 'test name manual insert 2', '123');
	// http://osummoexpo.mygamesonline.org/register.php?user=test1&name=test1&password=123451


	if ($ins)
		die ("Succesfully Created User!");
	else
		die ("php Error: " . mysqli_error($conn));
}
else
{
	die("User allready exists!");
}

*/




?>