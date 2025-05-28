<?php
include 'connection.php'; 

$error = '';  

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $studentNumber = $_POST['studentNumber'];
    $phoneNumber = $_POST['phoneNumber'];

    if (!preg_match('/^[0-9]{11}$/', $phoneNumber)) {
        $error = "Invalid phone number. Please enter a valid 11-digit phone number.";  
    } else {
        $stmt = $pdo->prepare("SELECT u.*, p.* 
                               FROM user u 
                               JOIN parent p ON u.userID = p.userID
                               WHERE u.studentNumber = :studentNumber AND p.phoneNumber = :phoneNumber");
        $stmt->bindParam(':studentNumber', $studentNumber);
        $stmt->bindParam(':phoneNumber', $phoneNumber);
        $stmt->execute();

        $user = $stmt->fetch(PDO::FETCH_ASSOC);

        if ($user) {
            session_start();
            $_SESSION['studentNumber'] = $studentNumber; 
            $_SESSION['userID'] = $user['userID']; 
            $_SESSION['adminID'] = $user['adminID']; 
            $_SESSION['firstName'] = $user['firstName']; 

            header("Location: homepage.php");
            exit();
        } else {
            $error = "Invalid student number or phone number.";  
        }
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no">
    <title>Login</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css" rel="stylesheet">
    <link rel="shortcut icon" href="logo.jpg" type="image/x-icon">
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            min-height: 100vh;
            position: relative;
            background: linear-gradient(
                rgba(0, 123, 255, 0.4),  
                rgba(255, 255, 255, 0.4)  
            ), 
            url("logo.jpg");
            background-size: cover; 
            background-position: center center; 
            background-attachment: fixed; 
            background-repeat: no-repeat; 
        }

        .login-card {
            width: 100%;
            max-width: 400px;
            background: #fff;
            padding: 30px;
            border-radius: 12px;
            box-shadow: 0 4px 12px rgba(0, 0, 0, 0.1);
            z-index: 1;
        }

        .login-card h3 {
            font-size: 1.5rem;
            margin-bottom: 20px;
        }

        .form-control {
            border-radius: 8px;
            height: 45px;
            padding-left: 15px;
            font-size: 1rem;
        }

        .form-control:focus {
            box-shadow: 0 0 10px rgba(0, 123, 255, 0.5);
            border-color: #007bff;
        }

        .btn-primary {
            border-radius: 8px;
            padding: 10px 20px;
            font-size: 1.1rem;
            width: 100%;
            background-color: #007bff;
            border: none;
            transition: background-color 0.3s;
        }

        .btn-primary:hover {
            background-color: #0056b3;
        }

        .alert-danger {
            border-radius: 8px;
            padding: 15px;
            margin-bottom: 20px;
            opacity: 1; 
        }

        .fade-out {
            animation: fadeOut 3s forwards;
        }

        @keyframes fadeOut {
            0% {
                opacity: 1;
            }
            100% {
                opacity: 0;
            }
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
    <div id="loading" class="loading-overlay">
        <div class="loading-spinner"></div>
    </div>

    <div class="container d-flex justify-content-center align-items-center min-vh-100">
    <div class="row w-100">
      
        <?php if (!empty($error)): ?>
            <div id="errorMessage" class="col-12 alert alert-danger text-center mb-4">
                <i class="fas fa-exclamation-circle"></i> <?php echo htmlspecialchars($error); ?>
            </div>
        <?php endif; ?>
        
        <div class="col-md-6 offset-md-3">
            <div class="card shadow-lg p-4 rounded">
                <h3 class="text-center mb-4">Parent Login</h3>
                
                <form id="loginForm" action="" method="post" onsubmit="showLoading(event)">
                    <div class="mb-3">
                        <label for="studentNumber" class="form-label">Student Number</label>
                        <input type="text" class="form-control" id="studentNumber" name="studentNumber" required>
                    </div>

                    <div class="mb-3">
                        <label for="phoneNumber" class="form-label">Phone Number</label>
                        <input type="text" class="form-control" id="phoneNumber" name="phoneNumber" required>
                    </div>

                    <button type="submit" class="btn btn-primary w-100">Login</button>
                </form>
            </div>
        </div>
    </div>
</div>


    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js"></script>

    <script>
        function showLoading(event) {
            if (!validatePhoneNumber()) {
                event.preventDefault();  
            } else {
                document.getElementById('loading').style.display = 'flex';  
            }
        }

        function validatePhoneNumber() {
            var phoneNumber = document.getElementById('phoneNumber').value;
            var phoneRegex = /^[0-9]{11}$/;

            if (!phoneRegex.test(phoneNumber)) {
                document.getElementById('errorMessage').innerHTML = '<i class="fas fa-exclamation-circle"></i> Invalid phone number. Please enter a valid 11-digit phone number.';
                return false; 
            }
            return true; 
        }

        window.onload = function() {
            var errorMessage = document.getElementById('errorMessage');
            if (errorMessage) {
                setTimeout(function() {
                    errorMessage.classList.add('fade-out');
                }, 5000); 
            }
        };
    </script>
</body>
</html>
