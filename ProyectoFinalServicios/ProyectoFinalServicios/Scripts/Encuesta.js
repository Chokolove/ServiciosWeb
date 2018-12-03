Encuesta = function(){
    
   var urls = {
        
        updateQuiz : '/Encuesta/UpdateQuiz',
        listAll : '/Encuesta/GetAll',
        listTypeQuestion : '/Encuesta/GetTypeQuestion'
        
    }
    
    var data = {
        meta : {qDefault:'Pregunta'},
        name : 'Encuesta sin nombre',
        questions:{}
    }
    
    this.List = {
        Init : function(){
            var html = '';
            App.request.post(urls.listAll,function(response){
                var tmp = App.template('#quiz-template')
                for(var key in response.data){
                    var item = response.data[key];
                    
                    var context = {name: item.NomEncuesta, username:item.Usuario.NomUsu, time: item.FechaCreacion, count_quiz:item.cantPreg};
                    html += tmp(context);
                }
                $('#list-quiz').html(html)
            });
        }
    }
    
    this.Create = {
        addQuestion : function(id, title, typeQuestion){
            data.questions[id] = {title : title, type:typeQuestion, options:{}};
        },
        removeQuestion : function(id){
            delete data.questions[id];
        },
        Init : function(){
            $('#slide-publish').on('change', function(){
                console.log(data);
            });
            //send data temp
           
            
            var ajax_call = function() {
               App.request.post(urls.updateQuiz, function(response){
                });
            };

            var interval = 1000 * 60 * 0.10; // where X is your every X minutes

            setInterval(ajax_call, interval);
        },
        addEvents : function(){
        },
        addOption : function(uuid,id_option, option){
            data.questions[uuid].options[id_option] = (option);
        },
        removeOption : function(uuid, id_option){
            delete data.questions[uuid].options[id_option]
        },
        typeTemp: function(uuid){
           var c = $('#list-questions');
           var el = c.find('#'+uuid)
           var typeText = '#type-text-template';
           var typeCheckbox = '#type-checkbox-template';
           var typeOptions = '#type-options-template';
           
           var nmTmp = false;
           var type = data.questions[uuid].type;
           if(type == 1){
            nmTmp = typeText;
           }else if(type == 2){
            nmTmp = typeOptions;
           }else if(type == 3){
            nmTmp = typeCheckbox;
           }
           if(!nmTmp)
                return;
           var tmp = App.template(nmTmp)
           return tmp;
           
        },
        tmpOption : function(uuid){
            
            var optionRadio = '#type-item-options-template';
            var optionCheckbox = '#type-item-checkbox-template';
            var type = data.questions[uuid].type;
            var tmp = false;
            if(type == 2){
                tmp = App.template(optionRadio);
            }else if(type == 3){
                tmp = App.template(optionCheckbox);
            }else{
            return;}
            return tmp;
            
        },
        fillData : function(callback){
            App.request.post(urls.listTypeQuestion, function(response){
                callback(response);
            })
        }
    }
    this.events = function(){
        var me = this;
        $('#quiz-title').on('input', function(){
            data.name = $(this).val();
        });
        $('#add-question').on('click', function(){
            var tmp = App.template('#create-template');
            
            var cnt = $('.list-questions');
            
            me.Create.fillData(function(response){
                var id = App.uuid();
                var html = tmp({id:id, types : response.data, questionDefault:data.meta.qDefault});
                cnt.append(html);
                me.Create.addQuestion( id, data.meta.qDefault,1);
                var prop = $('#'+id);
                prop.find('.questionTitle').off('input').on('input', function(){
                    var t = $(this);
                    var uuid = t.closest('.custom-input').attr('id');
                    data.questions[uuid].title = t.val();
                });
                prop.find('.action-delete').off('click').on('click', function(){
                    var t = $(this);
                    t.closest('.custom-input').remove();
                    me.Create.removeQuestion(id);
                    return false;
                });
                 prop.find('.questionType').off('change').on('change', function(){
                    var t = $(this);
                    var uuid = t.closest('.custom-input').attr('id');
                    data.questions[uuid].type = t.val();
                    prop.find('.list-options').html(me.Create.typeTemp(uuid))
                    prop.find('.add-option').off('click').on('click', function(){
                        var tmp = me.Create.tmpOption(uuid);
                        prop.find('ul').append(tmp);
                        var text =  prop.find('.textOption').val();
                        var id_option = App.uuid();
                        me.Create.addOption(uuid, id_option ,{id:App.uuid(), label:text})
                        
                        prop.find('.textOption').off('input').on('input', function(){
                            var t = $(this);
                            data.questions[uuid].options[id_option].label = t.val();
                        });
                        prop.find('.delete-option').off('click').on('click', function(){
                            $(this).closest('li').remove();
                            me.Create.removeOption(uuid, id_option);
                            return false;
                        });   
                        return false;                     
                    });
                    return false;
                }).trigger('change');
            });
            return false;   
        });
    }
}


G_Encuesta = new Encuesta();
G_Encuesta.events();

    
  
     
