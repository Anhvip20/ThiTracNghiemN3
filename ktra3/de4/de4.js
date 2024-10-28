const quantityInput = document.querySelector('.hh1');

quantityInput.addEventListener('input', function() {
  const value = this.value;
  if (value === '' || isNaN(value) || parseInt(value) < 0) {
    this.classList.add('error');
    alert('Vui lòng nhập số lượng là một số nguyên dương.');
  } else {
    this.classList.remove('error');
    // Cập nhật tổng tiền ở đây
     
  }
});
function update() {
  var rows = document.querySelectorAll(".sp");
  var sumAll = 0; // Khởi tạo biến tổng
  rows.forEach(function(row) {
      var quantity = row.querySelector(".hh1").value;
      var price = row.querySelector(".gia").textContent;
      var total = quantity * price; // Tính thành tiền
      row.querySelector(".tiencuoi").textContent = total; // Cập nhật thành tiền cho hàng
      sumAll += total;// Cộng dồn vào tổng

  });
  document.getElementById("tongcong").textContent = sumAll; // Cập nhật tổng cộng
}
// function del(event) {
//   const productToDelete = event.target.closest('.sp'); // Tìm sản phẩm cần xóa
//   if (productToDelete) {
//       productToDelete.remove(); // Xóa sản phẩm khỏi giỏ hàng
//       update(); // Cập nhật tổng sau khi xóa
//   }
// }
function del(i){
  document.querySelector('.sp'+i).innerHTML='';
}