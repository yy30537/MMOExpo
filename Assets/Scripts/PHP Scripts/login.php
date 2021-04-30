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






$check_if_exist = mysql_query($conn, "SELECT * FROM MMOEXPOAuth WHERE `user`='".$user."'");
$numrows = mysql_num_rows($check_if_exist);




if ($numrows == 0)
{
	die ("Username does not exist \n");
}
else
{
	$pass = md5($pass);
	while($row = mysql_fetch_assoc($check_if_exist))
	{
		if ($pass == $row['pass'])
			die("login-SUCCESS");
		else
			die("Password does not match \n");
	}
}

?>