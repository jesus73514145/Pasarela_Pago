# Pasarela_Pago
Formulario de pasarela de pago interactiva


ASI SE VERIA

![image](https://github.com/jesus73514145/Pasarela_Pago/assets/114105503/51e0bcd5-1850-43e0-8c2b-3d3edc09f84c)

![image](https://github.com/jesus73514145/Pasarela_Pago/assets/114105503/b2ba83b7-3839-4586-bab6-949bfb37e6ae)

Y EN LA CONSOLA SE IMPRIMEN ALGUNOS DATOS PARA PRUEBAS 

![image](https://github.com/jesus73514145/Pasarela_Pago/assets/114105503/1c8ea053-6f9e-408d-a291-4485bc514aeb)



// PARA QUE FUNCIONE CORRECTAMENTE ESTE FORMULARIO SE BE DE TENER EN CUENTA LO SIGUIENTE:

-- AGREGAR EL STYLES2.CSS QUE ESTA EN LA CARPETA DE WWWROOT-CSS-STYLES2.CSS

-- AGREGAR EL JAVASCRIPT QUE ESTA EN LA CARPETA DE WWWROOT-JS-SCRIPT.JS

-- EN EL _Layout.cshtml agregue esto que es importante
<script src='https://cdnjs.cloudflare.com/ajax/libs/vue/2.6.10/vue.min.js' asp-append-version="true"></script>
    <script src='https://unpkg.com/vue-the-mask@0.11.1/dist/vue-the-mask.js' asp-append-version="true"></script>
    <script src="~/js/script.js" asp-append-version="true"></script>

    sin eso no funcionaria la pagina lainteractividad que hay en la tarjeta

    y tambien agregue la vista de Pasarela.cshtml como se ve ahi no le modifique nada asi se debe de poner 