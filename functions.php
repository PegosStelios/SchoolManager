<?php
/* GET functions */

$id = '';
$fname = '';
$lname = '';
$dob = '';
$tel = '';
$gender = '';
$email = '';
$update = false;

$_SESSION['message'] = '';
$_SESSION['toggle'] = '';

// Delete function
if (isset($_GET['delete'])) {
   $id = $_GET['delete'];
   $sqlDelete = "DELETE FROM student WHERE StudentID=$id";
   $deleted = mysqli_query($connection, $sqlDelete) or die(mysqli_error($connection));

   if ($deleted) {
      $_SESSION['message'] = 'User deleted successfully';
      $_SESSION['toggle'] = 'warning';
      header('location:index.php');
   }
}

// Edit function
if (isset($_GET['edit'])) {

   $id = $_GET['edit'];

   $sqlFetch = "SELECT * FROM student WHERE StudentID=$id LIMIT 1";
   $result = mysqli_query($connection, $sqlFetch);

   if (mysqli_num_rows($result) == 1) {

      $update = true;

      $row = mysqli_fetch_array($result);

      $id = $row['StudentID'];
      $fname = $row['FirstName'];
      $lname = $row['LastName'];
      $gender = $row['Gender'];
      $tel = $row['Tel'];
      $dob = $row['DoB'];
      $email = $row['Email'];
   }
}
