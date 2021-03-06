﻿' Developer Express Code Central Example:
' How to create a GridView descendant class and register it for design-time use
' 
' This is an example of a custom GridView and a custom control that inherits the
' DevExpress.XtraGrid.GridControl. Make sure to build the project prior to opening
' Form1 in the designer. Please refer to the http://www.devexpress.com/scid=A859
' Knowledge Base article for the additional information.
' In addition, you can
' refer to the examples describing how to create GridControl's View
' descendants:
' 1. http://www.devexpress.com/scid=T122347; 2.
' http://www.devexpress.com/scid=T122335; 3.
' http://www.devexpress.com/scid=T122333; 4.
' http://www.devexpress.com/scid=T122322 ;
' 5.
' http://www.devexpress.com/scid=T122275.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E900


Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("MyXtraGrid")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("DX")>
<Assembly: AssemblyProduct("MyXtraGrid")>
<Assembly: AssemblyCopyright("Copyright © DX 2009")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>

' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>

' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("9efeec78-7360-4903-9248-9a54e6c7b9eb")>

' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>
