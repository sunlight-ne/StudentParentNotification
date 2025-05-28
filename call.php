<?php

if (!isset($_GET['phoneNumber'])) {
    die('Phone number is required.');
}

$phoneNumber = $_GET['phoneNumber'];

$account_sid = 'AC495406c6295e4be1dc16e03c97347cee';  
$auth_token = 'cbfbd6478f353e3d471c5430f8d6d2b5';  
$twilio_number = '+16088566605';  

$url = 'https://api.twilio.com/2010-04-01/Accounts/' . $account_sid . '/Calls.json';

$data = [
    'To' => $phoneNumber,
    'From' => $twilio_number,
    'Url' => 'http://demo.twilio.com/docs/voice.xml'  
];

$ch = curl_init($url);

curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);  
curl_setopt($ch, CURLOPT_POST, true); 
curl_setopt($ch, CURLOPT_POSTFIELDS, http_build_query($data));  
curl_setopt($ch, CURLOPT_USERPWD, "$account_sid:$auth_token");

$response = curl_exec($ch);

if ($response === false) {
    echo "Error: " . curl_error($ch);
} else {
    $response_data = json_decode($response, true);
    if (isset($response_data['sid'])) {
        header("Location: homepage.php?status=success&message=Call initiated successfully");
        exit();
    } else {
        $error_message = isset($response_data['message']) ? $response_data['message'] : 'Unknown error';
        header("Location: homepage.php?status=error&message=Error: " . $error_message);
        exit();
    }
}

curl_close($ch);
?>
