Imports System.Web
Imports PDSA.Common

Public Class DataGeneral
   Public Shared Function GetAccounts() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-General/Accounts.xml"))
   End Function

   Public Shared Function GetCustomers() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-General/Customers.xml"))
   End Function

   Public Shared Function GetProducts() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-General/Products.xml"))
   End Function
End Class
