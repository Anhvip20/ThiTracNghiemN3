var slide =[`<div class="spi ">
                    <img src="https://ananas.vn/wp-content/uploads/Pro_AHCS012_1.jpg" alt="">
                    <div class="spi_chu">
                        <p>High Crew Socks - Ananas Daily Things-Laurel Oak</p>                  
                        <p>95.000 VND</p>
                        <button>Thêm</button>
                    </div>
                </div>`,
                `<div class="spi">
                    <img src="https://ananas.vn/wp-content/uploads/pro_ALB016_1_Fix.jpeg" alt="">
                    <div class="spi_chu">
                        <p>Blank Shoelaces-Evening Primrose</p>
                        <p>95.000 VND</p>
                        <button>Thêm</button>
                    </div>
                </div>`,
                `<div class="spi">
                    <img src="https://ananas.vn/wp-content/uploads/Pro_AHCS007_1-500x500.jpg" alt="">
                    <div class="spi_chu">
                        <p>High Crew Socks - Ananas Daily Things Sunny Lime </p>
                        <p>95.000 VND</p>
                        <button>Thêm</button>
                    </div>
                </div>`,
                `<div class="spi">
                    <img src="https://ananas.vn/wp-content/uploads/pro_ALB009_1-500x500.jpg" alt="">
                    <div class="spi_chu">
                        <p>Blank Shoelaces Black </p>
                        <p>95.000 VND</p>
                        <button>Thêm</button>
                    </div>
                </div>`];
                let currentIndex = 0;

                function updateCarousel() {
                    // Lấy tất cả các sản phẩm trong carousel
                    const dssp = document.querySelector('.dssp');
                
                    // Xóa các sản phẩm cũ
                    dssp.querySelectorAll('.spi').forEach(item => {
                        item.remove();
                    });
                
                    // Thêm sản phẩm mới
                    for (let i = 0; i < 2; i++) {
                        const newIndex = (currentIndex + i) % slide.length;
                        const newSlide = document.createElement('div');
                        newSlide.innerHTML = slide[newIndex];
                        dssp.insertBefore(newSlide.firstChild, dssp.querySelector('.muiten.a2'));
                    }
                }
                
                function prevImage() {
                    currentIndex = (currentIndex - 2 + slide.length) % slide.length;
                    updateCarousel();
                }
                
                function nextImage() {
                    currentIndex = (currentIndex + 2) % slide.length;
                    updateCarousel();
                }
                
                // Khởi tạo carousel
                updateCarousel();
                function updateTotal() {
                    // Lấy giá từ phần gh1-tien
                    const priceText = document.getElementById('item-price').innerText;
                    const price = parseInt(priceText.replace(/\./g, '').replace(' VND', ''));
                
                    // Lấy số lượng đã chọn
                    const quantity = parseInt(document.getElementById('quantity').value);
                
                    // Tính tổng
                    const total = price * quantity;
                
                    // Cập nhật hiển thị tổng
                    document.querySelector('.dh2 p:nth-child(2)').innerText = total.toLocaleString() + ' VND';
                    document.querySelector('.dh-tt p:nth-child(2)').innerText = total.toLocaleString() + ' VND';

                }
                
                // Gọi hàm để thiết lập tổng khi tải trang
                updateTotal();
                
                function applyPromoCode() {
                    // Lấy giá trị của mã khuyến mãi
                    const promoCode = document.getElementById('promo-code').value;
                
                    // Kiểm tra mã khuyến mãi
                    if (promoCode === 'BGN') {
                        // Lấy giá trị tạm tính
                        const subtotalText = document.querySelector('.dh-tt p:nth-child(2)').innerText;
                        const subtotal = parseInt(subtotalText.replace(/\./g, '').replace(' VND', ''));
                
                        // Tính giảm giá
                        const discount = subtotal * 0.10;
                
                        // Cập nhật giá trị giảm giá trong dh2
                        const discountDisplay = document.querySelector('.dh2:nth-child(2) p:nth-child(2)');
                        discountDisplay.innerText = discount.toLocaleString() + ' VND';
                
                        // Cập nhật tạm tính sau khi áp dụng mã
                        const totalAfterDiscount = subtotal - discount;
                        document.querySelector('.dh-tt p:nth-child(2)').innerText = totalAfterDiscount.toLocaleString() + ' VND';
                    } else {
                        alert('Mã khuyến mãi không hợp lệ!');
                    }
                }