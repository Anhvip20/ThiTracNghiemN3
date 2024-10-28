// Mảng ảnh cho từng màu sắc
const images = {
    silver: [
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2022_12_7_638060331277536556_hp-14s-dq-bac-1.jpg",
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2022_12_7_638060331276811554_hp-14s-dq-bac-3.jpg",
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2022_12_7_638060331277213439_hp-14s-dq-bac-4.jpg"
    ],
    black: [
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2024_1_22_638415364357701848_acer-aspire-lite-al15-51m-55nb-i5-1155g7-xam-1.jpg",
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2024_1_22_638415364357701848_acer-aspire-lite-al15-51m-55nb-i5-1155g7-xam-2.jpg",
        "https://cdn2.fptshop.com.vn/unsafe/384x0/filters:quality(100)/2024_1_22_638415364356608094_acer-aspire-lite-al15-51m-55nb-i5-1155g7-xam-4.jpg"
    ]
};
// Các biến điều khiển trạng thái
let currentColor = 'silver'; // Màu sắc mặc định
let currentIndex = 0; // Vị trí ảnh hiện tại

// Phần tử HTML
const mainImage = document.getElementById("main-image");
const sl1 = document.getElementById("sl1");
const sl2 = document.getElementById("sl2");

// Hàm cập nhật ảnh
function updateImage() {
    mainImage.src = images[currentColor][currentIndex];
    sl1.textContent = `${currentIndex + 1}`;
    sl2.textContent = `${images[currentColor].length}`;
}

// Hàm xử lý khi nhấn nút trái
function prevImage() {
    currentIndex = (currentIndex - 1 + images[currentColor].length) % images[currentColor].length;
    updateImage();
}

// Hàm xử lý khi nhấn nút phải
function nextImage() {
    currentIndex = (currentIndex + 1) % images[currentColor].length;
    updateImage();
}

// Hàm xử lý khi chọn màu
function selectColor(color) {
    currentColor = color;
    currentIndex = 0;
    updateImage();
}

// Cập nhật ảnh đầu tiên khi tải trang
updateImage();

