<?php    
	$servername = "EXAMPLE";
	$username = "EXAMPLE";
	$password = "EXAMPLE";
	$dbname = "EXAMPLE";
	$UserID = !empty($_GET['user']) ? $_GET['user'] : null;

	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbname);
	// Check connection
	if ($conn->connect_error) {
		die();
		$updateSuccessful=FALSE;
		$error .="Connection failed";
	} 
	
	// sql to delete a record
	$sql = "DELETE FROM User WHERE ID='$UserID'";
	if ($conn->query($sql) === TRUE) {
		//echo "Record deleted successfully>" .$UserID;
	}else{
		// echo "Error deleting record: " . $conn->error;
	}
	
	$conn->close();
?>