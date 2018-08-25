Imports System.Web
Imports PDSA.Common

Public Class PDSADataCommon
#Region "PDSA Data Table Methods"
   Public Shared Function GetMenus() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/Menus.xml"))
   End Function
#End Region

#Region "Common Methods"
   Public Shared Function GetCustomerStatus() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/CustomerStatus.xml"))
   End Function

   Public Shared Function GetSICCodes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/SICCodes.xml"))
   End Function

   Public Shared Function GetUSRegions() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/USRegions.xml"))
   End Function

   Public Shared Function GetGetUSStateCapitals() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/USStates.xml"))
   End Function

   Public Shared Function GetUSTimeZones() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/USTimeZones.xml"))
   End Function

   Public Shared Function GetUSCensusRegions() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/USCensusRegions.xml"))
   End Function

   Public Shared Function GetEmployeeTypes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/EmployeeTypes.xml"))
   End Function

   Public Shared Function GetLanguages() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/Languages.xml"))
   End Function

   Public Shared Function GetInternetTypes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/InternetTypes.xml"))
   End Function

   Public Shared Function GetCustomerTypes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/CustomerTypes.xml"))
   End Function

   Public Shared Function GetCountries() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/Countries.xml"))
   End Function

   Public Shared Function GetPhoneTypes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/PhoneTypes.xml"))
   End Function

   Public Shared Function GetMaritalStatus() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/MaritalStatus.xml"))
   End Function

   Public Shared Function GetNamePrefixes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/NamePrefixes.xml"))
   End Function

   Public Shared Function GetNameSuffixes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/NameSuffixes.xml"))
   End Function

   Public Shared Function GetCreditCardTypes() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/CreditCardTypes.xml"))
   End Function

   Public Shared Function GetEthnicity() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/Ethnicity.xml"))
   End Function

   Public Shared Function GetUSStates() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/USStates.xml"))
   End Function

   Public Shared Function GetGender() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/Gender.xml"))
   End Function

   Public Shared Function GetCanadianProvinces() As DataSet
      Return PDSAXML.FileToDataSet(HttpContext.Current.Server.MapPath("~/XML-Common/CanadianProvinces.xml"))
   End Function
#End Region
End Class
