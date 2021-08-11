function ShowImagePreview(ImageUploader, previewImage) {
    if (ImageUploader.files && ImageUploader.files[0])
        var reader = new FileReader();
    reader.onload = function (e) {
        $(previewImage).attr('src', e.target.result);
    }
    reader.readAsDataURL(ImageUploader.files[0]);
}
