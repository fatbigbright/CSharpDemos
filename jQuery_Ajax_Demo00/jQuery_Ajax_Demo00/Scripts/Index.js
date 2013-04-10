$(document).ready(function () {
   var customers = $('#list');
   var games = $('#gameList');
   
   var lists = { $('#list'), $('#gameList') };
   $(this).click(function(event){
       var e = event || window.event;
       var elem = e.srcElement || e.target;
       
       while(elem){
         if(elem.id == 'list' || elem.id == 'game'){
            return;
         }
         elem = elem.parentNode;
       }
       customers.hide();
       games.hide();
   });
   
   
   /*
   $('#dropDown').mouseleave(function(){
      $('#list').hide();
   });
   
   $('#dropDown2').mouseleave(function(){
      $('#gameList').hide();
   });
   */

   setUpDropDownList('#customer', '#list', '#CustomerBrowser', 'Home/GetCustomer');

   setUpDropDownList('#game', '#gameList', '#gameBrowser', 'Home/GetGames');
   
});