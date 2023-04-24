<!DOCTYPE html>
<html>
  <head>
    <title>Reflected XSS Demo</title>
    <link rel="stylesheet" href="style.css"/> 
  </head>
  <body>
    <h1>Welcome to our website</h1>
    <p>We have anti Reflected XSS here :3</p>
    <p>Search here</p>
    <form>   
      <input type="text" name="userInfo" placehorlder ="User Info that can be stolen">
      <input type="text" name="search" placeholder="Searching content">
      <button type="submit">Submit</button>
    </form>
    <p>
      Hello, 
      <?php
        $userinfo = isset($_GET['userInfor']) ? $_GET['userInfo'] : '';
        $search = isset($_GET['search']) ? $_GET['search'] : '';

        // Sẽ chuyển thành: &lt;script&gt;'Noi dung'&lt;/script&gt;gt;
        $userinfo = htmlspecialchars($userinfo);
        $search = htmlspecialchars($search);
        echo $search;
      ?>
    </p>
  </body>
</html>
