<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE-edge">
    <meta name="viewport" content="width=device-width,inital-scale=1.0">
    <link rel="stylesheet" href="style.css">
    <title>Üye Girişi</title>
</head>
<body>
<div class="container">
    <div class="form-box">
        <header>
            Login
        </header>
        <form action="" method ="post">

            <div class="field input">
                <label for="username">Kullanıcı Adı:</label>
                <input type="text" name="username" id="username" required>
            </div>

            <div class="field input">
                <label for="password">Şifre:</label>
                <input type="password" name="username" id="password"  placeholder="Password"  required>
            </div>

            <div class="field">
                <input type="submit" class="btn" name="submit" value="Login"  required>
            </div>

            <div class="links">
                <p>Henüz hesabınız yok mu?<a href="register.html"> Şimdi Üye Olun.</a></p>
            </div>

        </form>
    </div>
</div>

</body>
</html>