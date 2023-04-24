<!DOCTYPE html>
<html>
  <head>
    <title>Reflected XSS Demo</title>
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

    <form action="/Stored_Demo_page.php" method="post" id="comment">
      <label for="name">Your name:</label>
      <input type="text" id="name" name="name">
      <label for "comment">Your comment:</label>
      <textarea id="comment" name="comment" rows="5" cols="30"></textarea>
      <button type="submit" form="comment" value="comment">Add a comment</button>
  </form>

   <?php
        $userinfo = isset($_GET['name']) ? $_GET['name'] : '';
        $comment = isset($_GET['comment']) ? $_GET['comment'] : '';
        

        $sql = "INSERT INTO Comment (Username, CommentContent) VALUES ('$name','$comment')";
        if (mysqli_query($conn, $sql)){
            echo "Comment thành công!";
        }
        else {
            echo 
                '<script language="javascript">
                    alert("Có lỗi trong quá trình xử lý"); 
                    window.location="admincontrol.php";
                </script>';
        }
      ?>

  </body>
</html>
