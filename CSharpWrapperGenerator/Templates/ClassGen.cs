﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン: 12.0.0.0
//  
//     このファイルへの変更は、正しくない動作の原因になる可能性があり、
//     コードが再生成されると失われます。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CSharpWrapperGenerator.Templates
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class ClassGen : ClassGenBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\t/// <summary>\r\n\t/// ");
            
            #line 7 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(classDef.Brief));
            
            #line default
            #line hidden
            this.Write("\r\n\t/// </summary>\r\n\tpublic partial class ");
            
            #line 9 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(className));
            
            #line default
            #line hidden
            this.Write("\r\n\t{\r\n\t\tprivate ace.swig.");
            
            #line 11 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(classDef.Name));
            
            #line default
            #line hidden
            this.Write(" coreInstance;\r\n\r\n");
            
            #line 13 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
	foreach(var property in classDef.Properties){ 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>\r\n\t\t/// ");
            
            #line 15 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Brief));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// </summary>\r\n\t\tpublic ");
            
            #line 17 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 17 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t{\r\n");
            
            #line 19 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		if(property.HaveGetter){ 
            
            #line default
            #line hidden
            this.Write("\t\t\tget { return ");
            
            #line 20 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
if(property.IsEnum){ 
            
            #line default
            #line hidden
            this.Write("(ace.");
            
            #line 20 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 20 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            this.Write("coreInstance.Get");
            
            #line 20 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("(); }\r\n");
            
            #line 21 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		} 
            
            #line default
            #line hidden
            
            #line 22 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		if(property.HaveSetter){ 
            
            #line default
            #line hidden
            this.Write("\t\t\tset { coreInstance.Set");
            
            #line 23 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 23 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
if(property.IsRefForSet){ 
            
            #line default
            #line hidden
            this.Write("ref ");
            
            #line 23 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            
            #line 24 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
if(property.IsEnum){ 
            
            #line default
            #line hidden
            this.Write("(ace.swig.");
            
            #line 24 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Type));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 24 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            this.Write("value); }\r\n");
            
            #line 26 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\t}\r\n\r\n");
            
            #line 29 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 31 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
	foreach(var method in classDef.Methods){ 
            
            #line default
            #line hidden
            
            #line 32 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		var parameterList = string.Join(", ", method.Parameters.Select(x => x.Type + " " + x.Name)); 
            
            #line default
            #line hidden
            this.Write("\t\t/// <summary>\r\n\t\t/// ");
            
            #line 34 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Brief));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t/// </summary>\r\n");
            
            #line 36 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		foreach(var p in method.Parameters){ 
            
            #line default
            #line hidden
            this.Write("\t\t/// <param name=\"");
            
            #line 37 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Name));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 37 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(p.Brief));
            
            #line default
            #line hidden
            this.Write("</param>\r\n");
            
            #line 38 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		} 
            
            #line default
            #line hidden
            
            #line 39 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		if(method.ReturnType != "void"){ 
            
            #line default
            #line hidden
            this.Write("\t\t/// <returns>");
            
            #line 40 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.BriefOfReturn));
            
            #line default
            #line hidden
            this.Write("</returns>\r\n");
            
            #line 41 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		} 
            
            #line default
            #line hidden
            this.Write("\t\tpublic ");
            
            #line 42 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
if(method.IsStatic){ 
            
            #line default
            #line hidden
            this.Write("static ");
            
            #line 42 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            
            #line 42 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ReturnType));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 42 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 42 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameterList));
            
            #line default
            #line hidden
            this.Write(")\r\n\t\t{\r\n");
            
            #line 44 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		var sendedParameterList = string.Join(", ", method.Parameters.Select(GetParameterUsage));
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 45 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
if(method.ReturnType != "void"){ 
            
            #line default
            #line hidden
            this.Write("return ");
            
            #line 45 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            
            #line 46 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		if(method.ReturnIsEnum){ 
            
            #line default
            #line hidden
            this.Write("(ace.");
            
            #line 46 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.ReturnType));
            
            #line default
            #line hidden
            this.Write(")");
            
            #line 46 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		} 
            
            #line default
            #line hidden
            
            #line 47 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
		if(method.IsStatic){ 
            
            #line default
            #line hidden
            
            #line 47 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(classDef.Name));
            
            #line default
            #line hidden
            
            #line 47 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
}else{ 
            
            #line default
            #line hidden
            this.Write("coreInstance");
            
            #line 47 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
} 
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 48 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(method.Name));
            
            #line default
            #line hidden
            this.Write("(");
            
            #line 48 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sendedParameterList));
            
            #line default
            #line hidden
            this.Write(");\r\n\t\t}\r\n\r\n");
            
            #line 51 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"
	} 
            
            #line default
            #line hidden
            this.Write("\t}\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 54 "D:\Documents\Repos\AceRepos\CSharpWrapperGenerator\CSharpWrapperGenerator\Templates\ClassGen.tt"

	private string GetParameterUsage(ParameterDef parameter)
	{
		string result = "";
		if(parameter.IsRef)
		{
			result += "ref ";
		}
		if(parameter.IsEnum)
		{
			result += "(ace.swig." + parameter.Type + ")";
		}
		result += parameter.Name;
		return result;
	}
 
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class ClassGenBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
