
var trangthai1 = 0;
var trangthai2 = 0;

function themsanpham1() {
    if (trangthai1 === 0) {
        document.getElementById('themsanpham').innerHTML += `
        <tr class="giohang1">
            <td><img src="/img/anhlms.jpg" alt=""></td>
            <td><p>Sản Phẩm 1</p>
                <p class="tiensp" >100000</p>
            </td>
            <td class="soluong"><i class="fa-solid fa-caret-left"></i>
                <input type="text" value="2">
                <i class="fa-solid fa-caret-right"></i></td>
           <td class="tien"><input type="number" value="200000"></td>
            <td class="xoa"><i class="fa-solid fa-circle-minus"></i></td>
        </tr>
        `;
        trangthai1 = 1; // Đánh dấu sản phẩm 1 đã được thêm vào giỏ hàng
    } else {
      
        var inputElement = document.querySelector('.giohang1 .soluong input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}

function themsanpham2() {
    if (trangthai2 === 0) {
        document.getElementById('themsanpham').innerHTML += `
        <tr class="giohang2">
            <td><img src="/img/anhlms.jpg" alt=""></td>
            <td><p>Sản Phẩm 2</p>
                <p class="tiensp" >150000</p>
            </td>
            <td class="soluong"><i class="fa-solid fa-caret-left"></i>
                <input type="text" value="2">
                <i class="fa-solid fa-caret-right"></i></td>
           <td class="tien"><input type="number" value="150000"></td>
            <td class="xoa"><i class="fa-solid fa-circle-minus"></i></td>
        </tr>
        `;
        trangthai2 = 1; // Đánh dấu sản phẩm 2 đã được thêm vào giỏ hàng
    } else {
        
        var inputElement = document.querySelector('.giohang2 .soluong input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}
function update() {
    var rows = document.querySelectorAll("tbody tr");
    var sumAll = 0; // Khởi tạo biến tổng
    rows.forEach(function(row) {
        var quantity = row.querySelector(".soluong input").value;
        var price = row.querySelector(".tiensp").textContent;
        var total = quantity * price; // Tính thành tiền
        row.querySelector(".tien input").value = total; // Cập nhật thành tiền cho hàng
        sumAll += total;// Cộng dồn vào tổng

    });
    document.getElementById("sum-all").value = sumAll; // Cập nhật tổng cộng
}
function del(i){
    document.getElementById('giohang').innerHTML='';
    if (i === 1) {
        trangthai1 = 0; // Reset trạng thái cho sản phẩm 1
    } else if (i=== 2) {
        trangthai2 = 0; // Reset trạng thái cho sản phẩm 2
    }
    
    update(); 
}