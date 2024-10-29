
    const soLuongInputs = document.querySelectorAll('.quantity');

    soLuongInputs.forEach(input => {
        input.addEventListener('input', () => {
            let giaTriHienTai = parseInt(input.value);
            if (giaTriHienTai < 1) {
                alert('Cảnh báo: Giá trị không thể giảm xuống dưới 1!');
                input.value = 1; // Đặt lại giá trị về 1
            }
            update(); // Cập nhật lại tổng khi số lượng thay đổi
        });  
    });
    
    function del() {
        const nutXoa = document.querySelectorAll('.remove'); // Lấy tất cả nút xóa
        nutXoa.forEach(button => {
            button.addEventListener('click', () => {
                const hang = button.closest('tr'); // Tìm hàng chứa nút xóa
                hang.remove(); // Xóa hàng
                update();
            });
        });
    }
    del();
    
    function update() {
        const hangHoa = document.querySelectorAll("tbody tr");
        let tongCong = 0; // Khởi tạo biến tổng
        hangHoa.forEach(hang => {
            const soLuong = parseInt(hang.querySelector(".quantity").value);
            const giaText = hang.querySelector(".price").textContent;
            const gia = parseFloat(giaText.replace(/\./g, '').replace(',', '.')); // Chuyển đổi giá từ chuỗi sang số thực
            const thanhTien = soLuong * gia; // Tính thành tiền
            hang.querySelector(".total").textContent = thanhTien.toLocaleString(); // Cập nhật thành tiền cho hàng
            tongCong += thanhTien; // Cộng dồn vào tổng
        });
        document.getElementById("sum-all").textContent = tongCong.toLocaleString(); // Cập nhật tổng cộng
    }
    