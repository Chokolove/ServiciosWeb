var Encuesta = function(){
    var source   = $("#quiz-template").html();
    var template = Handlebars.compile(source);


    var html = '';
    App.request.post('/Encuesta/GetAll',function(response){

        for(var key in response.data){
            var item = response.data[key];
            
            var context = {name: item.NomEncuesta, username:item.Usuario.NomUsu, time: item.FechaCreacion, count_quiz:item.cantPreg};
            html += template(context);
        }
        $('#list-quiz').html(html)
    });
}

$(function(){

    new Encuesta();

});
    
  
     
