$(document).ready(function () {
   var customers = $('#list');
   var games = $('#gameList');
   var remoteGames = $('#remoteGameList');
   
   $('#another').click(function(){
      customers.hide();
      games.hide();
      remoteGames.hide();
   });
   
   $(this).click(hideDropDownList);

   setUpDropDownList('#customer', '#list', '#CustomerBrowser', 'Home/GetCustomer');

   setUpDropDownList('#game', '#gameList', '#gameBrowser', 'Home/GetGames');
   
   setUpDropDownList('#remoteGame', '#remoteGameList', '#remoteGameBrowser', 'Home/GetRemoteGames');
   //cross-site access may be denied and returned status code 0, needs modification
   //setUpDropDownListFromOtherSite('#remoteGame', '#remoteGameList', '#remoteGameBrowser', 'http://localhost:3000/getData');
});