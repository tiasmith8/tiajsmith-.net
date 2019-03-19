// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function openQRCamera(node) {
    var reader = new FileReader();
    reader.onload = function () {
        node.value = "";
        qrcode.callback = function (res) {
            if (res instanceof Error) {
                alert("No QR code found. Please make sure the QR code is within the camera's frame and try again.");
            } else {
                node.parentNode.previousElementSibling.value = res;
            }
        };
        qrcode.decode(reader.result);
    };
    reader.readAsDataURL(node.files[0]);
}
