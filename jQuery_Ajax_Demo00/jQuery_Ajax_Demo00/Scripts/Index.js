$(document).ready(function () {
   var customers = $('#list');
   var games = $('#gameList');
   
   $('#another').click(function(){
      customers.hide();
      games.hide();
   });
   
   $(this).click(hideDropDownList);

   setUpDropDownList('#customer', '#list', '#CustomerBrowser', 'Home/GetCustomer');

   setUpDropDownList('#game', '#gameList', '#gameBrowser', 'Home/GetGames');
   
});