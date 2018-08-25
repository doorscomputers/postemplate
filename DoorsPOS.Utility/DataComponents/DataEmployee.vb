Imports System.Web
Imports PDSA.Common

Public Class DataEmployee
   Public Shared Function GetAllEmployees() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Employee/Employees.xml"))
   End Function
End Class
