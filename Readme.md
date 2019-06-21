<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/WebSite/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/WebSite/Controllers/HomeController.vb))
* [Person.cs](./CS/WebSite/Models/Person.cs) (VB: [Person.vb](./VB/WebSite/Models/Person.vb))
* [CustomEditing.js](./CS/WebSite/Scripts/CustomEditing.js) (VB: [CustomEditing.js](./VB/WebSite/Scripts/CustomEditing.js))
* [GridViewPartial.cshtml](./CS/WebSite/Views/Home/GridViewPartial.cshtml)
* [Index.cshtml](./CS/WebSite/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to implement inline editing for a templated data row
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4977)**
<!-- run online end -->


<p>GridView provides a template for the Data Row that allows you to customize the grid's appearance. However, some features that are available in the GridView out-of-the-box will be unavailable or inefficient when you use the Data Row Template. For instance, the Inline Editing row layout does not correspond to the Data Row layout in this case.  </p><p>This solution demonstrates how to implement Inline Editing for the GridView with the Data Row Template.</p><p> The main steps of implementation:</p><p>1) Add read-only editors in the DataRow Template for displaying information in browse mode;</p><p>2) Add custom HyperLinks/Buttons instead of Command Buttons, since they are not rendered when the Data Row Template is used;</p><p>3) Handle the client-side Click event of HyperLinks/Buttons and enable editors in the corresponding row for editing. Use the container's VisibleIndex property value to detect which button was clicked and  which row should be enabled for editing;</p><p>4) Use the approach from  <a href="https://www.devexpress.com/Support/Center/p/E4236">How to implement the multi-row editing feature in the GridView</a> to get values from editors and save changes to your data source.</p><p></p>

<br/>


