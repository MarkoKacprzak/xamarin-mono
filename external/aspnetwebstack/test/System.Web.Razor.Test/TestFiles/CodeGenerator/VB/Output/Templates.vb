'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:N.N.NNNNN.N
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Web.Helpers


Namespace TestOutput
Public Class Templates

#ExternalSource("Templates.vbhtml",3)
          
    Public Function Repeat(times As Integer, template As Func(Of Integer, object)) As HelperResult
        Return New HelperResult(Sub(writer)
            For i = 0 to times
                DirectCast(template(i), HelperResult).WriteTo(writer)
            Next i
        End Sub)
    End Function

#End ExternalSource

Public Sub New()
MyBase.New
End Sub
Public Overrides Sub Execute()
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",13)
     
    Dim foo As Func(Of Object, Object) =

#End ExternalSource
WriteLiteral(" ")

WriteLiteral("This works ")


#ExternalSource("Templates.vbhtml",14)
                                                      Write(item)


#End ExternalSource
WriteLiteral("!")

WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",15)
    

#End ExternalSource

#ExternalSource("Templates.vbhtml",15)
Write(foo("too"))


#End ExternalSource

#ExternalSource("Templates.vbhtml",15)
               


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ul>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",19)
Write(Repeat(10, Function (item) New Template(Sub (__razor_template_writer)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, "<li>Item #")


#ExternalSource("Templates.vbhtml",19)
WriteTo(__razor_template_writer, item)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, "</li>")


#ExternalSource("Templates.vbhtml",19)
                           End Sub)))


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ul>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<p>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",23)
Write(Repeat(10,
    Function (item) New Template(Sub (__razor_template_writer)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, " This is line#")


#ExternalSource("Templates.vbhtml",24)
WriteTo(__razor_template_writer, item)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, " of markup<br/>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",25)
End Sub)))


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</p>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ul>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))

WriteLiteral("    ")


#ExternalSource("Templates.vbhtml",29)
Write(Repeat(10, Function (item) New Template(Sub (__razor_template_writer)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, "<li>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        Item #")


#ExternalSource("Templates.vbhtml",30)
WriteTo(__razor_template_writer, item)


#End ExternalSource
WriteLiteralTo(__razor_template_writer, ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10))


#ExternalSource("Templates.vbhtml",31)
        

#End ExternalSource

#ExternalSource("Templates.vbhtml",31)
              Dim parent = item 

#End ExternalSource
WriteLiteralTo(__razor_template_writer, ""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        <ul>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"            <li>Child Items... ?</li>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"        </ul>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"    </li>")


#ExternalSource("Templates.vbhtml",35)
 End Sub)))


#End ExternalSource
WriteLiteral(""&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ul>")

End Sub
End Class
End Namespace