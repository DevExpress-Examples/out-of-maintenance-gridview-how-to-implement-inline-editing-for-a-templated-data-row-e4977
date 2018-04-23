Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Web

Namespace DXWebApplication3.Models
	Public Class Person
		Private privateID As Integer
		<Key> _
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateCanSpeakReceived As Boolean
		Public Property CanSpeakReceived() As Boolean
			Get
				Return privateCanSpeakReceived
			End Get
			Set(ByVal value As Boolean)
				privateCanSpeakReceived = value
			End Set
		End Property
		Private privateCanWriteReceived As Boolean
		Public Property CanWriteReceived() As Boolean
			Get
				Return privateCanWriteReceived
			End Get
			Set(ByVal value As Boolean)
				privateCanWriteReceived = value
			End Set
		End Property
		Private privateCanUnderstandReceived As Boolean
		Public Property CanUnderstandReceived() As Boolean
			Get
				Return privateCanUnderstandReceived
			End Get
			Set(ByVal value As Boolean)
				privateCanUnderstandReceived = value
			End Set
		End Property
		Private privateCanSpeakExpressed As Boolean
		Public Property CanSpeakExpressed() As Boolean
			Get
				Return privateCanSpeakExpressed
			End Get
			Set(ByVal value As Boolean)
				privateCanSpeakExpressed = value
			End Set
		End Property
		Private privateCanWriteExpressed As Boolean
		Public Property CanWriteExpressed() As Boolean
			Get
				Return privateCanWriteExpressed
			End Get
			Set(ByVal value As Boolean)
				privateCanWriteExpressed = value
			End Set
		End Property
		Private privateCanUnderstandExpressed As Boolean
		Public Property CanUnderstandExpressed() As Boolean
			Get
				Return privateCanUnderstandExpressed
			End Get
			Set(ByVal value As Boolean)
				privateCanUnderstandExpressed = value
			End Set
		End Property
		Public Sub New()
		End Sub
	End Class
	Public NotInheritable Class PersonLanguages
		Private Sub New()
		End Sub
		Public Shared Function GetPersonLanguages() As List(Of Person)
			If HttpContext.Current.Session("ModelList") Is Nothing Then
				Dim result As New List(Of Person)()
				result.Add(New Person() With {.ID = 0, .CanSpeakExpressed = True, .CanSpeakReceived = True, .CanUnderstandExpressed = True, .CanUnderstandReceived = False, .CanWriteExpressed = False, .CanWriteReceived = False})
				result.Add(New Person() With {.ID = 1, .CanSpeakExpressed = False, .CanSpeakReceived = True, .CanUnderstandExpressed = False, .CanUnderstandReceived = True, .CanWriteExpressed = False, .CanWriteReceived = True})
				result.Add(New Person() With {.ID = 2, .CanSpeakExpressed = True, .CanSpeakReceived = True, .CanUnderstandExpressed = False, .CanUnderstandReceived = True, .CanWriteExpressed = False, .CanWriteReceived = False})
				HttpContext.Current.Session("ModelList") = result
			End If
			Return CType(HttpContext.Current.Session("ModelList"), List(Of Person))
		End Function

		Public Shared Function UpdatePerson(ByVal modelInfo As Person) As List(Of Person)
			Dim editedModel As Person = GetPersonLanguages().Where(Function(m) m.ID = modelInfo.ID).First()
			editedModel.CanSpeakExpressed = modelInfo.CanSpeakExpressed
			editedModel.CanSpeakReceived = modelInfo.CanSpeakReceived
			editedModel.CanUnderstandExpressed = modelInfo.CanUnderstandExpressed
			editedModel.CanWriteExpressed = modelInfo.CanWriteExpressed
			editedModel.CanWriteReceived = modelInfo.CanWriteReceived
			editedModel.CanUnderstandReceived = modelInfo.CanUnderstandReceived
			Return GetPersonLanguages()
		End Function
	End Class
End Namespace