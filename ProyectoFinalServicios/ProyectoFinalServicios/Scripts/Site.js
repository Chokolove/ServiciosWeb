//Object application
App = new (function(){

    this.request = {
        post : function(url, callback){
               $.ajax({
                url : url,
                type:'POST',
                success : function(response){
                    callback(response);
                }
               });
        },
        get : function(callback){
        
        
        }
    }
    this.uuid = function(){
      function s4() {
        return Math.floor((1 + Math.random()) * 0x10000)
          .toString(16)
          .substring(1);
      }
      return s4() + s4() + '-' + s4() + '-' + s4() + '-' + s4() + '-' + s4() + s4() + s4();
    }
    this.template = function(id){
        var source   = $(id).html();
        var template = Handlebars.compile(source);
        return template;
    }
    
})();


