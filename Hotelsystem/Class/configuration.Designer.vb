﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On



<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
 Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>  _
Partial Friend NotInheritable Class configuration
    Inherits Global.System.Configuration.ApplicationSettingsBase
    
    Private Shared defaultInstance As configuration = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New configuration()),configuration)
    
    Public Shared ReadOnly Property [Default]() As configuration
        Get
            Return defaultInstance
        End Get
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("dbhotelsystem")>  _
    Public Property dbname() As String
        Get
            Return CType(Me("dbname"),String)
        End Get
        Set
            Me("dbname") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("(local)")>  _
    Public Property servername() As String
        Get
            Return CType(Me("servername"),String)
        End Get
        Set
            Me("servername") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("doPDF 81")>  _
    Public Property printername() As String
        Get
            Return CType(Me("printername"),String)
        End Get
        Set
            Me("printername") = value
        End Set
    End Property
    
    <Global.System.Configuration.UserScopedSettingAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Configuration.DefaultSettingValueAttribute("CD7220NU")>  _
    Public Property Displayname() As String
        Get
            Return CType(Me("Displayname"),String)
        End Get
        Set
            Me("Displayname") = value
        End Set
    End Property
End Class
