Imports Microsoft.VisualBasic
Imports DevExpress.Web.Mvc
Imports DXWebApplication3.Models
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc

Namespace DXWebApplication3.Controllers
	Public Class HomeController
		Inherits Controller
		'
		' GET: /Home/
		Public Function Index() As ActionResult
			Return View(PersonLanguages.GetPersonLanguages())
		End Function
		Public Function GridViewPartial() As ActionResult
			Return PartialView(PersonLanguages.GetPersonLanguages())
		End Function
		Public Function UpdateGridView(ByVal person As Person) As ActionResult
			Return PartialView("GridViewPartial", PersonLanguages.UpdatePerson(person))
		End Function

	End Class
End Namespace
