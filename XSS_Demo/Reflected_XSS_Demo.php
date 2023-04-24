<!DOCTYPE html>
<html>
  <head>
    <title>Reflected XSS Demo</title>
    <link rel="stylesheet" href="style.css"/> 
  </head>
  <body>
    <h1>Welcome to our XSS Demo website</h1>
    <p>Đây là trang có khả năng bị tấn công XSS. Giả dụ như bạn đã có tài khoản ở trong này, thông tin tài khoản của bạn nằm ở đây.<br>Nếu bị điều hướng, toàn bộ thông tin bạn nhập vào cũng sẽ bị gửi đi</p>
    <p name="hint">Input gây ra Reflected XSS: [trong file hướng dẫn kèm theo] </p>
    <h2>Search here</h2>
    <form>
      <div>
        <label for="userInfo">Thông tin user</label> 
        <input type="text" name="userInfo" placehorlder ="User Info that can be stolen">
      </div>
      <div>
        <label for="search">Chỗ search nhưng dùng để chèn script</label> 
        <input type="text" name="search" placeholder="Searching content">
      </div>
        <button type="submit">Submit</button>
    </form>
    <p>
      Hello, 
      <?php
        $userinfo = isset($_GET['userInfo']) ? $_GET['userInfo'] : '';
        $search = isset($_GET['search']) ? $_GET['search'] : '';
        echo "Chào mừng trở lại $userinfo ! Bạn đang cần tìm $search";
      ?>
    </p>
  </body>
</html>
