const quantityInputs = document.querySelectorAll('.quantity');
        
quantityInputs.forEach(input => {
    input.addEventListener('input', () => {
        let currentValue = parseInt(input.value);
        if (currentValue < 1) {
            alert('Cảnh báo: Giá trị không thể giảm xuống dưới 1!');
            input.value = 1; // Đặt lại giá trị về 1
        }
        update(); // Cập nhật lại tổng khi số lượng thay đổi
    });
});
function del() {
    const removeButtons = document.querySelectorAll('.remove'); // Lấy tất cả nút xóa
    removeButtons.forEach(button => {
        button.addEventListener('click', () => {
            const row = button.closest('tr'); // Tìm hàng chứa nút xóa
            row.remove(); // Xóa hàng
        });
    });
}
del();
function update() {
    const rows = document.querySelectorAll("tbody tr");
    let sumAll = 0; // Khởi tạo biến tổng
    rows.forEach(row => {
        const quantity = parseInt(row.querySelector(".quantity").value);
        const priceText = row.querySelector(".price").textContent;
        const price = parseFloat(priceText.replace(/\./g, '').replace(',', '.')); // Chuyển đổi giá từ chuỗi sang số thực
        const total = quantity * price; // Tính thành tiền
        row.querySelector(".total").textContent = total.toLocaleString(); // Cập nhật thành tiền cho hàng
        sumAll += total; // Cộng dồn vào tổng
    });
    document.getElementById("sum-all").textContent = sumAll.toLocaleString(); // Cập nhật tổng cộng
}
