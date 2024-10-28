var t = 0;
var trangthai1 = 0;
var trangthai2 = 0;

function themsanpham1() {
    if (trangthai1 === 0) {
        document.getElementById('giohang').innerHTML += `
        <tr class="sp1">
                <td>
                    Macbok2
                   
                </td>
                <td class="price"> 2300</td>
                <td> <div>
                    <img width="50" height="50" src="https://laptoptv.vn/wp-content/uploads/2023/07/5-3-scaled.jpg" alt="">
                </div></td>
                <td class="quantity">
                    <input type="number" value="1" min="1" onchange="update()"> <br>
                    <i class="fa-regular fa-circle-xmark"onclick="del(1)"></i>

                </td>
                <td class="total"> 2300</td>
            </tr>
        `;
        trangthai1 = 1; // Đánh dấu sản phẩm 1 đã được thêm vào giỏ hàng
    } else {
      
        var inputElement = document.querySelector('.sp1 .quantity input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}

function themsanpham2() {
    if (trangthai2 === 0) {
        document.getElementById('giohang').innerHTML += `
        <tr class="sp2">
            <td>
                Dell
                
            </td>
            <td class="price">2500</td>
            <td> <div>
                    <img width="50" height="50" src="https://laptoptv.vn/wp-content/uploads/2023/07/5-3-scaled.jpg" alt="">
                </div></td>
            <td class="quantity">
                <input type="number" value="1" min="1" onchange="update()">
                <i class="fa-regular fa-circle-xmark"onclick="del(2)"></i>
            </td>
            <td class="total">25000</td>
        </tr>
        `;
        trangthai2 = 1; // Đánh dấu sản phẩm 2 đã được thêm vào giỏ hàng
    } else {
        
        var inputElement = document.querySelector('.sp2 .quantity input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}
function update() {
    var rows = document.querySelectorAll("tbody tr");
    var sumAll = 0; // Khởi tạo biến tổng
    rows.forEach(function(row) {
        var quantity = row.querySelector(".quantity input").value;
        var price = row.querySelector(".price").textContent;
        var total = quantity * price; // Tính thành tiền
        row.querySelector(".total").textContent = total; // Cập nhật thành tiền cho hàng
        sumAll += total;// Cộng dồn vào tổng

    });
    document.getElementById("sum-all").textContent = sumAll*0.5; // Cập nhật tổng cộng
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