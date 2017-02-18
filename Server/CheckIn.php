<?php    
	$servername = "EXAMPLE";
	$username = "EXAMPLE";
	$password = "EXAMPLE";
	$dbname = "EXAMPLE";
	$UserID = !empty($_GET['user']) ? $_GET['user'] : null;
	$RefreshCounter = !empty($_GET['refreshC']) ? $_GET['refreshC'] : null;
	$TaskCounter = !empty($_GET['taskC']) ? $_GET['taskC'] : null;
	$NewUserGreated=FALSE;
	$error="";
	
	// Create connection
	$conn = new mysqli($servername, $username, $password, $dbname);
	// Check connection
	if ($conn->connect_error) {
		die();
		$updateSuccessful=FALSE;
		$error .="Connection failed";
	} 
	
	$now = new DateTime(); //current date/time
	$current_time = $now->format('Y-m-d H:i:s');		

	//Does user excist?
	$sql = "SELECT ID FROM User WHERE ID = '$UserID'";
	$result = $conn->query($sql);	
	if ($result->num_rows > 0) {
		$sql = "UPDATE User SET Checkin='$current_time', RefreshCounter='$RefreshCounter', TaskCounter='$TaskCounter'  WHERE  ID = '$UserID'";

		if ($conn->query($sql) === TRUE) {
			$updateSuccessful=TRUE;
		} else {
			$updateSuccessful=FALSE;
			$error .="User Uptate error " . $conn->error;
		}
	} else {
		$updateSuccessful=FALSE;
		$error .="No user ";
		/*Register user again if room*/
		header("Location: http://ouroborosrg.16mb.com/Register.php?user=$UserID");
		die();
	}
		


	if	($updateSuccessful === TRUE) {
		$sql = "SELECT * FROM User";
		$result = $conn->query($sql);

		if ($result->num_rows > 0) {
			
				$xml = new SimpleXMLElement('<xml/>');
				
				$track = $xml->addChild('Registration');
				$track->addChild('Task', 'Checkin');
				$track->addChild('Status', 'Successful');
			
				Header('Content-type: text/xml');
				print($xml->asXML());
		}
	} else {
		$xml = new SimpleXMLElement('<xml/>');
				
		$track = $xml->addChild('Registration');
		$track->addChild('Task', 'Checkin');
		$track->addChild('Status', 'UnSuccessful');
		$track->addChild('error', $error);
		Header('Content-type: text/xml');
		print($xml->asXML());	
		
	}

	$conn->close();
?>