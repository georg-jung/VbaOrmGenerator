﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 16.0.0.0
//  
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code neu generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace OrmGenerator.Vba.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ModelClass : ModelClassBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("VERSION 1.0 CLASS\r\nBEGIN\r\n  MultiUse = -1  \'True\r\nEND\r\nAttribute VB_Name = \"");
            
            #line 11 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.Name));
            
            #line default
            #line hidden
            this.Write("\"\r\nAttribute VB_GlobalNameSpace = False\r\nAttribute VB_Creatable = False\r\nAttribut" +
                    "e VB_PredeclaredId = False\r\nAttribute VB_Exposed = False\r\n\'@Folder(\"Models\")\r\nOp" +
                    "tion Explicit\r\n\r\nImplements IMappable\r\n\r\nPrivate Type TClass\r\n");
            
            #line 22 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 foreach (var item in Entity.Properties)
   { 
            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 24 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write(" As ");
            
            #line 24 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Value.Type));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 25 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 } // end of foreach

            
            #line default
            #line hidden
            this.Write(@"End Type

Private this As TClass

Private mobjClassProperties As Dictionary


' =============================================================================
' PROPERTIES
' =============================================================================

");
            
            #line 38 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 foreach (var item in Entity.Properties)
   { 
            
            #line default
            #line hidden
            this.Write("Public Property Get ");
            
            #line 40 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write("() As ");
            
            #line 40 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Value.Type));
            
            #line default
            #line hidden
            this.Write("\r\n    ");
            
            #line 41 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write(" = this.");
            
            #line 41 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write("\r\nEnd Property\r\nPublic Property Let ");
            
            #line 43 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write("(ByVal Value As ");
            
            #line 43 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Value.Type));
            
            #line default
            #line hidden
            this.Write(")\r\n    this.");
            
            #line 44 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write(" = Value\r\nEnd Property\r\n\r\n");
            
            #line 47 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 } // end of foreach

            
            #line default
            #line hidden
            this.Write(@"
' =============================================================================
' INTERFACE IMPLEMENTATIONS
' =============================================================================

Private Property Get IMappable_MappedProperties() As Dictionary
    If mobjClassProperties Is Nothing Then
        Set mobjClassProperties = New Dictionary
        With mobjClassProperties
");
            
            #line 58 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 foreach (var item in Entity.Properties)
   { 
            
            #line default
            #line hidden
            this.Write("\t\t\t.Add \"");
            
            #line 60 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write("\", \"");
            
            #line 60 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Key));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 61 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
 } // end of foreach

            
            #line default
            #line hidden
            this.Write("        End With\r\n    End If\r\n    Set IMappable_MappedProperties = mobjClassPrope" +
                    "rties\r\nEnd Property\r\n\r\nPrivate Property Get IMappable_TableName() As String\r\n   " +
                    " IMappable_TableName = \"");
            
            #line 69 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.TableName));
            
            #line default
            #line hidden
            this.Write("\"\r\nEnd Property\r\n\r\nPrivate Function IMappable_CreateNew() As IMappable\r\n    Set I" +
                    "Mappable_CreateNew = New ");
            
            #line 73 "C:\Users\georg\source\repos\VbaOrmGenerator\OrmGenerator.Vba\T4\ModelClass.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Entity.Name));
            
            #line default
            #line hidden
            this.Write(@"
End Function
 
Private Function IMappable_GetPropertyValue(ByVal strPropertyName As String) As Variant
    IMappable_GetPropertyValue = CallByName(Me, strPropertyName, VbGet)
End Function

Private Sub IMappable_LetPropertyValue(ByVal strPropertyName As String, ByVal vntValue As Variant)
    CallByName Me, strPropertyName, VbCallType.VbLet, vntValue
End Sub
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class ModelClassBase
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
