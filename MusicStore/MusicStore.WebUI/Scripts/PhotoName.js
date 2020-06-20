$(document).ready(function () {
    $('input[type="file"]').change(function (e) {
        var fileName = e.target.files[0].name;
        var uploadFileInfo = "The file " + fileName + " has been selected.";
        document.getElementById("upload-file-info").innerHTML = uploadFileInfo;
    });
});
