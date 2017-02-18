<?php    
	$servername = "EXAMPLE";
	$username = "EXAMPLE";
	$password = "EXAMPLE";
	$dbname = "EXAMPLE";
	
	$now = new DateTime(); //current date/time
	$current_time = $now->format('Y-m-d H:i:s');	
	
	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbname);
	// Check connection
	if ($conn->connect_error) {
		die();
		$updateSuccessful=FALSE;
		$error .="Connection failed";
	} 
	
	$sql = "SELECT Value FROM Settings WHERE SettingID = 'cleanupTime'";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		while($row = $result->fetch_assoc()) {
			$cleanupTime = $row["Value"];
		}
	}
	
	$sql = "SELECT * FROM User";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		// output data of each row
		while($row = $result->fetch_assoc()) {
			$ID=$row["ID"];
			$Checkin=$row["Checkin"];
			$overflow=$row["Checkin"];
			$CheckOut=$row["CheckOut"];
			
			$currentDate = strtotime($Checkin);
			$futureDate = $currentDate+(60*$cleanupTime);
			$overflow = date("Y-m-d H:i:s", $futureDate);

			$A = strtotime($current_time); //gives value in Unix Timestamp (seconds since 1970)
			$B = strtotime($CheckOut);
			$C_overflow = strtotime($overflow);

			if (($B < $A) || ($A > $C_overflow)){
				// sql to delete a record
				$sql = "DELETE FROM User WHERE ID='$ID'";
				if ($conn->query($sql) === TRUE) {
					//echo "Record deleted successfully>" .$ID";
				}else{
					 //echo "Error deleting record: " . $conn->error;
				}
			}
		}
	}
	
	$conn->close();
?>