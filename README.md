## This repository contains all my C# demos that is supposed to be useful.

1. MultiThreadDemo00
   Output ABABAB... by using MutiThreading, make sure the format is ^(AB)+$. Build under VS2010.
   
2. RegexExpressionTester
   Given a regex Expression and a string, to test whether the string matches the expression. Built under VS2010, by using WinForm. The label can fade out after it appears. Created and built under MonoDevelop.
   
3. jQuery_Ajax_Demo00
   A demo that implements a list using ajax and jQuery to load data from server(maybe server cache would be added in the future). Created and built under MonoDevelop. 
    * Mono may throw an InvalidCastException when using JsonResult class which is calling JavaScriptSerializer. Refer to the link: [Bug #664813](https://bugzilla.novell.com/show_bug.cgi?id=664813) which replies a solution.
    * `.add('value', value)` may fail if user have manually input content to `<input></input>` element. Using `.val(value)` to update content `<input></input>` element can avoid this issue.
    * Mission to be completed: 
      * Modify Index.js to encapsulate the dropDownList function so that it can be commonly used. - first version of dropDownList.js has been created and reconstructed.
      * Test whether 2 or more customized dropDownLists may conflict with each other. - not conflict
   
    * Successfully access FBB_Data_Provider website JSON by retrieving data by server code.

4. jQuery_Ajax _Demo01
   A demo that implements a list using ajax and jQuery to load data from server(maybe server cache would be added in the future). Created and built under VS2010.

5. RegDemo00   
   A demo that implements reading/writing Registry key-value.
   
6. DelegateDemo00  
   A demo that demonstrates `Action<T>` delegate.
   
7. NetServerDemo   
   Using different network protocols to implement a server which returns a simple http response of a "Hello World" web page.
   
8. MessagePump   
   WPF demo to test async/await, build under VS2012.
