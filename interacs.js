document.addEventListener("DOMContentLoaded", function() {
    // Load settings from settings.json
    fetch("settings.json")
        .then(response => response.json())
        .then(settings => {
            const loginForm = document.getElementById("loginForm");
            const registerForm = document.getElementById("registerForm");
            const loginUrl = settings.loginUrl;
            const registerUrl = settings.registerUrl;
            
            const showRegisterForm = document.getElementById("showRegisterForm");
            const showLoginForm = document.getElementById("showLoginForm");
            
            showRegisterForm.addEventListener("click", function() {
                document.querySelector(".login-container").style.display = "none";
                document.querySelector(".register-container").style.display = "block";
            });
            
            showLoginForm.addEventListener("click", function() {
                document.querySelector(".register-container").style.display = "none";
                document.querySelector(".login-container").style.display = "block";
            });
            
            loginForm.addEventListener("submit", function(event) {
                event.preventDefault();
                
                const username = document.getElementById("username").value;
                const password = document.getElementById("password").value;
                
                fetch(loginUrl, {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify({ username, password })
                })
                .then(response => response.json())
                .then(data => {
                    if (data.success) {
                        alert(settings.messages.loginSuccess);
                        // Redirect or perform additional actions here
                    } else {
                        alert(settings.messages.loginFailed);
                    }
                })
                .catch(error => {
                    console.error("Error:", error);
                });
            });
            
            registerForm.addEventListener("submit", function(event) {
                event.preventDefault();
                
                const username = document.getElementById("reg-username").value;
                const password = document.getElementById("reg-password").value;
                
                fetch(registerUrl, {
                    method: "POST",
                    headers: {
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify({ username, password })
                })
                .then(response => response.json())
                .then(data => {
                    if (data.success) {
                        alert(settings.messages.registerSuccess);
                        // Redirect or perform additional actions here
                    } else {
                        alert(settings.messages.registerFailed);
                    }
                })
                .catch(error => {
                    console.error("Error:", error);
                });
            });
        });
});
