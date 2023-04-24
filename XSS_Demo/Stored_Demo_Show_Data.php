<?php
    $conn= mysqli_connect ('localhost', 'root', '', 'Demo_Stored_XSS_Database') or die ('Không thể kết nối tới database');
    mysqli_set_charset($conn, 'UTF8');

    if($conn === false){ 
      die("ERROR: Could not connect. " . mysqli_connect_error()); 
    }

    $sql = "SELECT Username, CommentContent FROM Comment";
    $result = $conn->query($sql);
    if ($result-> num_rows > 0) {
      while($row = $result->fetch_assoc()) {
        echo  
          '<tr>
          <td>
            <div>
              <div class="user-name">'.$row['Username'].'</div>
              <div class="comment-content">'.$row['CommentContent'].'</div>
            </div>
          </td>
          </tr>';
        
      }
    }

?>