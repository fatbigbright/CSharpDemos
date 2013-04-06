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
       list.empty();
   });
   
   $('#CustomerBrowser').click(function () {
      list.empty();
      list.show();
      list.removeClass("loadedList").addClass("loadingList");
      list[0].innerText = "Loading...";
      $.ajax({
         url: 'Home/GetCustomer',
         dataType: 'json',
         error: function (error) {
            alert('Error occurs');
         },
         success: function (data) {
            list.empty();
            $.each(data, function (i, item) {
               list[0].innerHTML += item + "<br />";
            });
            list.removeClass("loadingList").addClass("loadedList");
         }
      });
   });
});