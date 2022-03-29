<?php

define('hostname', 'localhost');
define('user', 'root');
define('password', '');
define('db_name', 'schoolManager');

$connection = mysqli_connect(hostname, user, password, db_name);
