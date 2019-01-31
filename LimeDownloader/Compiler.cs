using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System;

namespace LimeDownloader
{
    class Compiler
    {
        public static bool CompileFromSource(string source, string Output, string Icon = null)
        {
            string CopyIcon = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\icon.ico";

            CompilerParameters CParams = new CompilerParameters();
            Dictionary<string, string> ProviderOptions = new Dictionary<string, string>();
            ProviderOptions.Add("CompilerVersion", "v4.0");

            string options = "/target:winexe /platform:x86 /optimize+";
            if (Icon != null)
            {
                File.Copy(Icon, CopyIcon,true);
                options += " /win32icon:\"" + CopyIcon + "\"";

            }

            CParams.GenerateExecutable = true;
            CParams.OutputAssembly = Output;
            CParams.CompilerOptions = options;
            CParams.TreatWarningsAsErrors = false;
            CParams.IncludeDebugInformation = false;
            CParams.ReferencedAssemblies.Add("System.dll");
            CParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");
            CParams.ReferencedAssemblies.Add("System.Drawing.dll");
            CParams.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");

            CompilerResults Results = new CSharpCodeProvider(ProviderOptions).CompileAssemblyFromSource(CParams, source);

            if (Results.Errors.Count > 0)
            {
               MessageBox.Show(string.Format("The compiler has encountered {0} errors",
                    Results.Errors.Count), "Errors while compiling", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                foreach (CompilerError Err in Results.Errors)
                {
                    MessageBox.Show(string.Format("{0}\nLine: {1} - Column: {2}\nFile: {3}", Err.ErrorText,
                        Err.Line, Err.Column, Err.FileName), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                File.Delete(CopyIcon);
                return false;

            }
            else
            {
                File.Delete(CopyIcon);
                return true;
            }

        }
    }
}
