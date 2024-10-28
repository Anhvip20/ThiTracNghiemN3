
    document.addEventListener('DOMContentLoaded', function () {
        const accountLink = document.querySelector('.right a:first-child');
        const body = document.body;

        accountLink.addEventListener('click', function (e) {
            e.preventDefault(); // Ngăn chặn hành động mặc định của liên kết
            showLoginForm();
        });

        function showLoginForm() {
            // Tạo form đăng nhập
            const loginForm = document.createElement('div');
            loginForm.innerHTML = `
                <div class="login-modal">
                    <h2>Đăng Nhập</h2>
                    <label for="username">Tài Khoản:</label>
                    <input type="text" id="username" required />
                    <label for="password">Mật Khẩu:</label>
                    <input type="password" id="password" required />
                    <button id="loginButton">Đăng Nhập</button>
                    <button id="cancelButton">Hủy</button>
                </div>
            `;
            body.appendChild(loginForm);

            // Thêm CSS cho modal
            const style = document.createElement('style');
            style.textContent = `
                .login-modal {
                    position: fixed;
                    top: 50%;
                    left: 50%;
                    transform: translate(-50%, -50%);
                    background: white;
                    padding: 20px;
                    border: 1px solid #ccc;
                    box-shadow: 0 0 10px rgba(0,0,0,0.5);
                    z-index: 1000;
                }
                .login-modal input {
                    display: block;
                    margin-bottom: 10px;
                    width: 100%;
                }
                .login-modal button {
                    margin-right: 10px;
                }
            `;
            body.appendChild(style);

            // Xử lý sự kiện cho nút Đăng Nhập
            document.getElementById('loginButton').addEventListener('click', function () {
                const username = document.getElementById('username').value;
                const password = document.getElementById('password').value;

                // Kiểm tra thông tin đăng nhập (thay thế với logic thực tế)
                if (username && password) {
                    accountLink.innerHTML = `<i class="fas fa-user"></i> ${username}`;
                    closeLoginForm();
                } else {
                    alert('Vui lòng nhập tài khoản và mật khẩu!');
                }
            });

            // Xử lý sự kiện cho nút Hủy
            document.getElementById('cancelButton').addEventListener('click', function () {
                closeLoginForm();
            });
        }

        function closeLoginForm() {
            const loginModal = document.querySelector('.login-modal');
            if (loginModal) {
                loginModal.remove();
            }
        }
    });