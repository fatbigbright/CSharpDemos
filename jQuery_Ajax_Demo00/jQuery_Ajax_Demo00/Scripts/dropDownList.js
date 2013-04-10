//textboxID, dropDownDivID, browseButtonID should in the form of '#XXXX'
function setUpDropDownList(textboxID, dropDownDivID, browseButtonID, requestUrl){
   var list = $(dropDownDivID);
   $(browseButtonID).click(function () {
      list.removeClass("loadedList").addClass("loadingList");
      list[0].innerText = "Loading...";
      $.ajax({
         url: requestUrl,
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
                              
                              //$(textboxID).attr('value', item);
                              //$(textboxID)[0].value = item;
                              $(textboxID).val(item);
                              list.hide();
                           });
               list.append(childElement);
            });
            list.removeClass("loadingList").addClass("loadedList");
         }
      });
   });
}
