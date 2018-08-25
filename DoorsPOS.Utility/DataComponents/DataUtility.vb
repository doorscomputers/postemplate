Imports PDSA.Common
Imports System.Web

Public Class DataUtility
   Public Shared Function GetSecurityQuestions() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML/SecurityQuestions.xml"))
   End Function
End Class
