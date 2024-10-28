var trangthai1 = 0;
var trangthai2 = 0;

function themsanpham1() {
    if (trangthai1 === 0) {
        document.getElementById('themsanpham').innerHTML += `
        <tr class="sp1">
                        <td>Sản Phẩm 1</td>
                        <td class="sl"> <input type="number" value="1" onchange="update()"></td>
                        <td class="gia"> 100000</td>
                        <td class="tt">100000</td>
                        <td onclick="del(1)"><i class="fa-solid fa-circle-minus" ></i></td>
                    </tr>
        `;
        trangthai1 = 1; // Đánh dấu sản phẩm 1 đã được thêm vào giỏ hàng
    } else {
      
        var inputElement = document.querySelector('.sp1 input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}

function themsanpham2() {
    if (trangthai2 === 0) {
        document.getElementById('themsanpham').innerHTML += `
        <tr class="sp2">
                        <td>Sản Phẩm 2</td>
                        <td class="sl"> <input type="number" value="1" onchange="update()"></td>
                        <td class="gia"> 150000</td>
                        <td class="tt" >150000</td>
                        <td onclick="del(2)"><i class="fa-solid fa-circle-minus"></i class="del(2)"></td>
                    </tr>
        `;
        trangthai2 = 1; // Đánh dấu sản phẩm 2 đã được thêm vào giỏ hàng
    } else {
        
        var inputElement = document.querySelector('.sp2 input');
        inputElement.value = parseInt(inputElement.value) + 1; // Tăng số lượng
    }
    update(); // Cập nhật tổng giá trị giỏ hàng
}

function update() {
    var rows = document.querySelectorAll("tbody tr");
    var sumAll = 0;
    rows.forEach(function(row) {
        var quantity = row.querySelector(".sl input").value;
        var price = row.querySelector(".gia").textContent;
        var total = quantity * price;
        row.querySelector(".tt").textContent = total;
        sumAll += total;
    });
    document.getElementById("sum-all").textContent = sumAll;
}function del(i){
    document.getElementById('themsanpham').innerHTML='';
    if (i === 1) {
        trangthai1 = 0; // Reset trạng thái cho sản phẩm 1
    } else if (i=== 2) {
        trangthai2 = 0; // Reset trạng thái cho sản phẩm 2
    }
    
    update(); 
}