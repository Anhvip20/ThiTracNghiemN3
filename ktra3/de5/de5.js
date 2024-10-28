const quantityInput = document.querySelector('.hh1');

quantityInput.addEventListener('input', function() {
  const value = this.value;
  if (value === '' || isNaN(value) || parseInt(value) < 0) {
    this.classList.add('error');
    alert('Vui lòng nhập số lượng là một số nguyên dương.');
  } else {
    this.classList.remove('error');
     // Gọi hàm updateTotal để cập nhật tổng tiền
  }
});

function update() {
    let total = 0; // Khởi tạo biến tổng để tính tổng giá trị của giỏ hàng
    const rows = document.querySelectorAll('tbody tr'); // Lấy tất cả hàng trong bảng giỏ hàng
  
    rows.forEach(row => { // Duyệt qua từng hàng
      const quantity = parseInt(row.querySelector('.hh1').value) || 0; // Lấy số lượng từ ô nhập, nếu không có thì mặc định là 0
      const priceText = row.querySelector('.product-price').textContent.replace(' đ', ''); // Lấy giá sản phẩm và loại bỏ ký tự ' đ'
      
      // Chuyển đổi giá thành số thực
      const price = parseFloat(priceText.replace(/\./g, '').replace(',', '.')); // Chuyển đổi giá từ chuỗi sang số thực
      // - `replace(/\./g, '')`: Loại bỏ dấu chấm (ngăn cách hàng nghìn).
      // - `replace(',', '.')`: Thay thế dấu phẩy thành dấu chấm để chuyển đổi sang định dạng số thập phân.
      
      const rowTotal = quantity * price; // Tính tổng cho hàng bằng cách nhân số lượng với giá
      row.querySelector('.product-total').textContent = `${rowTotal.toLocaleString('vi-VN')} đ`; // Hiển thị tổng tiền cho hàng với định dạng Việt Nam
      total += rowTotal; // Cộng dồn vào tổng
    });
  
    document.querySelector('.cart-summary p').textContent = `${total.toLocaleString('vi-VN')} đ`; // Cập nhật tổng cộng giỏ hàng với định dạng Việt Nam
}