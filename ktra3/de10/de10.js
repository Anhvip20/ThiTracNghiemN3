var sl = document.getElementById('sll');

function tang(button) {
    const sl = button.previousElementSibling; // Lấy trường input trước nút
    var sll = parseInt(sl.value); // Sửa 'parentInt' thành 'parseInt' để chuyển chuỗi thành số
    sl.value = sll + 1; // Tăng giá trị
    updatePrice()
}

function giam(button) {
    const sl = button.nextElementSibling;// Lấy trường input sau  nút
    var sll = parseInt(sl.value); // Sửa 'parentInt' thành 'parseInt' để chuyển chuỗi thành số
    if (sll <= 1) { // Đảm bảo không giảm giá trị xuống dưới 1
        alert("Không thể nhỏ hơn 1!");
    } else {
        sl.value = sll - 1; // Giảm giá trị
    }
    updatePrice()
}
function updatePrice() {
    let totalPrice = 0;
    let totalDiscount = 0;

    // Lấy tất cả các sản phẩm
    document.querySelectorAll('.sanpham').forEach(product => {
        const quantity = parseInt(product.querySelector('input[type="text"]').value); // Lấy số lượng sản phẩm
        const priceElement = product.querySelector('.giam'); // Lấy phần tử chứa giá
        const discountElement = product.querySelector('.tt'); // Lấy phần tử chứa giá giảm

        const price = parseInt(priceElement.textContent.replace(/\./g, '').replace(' đ', '')); // Chuyển giá thành số
        const discount = parseInt(discountElement.textContent.replace(/\./g, '').replace(' đ', '')); // Chuyển giá giảm thành số

        totalPrice += price * quantity; // Tính tổng tiền cho tất cả sản phẩm
        totalDiscount += (price - discount) * quantity; // Tính tổng khuyến mãi cho tất cả sản phẩm
    });

    // Cập nhật tổng tiền và tổng khuyến mãi
    document.querySelector('.order-summary .zz').textContent = formatCurrency(totalPrice);
    document.querySelector('.order-summary .nn .price').textContent = formatCurrency(totalDiscount);

    // Tính toán tổng số tiền cần thanh toán và cập nhật nó
    const totalDue = totalPrice - totalDiscount;
    document.querySelector('.price-red').textContent = formatCurrency(totalDue);
}

// Hàm định dạng tiền tệ
function formatCurrency(value) {
    return value.toLocaleString('vi-VN') + ' đ';
}

// Khởi tạo tính toán khi tải trang
updatePrice();
function xoa() {
    // Sử dụng event để tìm phần tử nút xóa được nhấn
    const button = event.target.closest('.xoa1');

    // Lấy phần tử sản phẩm cha của nút xóa
    const productElement = button.closest('.sanpham');
    
    // Xóa sản phẩm khỏi danh sách
    productElement.remove();

    // Cập nhật lại tổng giá và khuyến mãi sau khi xóa sản phẩm
    updatePrice();
}
function xoaall() {
    // Lấy tất cả các phần tử có class `sanpham`
    const allProducts = document.querySelectorAll('.sanpham');
    
    // Duyệt qua tất cả sản phẩm và xóa từng sản phẩm
    allProducts.forEach(product => product.remove());

    // Cập nhật lại tổng giá và khuyến mãi sau khi xóa toàn bộ sản phẩm
    updatePrice();
}
// Hàm đếm và cập nhật số lượng sản phẩm được chọn
function updateSelectedCount() {
    // Đếm số sản phẩm được chọn
    const selectedCount = document.querySelectorAll('.sanpham .check input[type="checkbox"]:checked').length;
    
    // Cập nhật số lượng vào phần tử .tong_so_luong
    document.querySelector('.tong_so_luong').textContent = selectedCount;
}

// Thêm sự kiện cho mỗi checkbox để cập nhật số lượng khi người dùng chọn hoặc bỏ chọn
document.querySelectorAll('.sanpham .check input[type="checkbox"]').forEach(checkbox => {
    checkbox.addEventListener('change', updateSelectedCount);
});

// Gọi hàm khi trang tải lần đầu để hiển thị số lượng chọn ban đầu
updateSelectedCount();