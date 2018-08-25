'********************************************
'* This file shows how you can setup your own
'* App.Config reader
'* 
'* You would add the following to the App.Config 
'* file, then modify this class to add Shared variables
'* 
'*   <configSections>
'*         <section name="MyValues" type="ProjectName.MyAppConfig, ProjectName" />
'*   </configSections>
'*
'*   <!-- My APPLICATION SPECIFIC SETTINGS -->
'*  <MyValues>  
'*      <!-- MyValue -->
'* 	  <add key="MyValue" value="HiThere" />
'* </MyValues>
'********************************************
Imports System ' For IConfigurationSectionHandler
Imports System.Configuration
Imports System.Collections.Specialized  ' For NameValueCollection
Imports PDSA.PDSACryptography ' For Decryption Method

<Serializable()> Public Class WinAppConfig
   Implements IConfigurationSectionHandler
   ' This can be used to Retrieve and Decrypt data in your WinAppConfig section
   Private Shared mpConfig As PDSAConfig

   ' TODO: WinAppConfig -> Create your private variable values here
   Private Shared mstrMyValue As String
   Private Shared mstrConnectStringData As String

   ' TODO: WinAppConfig -> Create your public properties here
   Public Shared ReadOnly Property MyValue() As String
      Get
         Return mstrMyValue
      End Get
   End Property

   Public Shared ReadOnly Property ConnectStringData() As String
      Get
         Return mstrConnectStringData
      End Get
   End Property

   ' TODO: WinAppConfig -> Read Custom Config Settings Here
   Private Shared Sub ReadCustomSettings()

      mstrMyValue = mpConfig.ReadString("MyValue")

      ' If you have an encrypted connection string, use the Decrypt() method to decrypt it
      'mConnectStringData = mpConfig.Decrypt(mpConfig.ReadString("ConnectStringData"))
      mstrConnectStringData = mpConfig.ReadString("ConnectStringData")
   End Sub

#Region " Private Shared Required Properties "
   ' Are All Values Encrypted?
   Private Shared mboolAllEncrypted As Boolean
   '**************************************************
   ' Properties for Reading from Registry
   '**************************************************
   ' (True/False) True=Use Registry, False=Don't Use Registry
   Private Shared mboolUseRegistry As Boolean
   ' Registry Key where Config Info is located
   Private Shared mstrRegistryConfigKey As String

   '**************************************************
   ' Properties for Reading from XML File
   '**************************************************
   ' (True/False) True=Use XML File, False=Don't Use XML File
   Private Shared mboolUseXMLFile As Boolean
   ' Registry Key where Config Info is located
   Private Shared mstrXMLConfigFile As String

   '**************************************************
   '* Properties to be set by Programmer
   '**************************************************
   ' Encryption Type
   Private Shared mstrEncryptionType As String
   ' DP Entropy Value
   Private Shared mstrDPEntropy As String
   ' Encryption Key
   Private Shared mstrEncKey As String
   ' Encryption IV
   Private Shared mstrEncIV As String
   ' Location of XML File for Key and IV
   Private Shared mstrEncKeyXMLFile As String
   ' Location of Registry Key for Key and IV
   Private Shared mstrEncKeyRegKey As String
#End Region

#Region " Public Shared Required Properties "
   ''************************************************************
   ''<VBComments class="WinAppConfig" name="AllEncrypted" type="Property">
   ''<summary>
   ''Get/Set whether or not the complete configuration info has been encrypted
   ''</summary>
   ''<example>
   ''</example>
   ''<returns>Boolean</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property AllEncrypted() As Boolean
      Get
         Return mboolAllEncrypted
      End Get
      Set(ByVal Value As Boolean)
         mboolAllEncrypted = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="WinAppConfig" name="UseRegistry" type="Property">
   ''<summary>
   ''Get/Set whether or not to store Configuration information in the Registry.
   ''</summary>
   ''<example>
   ''</example>
   ''<returns>Boolean</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property UseRegistry() As Boolean
      Get
         Return mboolUseRegistry
      End Get
      Set(ByVal Value As Boolean)
         mboolUseRegistry = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="WinAppConfig" name="RegistryConfigKey" type="Property">
   ''<summary>
   ''Set this value to a key in the HKEY_LOCALMACHINE hive if you have set the UseRegistry property to True.
   ''</summary>
   ''<example>
   ''WinAppConfig.RegistryConfigKey = "\Software\MyApp"
   ''</example>
   ''<returns>String</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property RegistryConfigKey() As String
      Get
         Return mstrRegistryConfigKey
      End Get
      Set(ByVal Value As String)
         mstrRegistryConfigKey = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="WinAppConfig" name="UseXMLFile" type="Property">
   ''<summary>
   ''Get/Set whether or not to store Configuration information in an XML file.
   ''</summary>
   ''<example>
   ''WinAppConfig.UseXMLFile = True
   ''</example>
   ''<returns>Boolean</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property UseXMLFile() As Boolean
      Get
         Return mboolUseXMLFile
      End Get
      Set(ByVal Value As Boolean)
         mboolUseXMLFile = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="WinAppConfig" name="XMLConfigFile" type="Property">
   ''<summary>
   ''Set this value to a valid path and file name where the configuration information for this application is located. This property must be set if you set the UseXMLFile property to True.
   ''</summary>
   ''<example>
   ''WinAppConfig.XMLConfigFile = "\\Server1\Configs\MyApp\MyApp.config"
   ''</example>
   ''<returns>String</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property XMLConfigFile() As String
      Get
         Return mstrXMLConfigFile
      End Get
      Set(ByVal Value As String)
         mstrXMLConfigFile = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="WinAppConfig" name="EncryptionType" type="Property">
   ''<summary>
   ''The type of encryption to use for decrypting values
   ''</summary>
   ''<example>
   ''WinAppConfig.EncryptionType = "PDSA0"
   ''</example>
   ''<returns>String</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property EncryptionType() As String
      Get
         Return mstrEncryptionType
      End Get
      Set(ByVal Value As String)
         mstrEncryptionType = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="PDSAAppConfigBase" name="EncKeyRegKey" type="Property">
   ''<summary>
   ''Get/Set the location in the Registry for the Encryption Key and IV
   ''</summary>
   ''<example>
   ''PDSAAppConfig.EncKeyRegKey = "Software\MyKey"
   ''</example>
   ''<returns>String</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property EncKeyRegKey() As String
      Get
         Return mstrEncKeyRegKey
      End Get
      Set(ByVal Value As String)
         mstrEncKeyRegKey = Value
      End Set
   End Property

   ''************************************************************
   ''<VBComments class="PDSAAppConfigBase" name="EncKeyXMLFile" type="Property">
   ''<summary>
   ''Get/Set the location of an XML File for the Encryption Key and IV
   ''</summary>
   ''<example>
   ''PDSAAppConfig.EncKeyRegKey = "C:\Temp\MyKeys.xml"
   ''</example>
   ''<returns>String</returns>
   ''</VBComments>
   ''************************************************************
   Public Shared Property EncKeyXMLFile() As String
      Get
         Return mstrEncKeyXMLFile
      End Get
      Set(ByVal Value As String)
         mstrEncKeyXMLFile = Value
      End Set
   End Property
#End Region

#Region " Implemented Method For Reading Config Information "
   '************************************************
   ' The Create method must be created. It is called
   ' from ASP.NET after the GetConfig method is called
   '************************************************
   Public Function Create(ByVal parent As Object, _
    ByVal configContext As Object, _
    ByVal input As Xml.XmlNode) As Object Implements IConfigurationSectionHandler.Create

      Dim nvc As NameValueCollection
      Dim nvsh As NameValueSectionHandler

      nvsh = New NameValueSectionHandler
      nvc = CType(nvsh.Create(parent, configContext, input), _
       NameValueCollection)

      If nvc Is Nothing Then
         ' Don't do anything
      Else
         mpConfig = New PDSAConfig(nvc)
         mpConfig.EncKey = mstrEncKey
         mpConfig.EncIV = mstrEncIV
         mpConfig.DPEntropy = mstrDPEntropy
         mpConfig.EncryptionType = mstrEncryptionType
         mpConfig.UseRegistry = mboolUseRegistry
         mpConfig.UseXMLFile = mboolUseXMLFile
         mpConfig.XMLConfigFile = mstrXMLConfigFile
         mpConfig.RegistryConfigKey = mstrRegistryConfigKey

         ' See if we need to decrypt the values
         If mboolAllEncrypted Then
            mpConfig.DecryptAll(nvc)
         End If

         ' If we need to read from another source
         If mboolUseRegistry Or mboolUseXMLFile Then
            nvc = mpConfig.Read()

            ' Need to do this again, because we read from somewhere else
            If mboolAllEncrypted Then
               mpConfig.DecryptAll(nvc)
            End If
         End If

         ReadCustomSettings()
      End If

      Return nvc
   End Function

   Public Shared Sub Init()
      ' The following entry must match what is in your App.Config file
		ConfigurationManager.GetSection("WinAppConfig")
   End Sub
#End Region
End Class
