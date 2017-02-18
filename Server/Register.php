<?php    
	$servername = "EXAMPLE";
	$username = "EXAMPLE";
	$password = "EXAMPLE";
	$dbname = "EXAMPLE";
	$CurrentTime = new DateTime();
	$UserID = !empty($_GET['user']) ? $_GET['user'] : null;
	$NewUserGreated=FALSE;
	$UserExists = FALSE;
	$error="";
	
	include 'CleanDatabase.php';
	
	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbname);
	// Check connection
	if ($conn->connect_error) {
		die("Connection failed: " . $conn->connect_error);
	} 
	
	$sql = "SELECT Value FROM Settings WHERE SettingID = 'MaxUsers'";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		while($row = $result->fetch_assoc()) {
			$MaxUsers = $row["Value"];
		}
	}
	
	$sql = "SELECT Value FROM Settings WHERE SettingID = 'Online'";
	$result = $conn->query($sql);
	if ($result->num_rows > 0) {
		while($row = $result->fetch_assoc()) {
			$Online = $row["Value"];
		}
	}
	
	//How many user are online
	$sql = "SELECT ID FROM User";
	$result = $conn->query($sql);	
	if ($result->num_rows < $MaxUsers) {
		//Does user excist?
		$sql = "SELECT ID FROM User WHERE ID = '$UserID'";
		$result = $conn->query($sql);	
		if ($result->num_rows == 0) {
			$greateNewUser = TRUE;
		} else {
			$greateNewUser = FALSE;
			$UserExists = TRUE;
			$error .= "User exists. ";
		}
	} else {
		$greateNewUser = FALSE;
		$error .="User limit exceeded. ";
	}
	
	//Greate New user 
	if	($greateNewUser === TRUE) {
		$now = new DateTime(); //current date/time
		$current_time = $now->format('Y-m-d H:i:s');
		$now->add(new DateInterval("PT{$Online}H"));
		$END_time = $now->format('Y-m-d H:i:s');
		
		$sql = "INSERT INTO User (ID, Creation, Checkin, CheckOut, RefreshCounter, TaskCounter) VALUES ('$UserID', '$current_time', '$current_time', '$END_time' ,'0', '0')";

		if ($conn->query($sql) === TRUE) {
			$NewUserGreated=TRUE;
		} else {
			$NewUserGreated=FALSE;
			$error .="User greation error ";
		}
	}

	if	($NewUserGreated === TRUE) {
		$sql = "SELECT * FROM Settings";
		$result = $conn->query($sql);

		if ($result->num_rows > 0) {
			
				$xml = new SimpleXMLElement('<xml/>');
				
				$track = $xml->addChild('Registration');
				$track->addChild('Task', 'Register');
				$track->addChild('Status', 'Successful');
				
				while($row = $result->fetch_assoc())
				{
					$track = $xml->addChild($row['SettingID'], $row['Value']);
				}
				$track = $xml->addChild('Creation', $current_time);
				$track = $xml->addChild('CheckOut', $END_time);
				Header('Content-type: text/xml');
				echo($xml->asXML());
		}
	} else 	if	($UserExists === TRUE) {
		$sql = "SELECT * FROM Settings";
		$result = $conn->query($sql);

		if ($result->num_rows > 0) {
			
				$xml = new SimpleXMLElement('<xml/>');
				
				$track = $xml->addChild('Registration');
				$track->addChild('Task', 'Register');
				$track->addChild('Status', 'Semi-Successful');
				
				while($row = $result->fetch_assoc())
				{
					$track = $xml->addChild($row['SettingID'], $row['Value']);
				}
				$track = $xml->addChild('Creation', $current_time);
				$track = $xml->addChild('CheckOut', $END_time);
				Header('Content-type: text/xml');
				echo($xml->asXML());
		}
	} else {
		$xml = new SimpleXMLElement('<xml/>');
				
		$track = $xml->addChild('Registration');
		$track->addChild('Task', 'Register');
		$track->addChild('Status', 'UnSuccessful');
		$track->addChild('error', $error);
		Header('Content-type: text/xml');
		echo($xml->asXML());	
	}

	$conn->close();
?>