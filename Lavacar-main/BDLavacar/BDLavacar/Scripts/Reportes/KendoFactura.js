$(function () {
    obtenerRegistrosPersonas();
});


/// funcion que obtiene los registros
// del metodo del controlador
// RetornaPersonasLista()
function obtenerRegistrosPersonas() {
    /////construir la dirección del método del servidor
    var urlMetodo = '/Factura/KendoFacturaLista'
    var parametros = {};
    var funcion = creaGridKendo;
    ///ejecuta la función $.ajax utilizando un método genérico
    //para no declarar toda la instrucción siempre
    ejecutaAjax(urlMetodo, parametros, funcion);
}
///encargada de crear el grid de kendo y mostrar
//los datos obtenidos al llamar al método
// RetornaListaClientes
function creaGridKendo(data) {
    $("#divKendoGrid").kendoGrid({
        dataSource: {
            data: data.resultado,
            pageSize: 10
        },
        pageable: true,
        columns: [{
            field: 'PApellido' + ' ' + 'SApellido' + ' ' +'Nombre_P',
            title: 'Nombre del Cliente'
        },
        {
            field: 'Cedula_P',
            title: 'Cedula'
        },
        {
            field: 'Tipo_S',
            title: 'Tipo'
        },
        {
            field: 'Cantidad_FVS',
            title: 'Cantidad'
        },
        {
            field: 'Total_F',
            title: 'Total'
            },


        ],
        filterable: true,
     
    });
}