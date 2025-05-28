<?php
include 'connection.php';  

session_start();

if (!isset($_SESSION['studentNumber'])) {
    header("Location: index.php"); 
    exit();
}

$userID = $_SESSION['userID'];
$adminID = $_SESSION['adminID'];

$error = '';
$records = [];

try {
    $stmt = $pdo->prepare("SELECT * FROM records WHERE userID = ? AND adminID = ? ORDER BY `date` DESC, `dateIN` DESC");
    $stmt->bindParam(1, $userID);
    $stmt->bindParam(2, $adminID);
    $stmt->execute();

    $records = $stmt->fetchAll(PDO::FETCH_ASSOC);
} catch (PDOException $e) {
    $error = "Error fetching records: " . $e->getMessage();
}

$pdo = null;

$status = isset($_SESSION['call_status']) ? $_SESSION['call_status'] : '';
$message = isset($_SESSION['call_message']) ? $_SESSION['call_message'] : '';


unset($_SESSION['call_status'], $_SESSION['call_message']);
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <title>Homepage</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">

    <style>
        body {
            font-family: Arial, sans-serif;
        }

        .offcanvas-start {
            width: 250px;
        }

        .offcanvas-body {
            padding-top: 20px;
        }

        .navbar-toggler-icon {
            background-color: #333;
        }

        .table-container {
            max-height: 400px;
            overflow-y: auto;
            margin-bottom: 20px;
            border: 1px solid #ddd;
            border-radius: 8px;
        }

        table {
            width: 100%;
            border-collapse: collapse;
        }

        th, td {
            text-align: center;
            padding: 12px;
            border: 1px solid #ddd;
        }

        th {
            background-color: #f8f9fa;
            font-weight: bold;
        }

        tbody tr:nth-child(odd) {
            background-color: #f9f9f9;
        }

        tbody tr:nth-child(even) {
            background-color: #ffffff;
        }

        tbody tr:hover {
            background-color: #f1f1f1;
        }

        .table thead th {
            position: sticky;
            top: 0;
            z-index: 10;
        }

 
        .alert-message {
            margin-top: 20px;
        }
        .alert-message.success {
            color: green;
            border: 1px solid green;
            background-color: #e8f5e9;
        }
        .alert-message.error {
            color: red;
            border: 1px solid red;
            background-color: #f8d7da;
        }

        @media (max-width: 768px) {
            .offcanvas-start {
                width: 100%;
            }

            .table-container {
                max-width: 100%;
                overflow-x: auto;
            }

            .table th, .table td {
                font-size: 14px;
                padding: 8px;
            }

            h1 {
                font-size: 1.5rem;
            }

            h3 {
                font-size: 1.2rem;
            }

            .container {
                padding: 10px;
            }

            .btn-primary {
                display: block;
                margin: 10px auto;
            }

            .btn {
                width: 100%;
                margin-bottom: 10px;
            }
        }

        .offcanvas-body .nav-item {
            padding: 10px 0;
        }

        .offcanvas-body .nav-link {
            font-size: 18px;
            color: #333;
        }

        .offcanvas-body .nav-link:hover {
            background-color: #f1f1f1;
        }

        .loading-overlay {
            position: fixed;
            top: 0;
            left: 0;
            right: 0;
            bottom: 0;
            background: rgba(255, 255, 255, 0.7);
            display: none;
            justify-content: center;
            align-items: center;
            z-index: 1000;
        }

        .loading-spinner {
            border: 4px solid #f3f3f3;
            border-top: 4px solid #007bff;
            border-radius: 50%;
            width: 50px;
            height: 50px;
            animation: spin 1s linear infinite;
        }

        @keyframes spin {
            0% { transform: rotate(0deg); }
            100% { transform: rotate(360deg); }
        }
    </style>
</head>
<body>

    <?php if ($status && $message): ?>
        <div class="alert-message <?php echo $status; ?>">
            <strong><?php echo ucfirst($status); ?>!</strong> <?php echo htmlspecialchars($message); ?>
        </div>
    <?php endif; ?>

    <div class="offcanvas offcanvas-start" tabindex="-1" id="offcanvasSidebar" aria-labelledby="offcanvasSidebarLabel">
        <div class="offcanvas-header">
            <h5 class="offcanvas-title" id="offcanvasSidebarLabel">Services</h5>
            <button type="button" class="btn-close text-reset" data-bs-dismiss="offcanvas" aria-label="Close"></button>
        </div>
        <div class="offcanvas-body">
            <ul class="nav flex-column">
                <li class="nav-item">
                    <a class="nav-link" href="#" onclick="confirmCall()"><i class="fas fa-phone-alt"></i> Call Barangay Manila</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="#" onclick="confirmCallPolice()"><i class="fas fa-shield-alt"></i> Police</a>
                </li>
                <hr>
                <li class="nav-item">
                    <a href="logout.php" class="btn btn-danger" onclick="logout()"> <i class="fas fa-sign-out-alt"></i> Logout</a>
                </li>
            </ul>
        </div>
    </div>

    <div class="container mt-5">
        <button class="btn btn-primary" type="button" data-bs-toggle="offcanvas" data-bs-target="#offcanvasSidebar" aria-controls="offcanvasSidebar">
          <i class="fas fa-bars"></i> Menu
        </button>

        <h1>Welcome, <?php echo htmlspecialchars($_SESSION['firstName']); ?>!</h1>
        <p>Students Monitoring System</p>

        <h3>Records Data</h3>
        <div class="table-container">
            <table class="table table-bordered">
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Time In</th>
                        <th>Time Out</th>
                        <th>Date</th>
                    </tr>
                </thead>
                <tbody>
                    <?php
                    if ($records) {
                        $index = 0; 
                        foreach ($records as $record) {
                            $index++; 
                            echo "<tr>";
                            echo "<td>" . $index . "</td>";
                            echo "<td>" . htmlspecialchars($record['dateIN'] ?? '') . "</td>";
                            echo "<td>" . htmlspecialchars($record['dateOut'] ?? '') . "</td>";
                            echo "<td>" . ( !empty($record['date']) && strtotime($record['date']) ? (new DateTime($record['date']))->format('F d, Y') : 'No date available') . "</td>";
                            echo "</tr>";
                        }
                    } else {
                        echo "<tr><td colspan='4'>No data available.</td></tr>";
                    }
                    ?>
                </tbody>
            </table>
        </div>
    </div>

    <div id="loading" class="loading-overlay">
        <div class="loading-spinner"></div>
    </div>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>

    <script>
        function logout(event) {
            event.preventDefault();  
            document.getElementById('loading').style.display = 'flex';
            setTimeout(function() {
                window.location.href = "logout.php";  
            }, 2000);  
        }

        function confirmCall() {
            document.getElementById('loading').style.display = 'flex'; 
            if (confirm("Are you sure you want to call Barangay?")) {
                window.location.href = "call.php?phoneNumber=+639079330852";  
            }
        }

        function confirmCallPolice(){
            if (confirm("Are you sure you want to call Police?")) {
                window.location.href = "call.php?phoneNumber=+639079330852";  
            }
        }
    </script>
</body>
</html>
