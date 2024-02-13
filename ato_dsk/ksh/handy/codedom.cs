using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;

//using Microsoft.VisualStudio.TestTools.UnitTesting;


   // [TestClass]
    public class Codedom
    {
     //   [TestMethod]
        public void Execute()
        {
            //c#
            CodeDomProvider provider = CodeDomProvider.CreateProvider("CSharp");
            //CodeDomProvider provider = CodeDomProvider.CreateProvider("VisualBasic");
            //CodeDomProvider provider = CodeDomProvider.CreateProvider("JScript");

            //生成对应的代码文件
            CodeDomExample.GenerateCode(provider, CodeDomExample.BuildHelloWorldGraph());

            //编译生成的代码文件
            CompilerResults cr = CodeDomExample.CompileCode(provider, "Evaluator.cs", "Evaluator.exe");
            if (cr.Errors.Count <= 0)
            {
                System.Console.WriteLine("把 Evaluator.cs 编译成 " + cr.PathToAssembly + " 时没有出现错误。");
            }
            //CodeDomExample.CompileCode(provider, "Evaluator.vb", "Evaluator.exe");
            //CodeDomExample.CompileCode(provider, "Evaluator.js", "Evaluator.exe");
        }

        public class CodeDomExample
        {
            /// <summary>
            /// 利用 System.CodeDom 对象生成一个 Hello World 程序的结构图
            /// </summary>
            /// <returns></returns>
            public static CodeCompileUnit BuildHelloWorldGraph()
            {
                // 新建一个 CodeCompileUnit 来包含程序图纸
                CodeCompileUnit compileUnit = new CodeCompileUnit();
            
                // 声明一个名称为 Samples 的新命名空间
                CodeNamespace samples = new CodeNamespace("Evaluator");
                // 把新命名空间添加到程序编译单元中
                compileUnit.Namespaces.Add(samples);

                // 添加新的命名空间（System 命名空间）的引用
                samples.Imports.Add(new CodeNamespaceImport("System"));    // 添加新的命名空间（System 命名空间）的引用
                samples.Imports.Add(new CodeNamespaceImport("System.IO"));
                samples.Imports.Add(new CodeNamespaceImport("System.IO.Directory"));
                // 定义一个新类，取名为 Eval
                CodeTypeDeclaration class1 = new CodeTypeDeclaration("Eval");
                
                // 把 Class1 添加到 Samples 命名空间中
                samples.Types.Add(class1);

                // 定义新的代码入口点（Main 方法）
                CodeEntryPointMethod start = new CodeEntryPointMethod();

                // 为 System.Console 类创建一个类型引用
                CodeTypeReferenceExpression systemConsoleType = new CodeTypeReferenceExpression("System.Console");

                // 构建一个 Console.WriteLine 方法的声明
                CodeMethodInvokeExpression cs1 = new CodeMethodInvokeExpression(
                    systemConsoleType,
                    "WriteLine",
                    new CodePrimitiveExpression("Hello World!"));

                // 把 WriteLine 方法添加到 Main 方法中
                start.Statements.Add(cs1);

                // 构建另一个 Console.WriteLine 方法的声明
                CodeMethodInvokeExpression cs2 = new CodeMethodInvokeExpression(
                    systemConsoleType,
                    "WriteLine",
                    new CodePrimitiveExpression("Press the Enter key to continue."));

                // 把 WriteLine 方法添加到 Main 方法中
                start.Statements.Add(cs2);

                // 构建 Console.ReadLine 方法的声明
                CodeMethodInvokeExpression csReadLine = new CodeMethodInvokeExpression(
                    systemConsoleType,
                    "ReadLine");

                // 把 ReadLine 方法添加到 Main 方法中
                start.Statements.Add(csReadLine);
                
                CodeTypeReferenceExpression iotype = new CodeTypeReferenceExpression("System.IO.Directory");
           
                    var directory = new CodeMethodInvokeExpression(
                    iotype,
                    "CreateDirectory(\"wser\")");
                //System.IO.Directory.CreateDirectory()
                // 把 ReadLine 方法添加到 Main 方法中
                start.Statements.Add(directory);

                
                // 把 Main 方法添加 Class1 类中
                class1.Members.Add(start);

                return compileUnit;
            }

            /// <summary>
            /// 生成代码文件
            /// </summary>
            /// <param name="provider">CodeDomProvider对象</param>
            /// <param name="compileunit">CodeCompileUnit对象</param>
            public static void GenerateCode(CodeDomProvider provider, CodeCompileUnit compileunit)
            {
                // 把源文件编译成相应格式的程序文件
                string sourceFile;
                if (provider.FileExtension[0] == '.')
                {
                    sourceFile = "Evaluator" + provider.FileExtension;
                }
                else
                {
                    sourceFile = "Evaluator." + provider.FileExtension;
                }

                // 新建一个 IndentedTextWriter 对象，
                // 其构造函数包含一个读取源文件的 StreamWriter 对象
                IndentedTextWriter tw = new IndentedTextWriter(new StreamWriter(sourceFile, false), "");
                // 利用生成器生成源代码
                provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());
   
                // 关闭文件输出流
                tw.Close();
            }

            /// <summary>
            /// 把代码文件编译可执行文件（*.exe）
            /// </summary>
            /// <param name="provider">CodeDomProvider对象</param>
            /// <param name="sourceFile">源文件名称</param>
            /// <param name="exeFile">生成的可执行文件的名称</param>
            /// <returns></returns>
            public static CompilerResults CompileCode(CodeDomProvider provider, string sourceFile, string exeFile)
            {
                // 配置一个 CompilerParameters 对象，它依赖 System.dll
                // 并生成指定的可执行的文件
                string[] referenceAssemblies = { "System.dll" };
                CompilerParameters cp = new CompilerParameters(referenceAssemblies, exeFile, false);
                // 生成一个可执行文件，而不是一个 DLL 文件
                cp.GenerateExecutable = true;

                // 调用编译器
                CompilerResults cr = provider.CompileAssemblyFromFile(cp, sourceFile);

                // 返回编译结果
                return cr;
            }
        }
    }

