<?php

session_start();

require_once 'config.php';

$id = $_POST['userId'];

$fname = $_POST['fname'];
$lname = $_POST['lname'];
$gender = $_POST['gender'];
$tel = $_POST['tel'];
$email = $_POST['email'];
$dob = $_POST['dob'];

echo $fname . '<br>';
echo $lname . '<br>';
echo $tel . '<br>';
echo $email . '<br>';
echo $gender . '<br>';

$register = $_POST['register'];
$update = $_POST['update'];

/* The registration section */

if (isset($register)) {
   if ($_SERVER['REQUEST_METHOD'] == 'POST') {

      $sqlFetch = "SELECT Tel, Email FROM student WHERE Tel='$tel' AND Email='$email' LIMIT 1";
      $result = mysqli_query($connection, $sqlFetch) or die(mysqli_error($connection));

      if (mysqli_num_rows($result) > 0) {
         $_SESSION['message'] = 'Registration failure; User (' . $email . ', ' . $tel . ') already exists.';
         $_SESSION['toggle'] = 'error';
         header('location:index.php');
      } else {
         $sqlInsert = "INSERT INTO student(FirstName, LastName, Tel, Email, DoB, Gender) values('$fname', '$lname', '$tel', '$email', '$dob', '$gender')";
         $inserted = mysqli_query($connection, $sqlInsert) or die(mysqli_error($connection));

         if ($inserted) {
            $_SESSION['message'] = 'User registered successfully.';
            $_SESSION['toggle'] = 'success';
            header('location:index.php');
         }
      }
   }
} elseif (isset($update)) {

   /* The update section */

   if ($_SERVER['REQUEST_METHOD'] == 'POST') {
      $sqlEdit = "UPDATE student SET FirstName='$fname', LastName='$lname', Tel='$tel', Email='$email', Gender='$gender' WHERE StudentID='$id'";
      $edited = mysqli_query($connection, $sqlEdit) or die(mysqli_error($connection));

      if ($edited) {
         $_SESSION['message'] = 'Record updated successfully';
         $_SESSION['toggle'] = 'warning';

         $update = false;

         header('location:index.php');
      }
   }
}
