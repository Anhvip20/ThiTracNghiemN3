var imgs =['https://ananas.vn/wp-content/uploads/pro_AET00001_1.jpg',
    'https://ananas.vn/wp-content/uploads/pro_AET00001_2.jpg',
    'https://ananas.vn/wp-content/uploads/pro_AET00001_3.jpg',
    'https://ananas.vn/wp-content/uploads/pro_AET00001_4.jpg',
    'https://ananas.vn/wp-content/uploads/pro_AET00001_5.jpg',
    'https://ananas.vn/wp-content/uploads/pro_AET00001_6.jpg'
];
function next(){
    var a= document.getElementById('img1').getAttribute('src');
    var b= document.getElementById('img2').getAttribute('src');
    var c= document.getElementById('img3').getAttribute('src');
    var d= document.getElementById('img4').getAttribute('src');
    if ( a==imgs[0] && b==imgs[1] && c==imgs[2] && d==imgs[3]) {
        document.getElementById('img1').setAttribute('src',imgs[1]);
        document.getElementById('img2').setAttribute('src',imgs[2]);
        document.getElementById('img3').setAttribute('src',imgs[3]);
        document.getElementById('img4').setAttribute('src',imgs[4]);
    } else if ( a==imgs[1] && b==imgs[2] && c==imgs[3] && d==imgs[4]) {
        document.getElementById('img1').setAttribute('src',imgs[2]);
        document.getElementById('img2').setAttribute('src',imgs[3]);
        document.getElementById('img3').setAttribute('src',imgs[4]);
        document.getElementById('img4').setAttribute('src',imgs[5]);
    } 
}
function prev(){
    var a= document.getElementById('img1').getAttribute('src');
    var b= document.getElementById('img2').getAttribute('src');
    var c= document.getElementById('img3').getAttribute('src');
    var d= document.getElementById('img4').getAttribute('src');
    if ( a==imgs[1] && b==imgs[2] && c==imgs[3] && d==imgs[4]) {
        document.getElementById('img1').setAttribute('src',imgs[0]);
        document.getElementById('img2').setAttribute('src',imgs[1]);
        document.getElementById('img3').setAttribute('src',imgs[2]);
        document.getElementById('img4').setAttribute('src',imgs[3]);
    } else if ( a==imgs[2] && b==imgs[3] && c==imgs[4] && d==imgs[5]) {
        document.getElementById('img1').setAttribute('src',imgs[1]);
        document.getElementById('img2').setAttribute('src',imgs[2]);
        document.getElementById('img3').setAttribute('src',imgs[3]);
        document.getElementById('img4').setAttribute('src',imgs[4]);
    } 
}
function click(i) {
    // Lấy ảnh dựa trên ID của ảnh phụ được click
    var clickedImg = document.getElementById('img' + i).getAttribute('src');
    
    // Đặt src của ảnh chính thành src của ảnh phụ đã click
    document.getElementById('anh1').setAttribute('src', clickedImg);
}
