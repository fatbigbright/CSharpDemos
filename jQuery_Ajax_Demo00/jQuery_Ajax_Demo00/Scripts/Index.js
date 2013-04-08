$(document).ready(function () {
   var list = $('#list');
   $(this).click(function(event){
       var e = event || window.event;
       var elem = e.srcElement || e.target;
       
       while(elem){
         if(elem.id == 'list'){
            return;
         }
         elem = elem.parentNode;
       }
       list.hide();
   });
   
   $('#another').click(function(){
      alert('Nothing');
   });
   
   $('#CustomerBrowser').click(function () {
      list.removeClass("loadedList").addClass("loadingList");
      list[0].innerText = "Loading...";
      $.ajax({
         url: 'Home/GetCustomer',
         dataType: 'json',
         error: function (error) {
            alert('Error occurs');
         },
         success: function (data) {
            list.show();
            list.empty();
            $.each(data, function (i, item) {
               var childElement = $("<span></span><br />");
               childElement.addClass("itemLeaved").text(item)
                           .mouseover(function(){
                              childElement.removeClass("itemLeaved").addClass("itemPointed");
                           })
                           .mouseout(function(){
                              childElement.removeClass("itemPointed").addClass("itemLeaved");
                           })
                           .click(function(){
                              //what is the difference between .attr('value', value) & .val(value)? 
                              //why the former may fail to update value of input?
                              
                              //$('#customer').attr('value', item);
                              //$('#customer')[0].value = item;
                              $('#customer').val(item);
                           });
               list.append(childElement);
            });
            list.removeClass("loadingList").addClass("loadedList");
         }
      });
   });
});