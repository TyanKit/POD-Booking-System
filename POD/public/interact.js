document.addEventListener("DOMContentLoaded", function() {
    // Chuyển đổi giữa biểu mẫu đăng nhập và đăng ký
    const loginContainer = document.getElementById("login-container");
    const registerContainer = document.getElementById("register-container");
    const showRegisterFormLink = document.getElementById("showRegisterForm");
    const showLoginFormLink = document.getElementById("showLoginForm");

    showRegisterFormLink.addEventListener("click", function(event) {
        event.preventDefault();
        loginContainer.style.display = "none";
        registerContainer.style.display = "block";
    });

    showLoginFormLink.addEventListener("click", function(event) {
        event.preventDefault();
        registerContainer.style.display = "none";
        loginContainer.style.display = "block";
    });

    // Xử lý đăng nhập
    document.getElementById("loginForm").addEventListener("submit", function(event) {
        event.preventDefault();

        const username = document.getElementById("username").value;
        const password = document.getElementById("password").value;

        // Gửi yêu cầu đăng nhập
        fetch("/login", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ username, password })
        })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                alert("Đăng nhập thành công!");
                // Redirect hoặc thực hiện các hành động khác
            } else {
                alert("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        })
        .catch(error => {
            console.error("Error:", error);
        });
    });

    // Xử lý đăng ký
    document.getElementById("registerForm").addEventListener("submit", function(event) {
        event.preventDefault();

        const username = document.getElementById("reg-username").value;
        const password = document.getElementById("reg-password").value;
        const confirmPassword = document.getElementById("confirm-password").value;

        if (password !== confirmPassword) {
            alert("Mật khẩu và xác nhận mật khẩu không khớp.");
            return;
        }

        // Gửi yêu cầu đăng ký
        fetch("/register", {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({ username, password })
        })
        .then(response => response.json())
        .then(data => {
            if (data.success) {
                alert("Đăng ký thành công! Vui lòng đăng nhập.");
                registerContainer.style.display = "none";
                loginContainer.style.display = "block";
            } else {
                alert("Đăng ký thất bại. Vui lòng thử lại.");
            }
        })
        .catch(error => {
            console.error("Error:", error);
        });
    });
});
