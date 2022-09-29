// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function VerInfoPais(nomPais)
{
    $.ajax(
        {
            type: 'POST',
            dataType: 'JSON',
            url: '/Home/DetallePais',
            data: { Pais: nomPais },
            success:
                function (response)
                {
                    $("#NombrePais").text(response.nombre);
                    $("#ImagenPais").attr("src","/"+response.imgBandera);
                    $("#PoblacionPais").html("<b>Población: </b>"+response.poblacion);
                    $("#PoblacionPais").html("<b>Día de la independencia: </b>"+response.fechaIndependencia.substr(0,10));
                    $("#TurismoPais").html("<b>Atractivos turísticos: </b>"+response.atractivosTuristicos);
                    $("#HimnoPais").html("<p><b>Himno nacional: </b></p><audio controls><source src=/"+ response.himno + " type='audio/mp3'></audio>")
                }
        }
    );
}