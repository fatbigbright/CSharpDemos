$(document).ready(function () {
   $('#hideList').click(function () {
      var list = $('#list');
      list.empty();
      list.hide();
   });
   $('#showList').click(function () {
      var list = $('#list');
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