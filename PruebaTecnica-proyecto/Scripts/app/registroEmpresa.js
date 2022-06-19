
/*VISUALIZR IMAGEN LOGO*/
$("#imagen").change(function () {
    var imagen = this.file[0];
    if (imagen["type"] != "image/jpg" && imagen["type"] != "image/png") {
        $(#imagen).val("");
        $(".previsualizar").attr("src", "../Content/img/logo.png");
        alert("Debe Subir Una Imagen En Formato JPG O PNG");
    } else if (imagen["size"] > 2000000) {
        $(#imagen).val("");
        $(".previsualizar").attr("src", "../Content/img/logo.png");
        alert("La Imagen Debe Ser Menor A 2MB");
    } else {
        var datosImagen = new FileReader;
        datosImagen.readAsDataUrl(imagen)
        $(datosImagen).on("load", function (e) {
            var rutaImagen = e.target.result;
            $(".previsualizar").attr("src", rutaImagen)
        })
    }
})