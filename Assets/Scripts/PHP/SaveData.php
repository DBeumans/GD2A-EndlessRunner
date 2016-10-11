<?php
  $score=$_REQUEST['score'];
  //sanitize input
  if($score != ""){
    // localhost , username, password, tablename
    $database = mysqli_connect('localhost', '13103_EndlessRunner', '13103', 'Scores') or die('Failed to connect: ' . mysql_error());
    $timeStamp = date('Y-m-d H:i:s');
    $query="INSERT INTO Scores(ID, Username, Score) VALUES(DEFAULT, '$score');";
    $result=mysqli_query($query);
    echo "$score, $playerID, $timeStamp success?";
  } else{
    echo "Bro score was empty bro";
  }
 ?>