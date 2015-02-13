<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ITACOWEB.Default" %>

<!DOCTYPE html >

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
    <title>Pagina ITACO</title>
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <script src="js/jquery-1.11.2.min.js"></script>
    <script src="js/bootstrap.min.js"></script>

    <script src="js/Comun/hashtable.js"></script>
    <script src="js/Comun/json2.min.js"></script>
    <script src="js/Comun/String.js"></script>
    <script src="js/Comun/jquery.ajaxdotnet.3.js"></script>
    <script src="js/Comun/jquery.ajaxdotnet.intellisense.js"></script>

    <script src="js/Productos/Producto.js"></script>

    <script type="text/javascript">
        var filas = 0;
        $(document).ready(function () {

            ObtenerProductos();

            $("#btnAdicionarProductos").click(function () {

                var tbContenedor = $("#tbContenedorProductos");
                var trFilaPrpducto = $("#filaRegistroProducto").clone();

                trFilaPrpducto.show();
                trFilaPrpducto.attr("id", "filaRegistroProducto_" + filas);

                var imgBorrar = trFilaPrpducto.find("img");
                imgBorrar.attr("id", "imgEliminarProducto_" + filas);

                var lblBorrar = trFilaPrpducto.find("b");
                lblBorrar.attr("id", "lblProductoSeleccionado_" + filas);

                var inputValorProd = trFilaPrpducto.find("input");
                inputValorProd.attr("id", "txtValorProducto_" + filas);

                var ulMenuProductos = trFilaPrpducto.find("ul");
                ulMenuProductos.attr("id", "ulMenuProductos_" + filas);


                imgBorrar.click(function (e) {
                    var id = $(e)[0].target.id.split('_')[1];
                    var trFilaPrpducto1 = $("#filaRegistroProducto_" + id);

                    trFilaPrpducto1.remove();
                    alert("Se ha quitado el registro exitosamente.");
                });

                tbContenedor.append(trFilaPrpducto);
            });

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="contenedorPrincipal">
            <div id="menuPrincipal">
                <nav class="navbar navbar-default">
                    <div class="container-fluid">
                        <!-- Brand and toggle get grouped for better mobile display -->
                        <div class="navbar-header">
                            <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                                <span class="sr-only">Toggle navigation</span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                                <span class="icon-bar"></span>
                            </button>
                            <a class="navbar-brand" href="Default.aspx">ItaCO</a>
                        </div>

                        <!-- Collect the nav links, forms, and other content for toggling -->
                        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                            <ul class="nav navbar-nav">
                                <li class="active"><a href="#">Registro <span class="sr-only">(current)</span></a></li>
                                <li><a href="#">Ver Consolidado Ventas</a></li>
                                <%--<li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown <span class="caret"></span></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Action</a></li>
                                        <li><a href="#">Another action</a></li>
                                        <li><a href="#">Something else here</a></li>
                                        <li class="divider"></li>
                                        <li><a href="#">Separated link</a></li>
                                        <li class="divider"></li>
                                        <li><a href="#">One more separated link</a></li>
                                    </ul>
                                </li>--%>
                            </ul>
                            <%--                            <div class="navbar-form navbar-left" role="search">
                                <div class="form-group">
                                    <input type="text" class="form-control" placeholder="Search" />
                                </div>
                                <button type="submit" class="btn btn-default">Submit</button>
                            </div>
                            <ul class="nav navbar-nav navbar-right">
                                <li><a href="#">Link</a></li>
                                <li class="dropdown">
                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-expanded="false">Dropdown <span class="caret"></span></a>
                                    <ul class="dropdown-menu" role="menu">
                                        <li><a href="#">Action</a></li>
                                        <li><a href="#">Another action</a></li>
                                        <li><a href="#">Something else here</a></li>
                                        <li class="divider"></li>
                                        <li><a href="#">Separated link</a></li>
                                    </ul>
                                </li>
                            </ul>--%>
                        </div>
                        <!-- /.navbar-collapse -->
                    </div>
                    <!-- /.container-fluid -->
                </nav>
            </div>
            <div class="container">
                <div class="row">
                    <div class="col-xs-12 col-sm-12 col-md-12" style="text-align: right">
                        <button type="button" class="btn btn-primary">Registro de las ventas diarias (Salvar)</button>
                    </div>

                    <div class="col-xs-12 col-sm-12 col-md-12" style="text-align: right">
                    </div>
                    <div class="col-xs-6 col-sm-6 col-md-6">
                        <div style="float: left">
                            Valor Venta 
                        </div>
                        <div style="float: right; text-align: center">
                            <input type="text" value="$12345678" />
                        </div>
                    </div>
                    <div class="col-xs-6 col-sm-6 col-md-6">
                        <div style="float: left">
                            Valor Total  
                        </div>
                        <div style="float: right; text-align: center">
                            <input type="text" value="$12345678" />
                        </div>
                    </div>
                    <br />
                    <div class="col-xs-12 col-sm-12 col-md-12">
                        <table class="table table-bordered">
                            <thead>
                                <tr>
                                    <td colspan="2">
                                        <h1>Registro de productos</h1>
                                    </td>
                                    <td style="align-content: center; text-align: center; margin: auto">
                                        <button type="button" class="btn btn-primary" id="btnAdicionarProductos">Adicionar</button>
                                    </td>
                                </tr>
                            </thead>
                            <tbody id="tbContenedorProductos">
                                <tr id="filaRegistroProducto" style="display: none;">
                                    <td style="align-content: center; text-align: center">
                                        <div class="btn-group">
                                            <button type="button" class="btn btn-default dropdown-toggle" data-toggle="dropdown" aria-expanded="false">
                                                Productos <span class="caret"></span>
                                            </button>
                                            <ul class="dropdown-menu" role="menu" id="ulMenuProductos">
                                                <li id="0"><a href="#" >--Seleccione una opcion--</a></li>
                                            </ul>
                                        </div>
                                    </td>
                                    <td style="align-content: center; text-align: center">
                                        <table>
                                            <tr>
                                                <td><b id="lblProductoSeleccionado"></b></td>
                                                <td>
                                                    <input id="txtValorProducto_" type="text" value="" readonly="true" title="Valor del producto" disabled="disabled" /></td>
                                            </tr>
                                        </table>
                                    </td>
                                    <td style="align-content: center; text-align: center">
                                        <img id="imgEliminarProducto" src="Imagenes/virus_recycler.png" alt="Eliminar Producto" class="img-circle" style="cursor: pointer" />
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
