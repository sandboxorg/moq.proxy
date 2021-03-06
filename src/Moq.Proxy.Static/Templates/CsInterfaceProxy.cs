﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 14.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Moq.Proxy.Templates
{
    using System.Globalization;
    using System.Linq;
    using System.Reflection;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class CsInterfaceProxy : Moq.Proxy.CsTextTransform
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("namespace ");
            
            #line 8 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TargetNamespace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n");
            
            #line 10 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		foreach (var ns in Usings) {

            
            #line default
            #line hidden
            this.Write("\tusing ");
            
            #line 13 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ns));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 14 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		} 

            
            #line default
            #line hidden
            this.Write("\r\n\tpublic class ");
            
            #line 18 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" : ");
            
            #line 18 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(string.Join(", ", BaseTypes.Select(x => GetTypeName(x)))));
            
            #line default
            #line hidden
            this.Write(", IProxy\r\n\t{\r\n");
            
            #line 20 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		// We generate a delegate to reference these methods by signature, since 
		// we can't use Action or Func for them.
		foreach (var outRef in OutRefMethods) {

            
            #line default
            #line hidden
            this.Write("\t\tdelegate ");
            
            #line 25 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(outRef.ReturnType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 25 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDelegate(outRef)));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 25 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetParams(outRef)));
            
            #line default
            #line hidden
            this.Write(");\r\n");
            
            #line 26 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		} 

            
            #line default
            #line hidden
            this.Write("\t\tBehaviorPipeline pipeline;\r\n\t\tobject target;\r\n");
            
            #line 31 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		foreach (var iface in ImplementedInterfaces) {

            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 34 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(iface)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 34 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFieldName(iface)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 35 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		} 

            
            #line default
            #line hidden
            this.Write("\r\n\t\tpublic ");
            
            #line 39 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" ()\r\n\t\t{\r\n\t\t\tpipeline = new BehaviorPipeline ();\r\n\t\t}\r\n\r\n\t\tpublic ");
            
            #line 44 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ClassName));
            
            #line default
            #line hidden
            this.Write(" (object target)\r\n\t\t\t: this ()\r\n\t\t{\r\n\t\t\tthis.target = target;\r\n");
            
            #line 48 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		foreach (var iface in ImplementedInterfaces) {

            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 51 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetFieldName(iface)));
            
            #line default
            #line hidden
            this.Write(" = target as ");
            
            #line 51 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(iface)));
            
            #line default
            #line hidden
            this.Write(";\r\n");
            
            #line 52 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		} 

            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n\t\tIList<IProxyBehavior> IProxy.Behaviors => pipeline.Behaviors;\r\n\r\n");
            
            #line 59 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		foreach (var property in InterfaceProperties) {
			var targetVariable = GetFieldName(property.DeclaringType);

            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 64 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.PropertyType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 64 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 64 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetPropertyName(property)));
            
            #line default
            #line hidden
            
            #line 64 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetIndexParams(property)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{ ");
            
            #line 65 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 if (property.CanRead) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tget\r\n\t\t\t{\r\n\t\t\t\tvar method = this.GetInterfaceMethod<");
            
            #line 69 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(">((MethodInfo)MethodBase.GetCurrentMethod());\r\n\t\t\t\tvar invocation = new MethodInv" +
                    "ocation(this, method, new object[] { ");
            
            #line 70 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetIndexVars(property)));
            
            #line default
            #line hidden
            this.Write(" });\r\n\t\t\t\tvar returns = pipeline.Invoke(\r\n\t\t\t\t\tinvocation,\r\n\t\t\t\t\t(input, next) =>" +
                    " {\r\n\t\t\t\t\t\ttry {\r\n\t\t\t\t\t\t\tvar returnValue = ");
            
            #line 75 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(" != null ?\r\n\t\t\t\t\t\t\t\t");
            
            #line 76 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            
            #line 76 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CallProperty(property)));
            
            #line default
            #line hidden
            this.Write(" :\r\n\t\t\t\t\t\t\t\tdefault(");
            
            #line 77 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.PropertyType)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\t\t\t\t\treturn input.CreateValueReturn(returnValue, new object[] { ");
            
            #line 79 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetIndexVars(property)));
            
            #line default
            #line hidden
            this.Write(" });\r\n\t\t\t\t\t\t} catch (Exception ex) {\r\n\t\t\t\t\t\t\treturn input.CreateExceptionReturn(e" +
                    "x);\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t);\r\n\r\n\t\t\t\tvar exception = returns.Exception;\r\n\t\t\t\tif (" +
                    "exception != null)\r\n\t\t\t\t\tthrow exception;\r\n");
            
            #line 89 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 if (property.PropertyType.GetTypeInfo().IsValueType) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\treturn ((");
            
            #line 91 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.PropertyType)));
            
            #line default
            #line hidden
            this.Write("?)returns.ReturnValue).GetValueOrDefault ();\r\n");
            
            #line 92 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\treturn ((");
            
            #line 94 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.PropertyType)));
            
            #line default
            #line hidden
            this.Write(")returns.ReturnValue);\r\n");
            
            #line 95 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t} ");
            
            #line 96 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 } if (property.CanWrite) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tset\r\n\t\t\t{\r\n\t\t\t\tvar method = this.GetInterfaceMethod<");
            
            #line 100 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(property.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(">((MethodInfo)MethodBase.GetCurrentMethod());\r\n\t\t\t\tvar invocation = new MethodInv" +
                    "ocation(this, method, new object[] { ");
            
            #line 101 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetIndexVars(property)));
            
            #line default
            #line hidden
            this.Write(" });\r\n\t\t\t\tvar returns = pipeline.Invoke(\r\n\t\t\t\t\tinvocation,\r\n\t\t\t\t\t(input, next) =>" +
                    " {\r\n\t\t\t\t\t\ttry {\r\n\t\t\t\t\t\t\tif (");
            
            #line 106 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t\t\t\t\t\t");
            
            #line 107 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            
            #line 107 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CallProperty(property)));
            
            #line default
            #line hidden
            this.Write(" = value;\r\n\r\n\t\t\t\t\t\t\treturn input.CreateValueReturn(null, new object [] { ");
            
            #line 109 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetIndexVars(property)));
            
            #line default
            #line hidden
            this.Write(" });\r\n\t\t\t\t\t\t} catch (Exception ex) {\r\n\t\t\t\t\t\t\treturn input.CreateExceptionReturn(e" +
                    "x);\r\n\t\t\t\t\t\t}\r\n\t\t\t\t\t}\r\n\t\t\t\t);\r\n\r\n\t\t\t\tvar exception = returns.Exception;\r\n\t\t\t\tif (" +
                    "exception != null)\r\n\t\t\t\t\tthrow exception;\r\n\t\t\t} ");
            
            #line 119 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t}\r\n");
            
            #line 122 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 124 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		foreach (var method in InterfaceMethods) {
			var targetVariable = GetFieldName(method.DeclaringType);

            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 129 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.ReturnType)));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 129 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 129 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 129 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetParams(method)));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{ ");
            
            #line 130 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			foreach (var parameter in method.GetParameters().Where(p => p.IsOut)) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 133 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = default(");
            
            #line 133 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(parameter.ParameterType)));
            
            #line default
            #line hidden
            this.Write("); ");
            
            #line 133 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			}

            
            #line default
            #line hidden
            this.Write("\r\n\t\t\tvar method = this.GetInterfaceMethod<");
            
            #line 137 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetDelegate(method)));
            
            #line default
            #line hidden
            this.Write(", ");
            
            #line 137 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(">(((");
            
            #line 137 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.DeclaringType)));
            
            #line default
            #line hidden
            this.Write(")this).");
            
            #line 137 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t\tvar invocation = new MethodInvocation(this, method, new object[] { ");
            
            #line 138 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetVars(method)));
            
            #line default
            #line hidden
            this.Write(" });\r\n\t\t\tvar returns = pipeline.Invoke(\r\n\t\t\t\tinvocation,\r\n\t\t\t\t(input, next) => {\r" +
                    "\n\t\t\t\t\ttry\r\n\t\t\t\t\t{ ");
            
            #line 143 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			foreach (var parameter in method.GetParameters().Where(p => p.IsOut || p.ParameterType.IsByRef)) {
				var parameterType = GetTypeName(parameter.ParameterType); 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\tvar local_");
            
            #line 147 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Name));
            
            #line default
            #line hidden
            this.Write(" = ");
            
            #line 147 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.IsOut ? "default(" + parameterType + ")" : "(" + parameterType + ")invocation.Arguments[" + parameter.Position + "];"));
            
            #line default
            #line hidden
            this.Write("; ");
            
            #line 147 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			}

			if (method.ReturnType == typeof(void)) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\tif (");
            
            #line 152 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(" != null)\r\n\t\t\t\t\t\t\t");
            
            #line 153 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 153 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 153 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetArgs(method)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\t\t\t\treturn input.CreateValueReturn(null, new object[] { ");
            
            #line 155 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetVars(method)));
            
            #line default
            #line hidden
            this.Write(" }); ");
            
            #line 155 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			} else { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\tvar returnValue = ");
            
            #line 158 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(" != null ?\r\n\t\t\t\t\t\t\t");
            
            #line 159 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetVariable));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 159 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 159 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetArgs(method)));
            
            #line default
            #line hidden
            this.Write(") :\r\n\t\t\t\t\t\t\tdefault(");
            
            #line 160 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.ReturnType)));
            
            #line default
            #line hidden
            this.Write(");\r\n\r\n\t\t\t\t\t\treturn input.CreateValueReturn(returnValue, new object[] { ");
            
            #line 162 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetVars(method)));
            
            #line default
            #line hidden
            this.Write(" }); ");
            
            #line 162 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

			} 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t}\r\n\t\t\t\t\tcatch (Exception ex)\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\treturn input.CreateExceptionRe" +
                    "turn(ex);\r\n\t\t\t\t\t}\r\n\t\t\t\t}\r\n\t\t\t);\r\n\r\n\t\t\tvar exception = returns.Exception;\r\n\t\t\tif " +
                    "(exception != null)\r\n\t\t\t\tthrow exception;\r\n");
            
            #line 176 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
 if (method.ReturnType != typeof(void)) {
		if (method.ReturnType.GetTypeInfo().IsValueType) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn ((");
            
            #line 179 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.ReturnType)));
            
            #line default
            #line hidden
            this.Write("?)returns.ReturnValue).GetValueOrDefault ();\r\n");
            
            #line 180 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
		} else { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\treturn ((");
            
            #line 182 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GetTypeName(method.ReturnType)));
            
            #line default
            #line hidden
            this.Write(")returns.ReturnValue);\r\n");
            
            #line 183 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"
		}
	}
 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n");
            
            #line 187 "C:\Code\Personal\moq.proxy\src\Moq.Proxy.Generator\Templates\CsInterfaceProxy.tt"

		} 

            
            #line default
            #line hidden
            this.Write("\t}\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
