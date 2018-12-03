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
    
})();


