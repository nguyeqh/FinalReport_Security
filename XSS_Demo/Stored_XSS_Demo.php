<!DOCTYPE html>
<html>
  <head>
    <title>Stored XSS Demo</title>
    <link rel="stylesheet" href="style.css"/> 
  </head>
  <body>
    <h1>Welcome to our Stored XSS Demo website</h1>
    <p>Đây là trang có khả năng bị tấn công XSS</p>
    <p name="hint">Input gây ra Storeded XSS: [trong file hướng dẫn kèm theo] </p>
    <h2>Table of comment</h2>

    <table>
      <?php require("Stored_Demo_Show_Data.php"); ?> 
    </table>

    <form action="Stored_XSS_Demo.php" method="POST" id="CmtForm" name="CmtForm">
      <label for="name">Your name:</label>
      <input type="text" id="name" name="name">
      <label for "comment">Your comment:</label>
      <textarea id="comment" name="comment" rows="5" cols="30"></textarea>
      <button type="submit" form="CmtForm" value="comment" name="submit">Add a comment</button>

      <?php

        if(isset($_POST['submit'])){
          $conn= mysqli_connect ('localhost', 'root', '', 'Demo_Stored_XSS_Database') or die ('Không thể kết nối tới database');
          mysqli_set_charset($conn, 'UTF8');

          if($conn === false){ 
            die("ERROR: Could not connect. " . mysqli_connect_error()); 
          }


            $userinfo = isset($_POST['name']) ? $_POST['name'] : '';
            $comment = isset($_POST['comment']) ? $_POST['comment'] : '';
            

            $sql = "INSERT INTO comment (Username, CommentContent) VALUES ('$userinfo',' $comment')";
            if (mysqli_query($conn, $sql)){
                echo "<h2>Comment thành công!</h2>";
            }
            else {
                echo 
                    '<script language="javascript">
                        alert("Có lỗi trong quá trình xử lý"); 
                        
                    </script>';
            }
          
          }

    ?>

   </form>


  </body>
</html>
