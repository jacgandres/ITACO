
var productos = new Array();

function ObtenerProductos()
{
    var url = window.location.href.toString().split("?")[0].split("#")[0] + "/ObtenerProductos";

    $.ajax({
        url: url,
        type: 'POST', 
        dataType: 'json',
        contentType: "application/json;charset=utf-8",
        success: function (response) {
            productos = response.d;
            var drpProductos = $("#ulMenuProductos");
            var itemPlantilla = "<li id='liItem-'><a id='aItem_' onclick='onclickItemProducto(+);' href='#'>*</a></li> ";
            $(productos).each(function (obj) {

                var tmp = itemPlantilla.replace("-", '-' + productos[obj].IdProducto)
                    .replace("_", '_' + productos[obj].IdProducto)
                    .replace("+",   productos[obj].IdProducto )
                    .replace("*", productos[obj].NombreProducto);

                var itemDrp = $(tmp); 

                drpProductos.append(itemDrp);
            });
        },
        error: function (err) { 
            alert(err.responseText);
        }
    });
}

function onclickItemProducto(ValorProducto)
{
    alert(ValorProducto);
}