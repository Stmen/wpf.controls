﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.32559
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Utility.Resources {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class DefaultErrorMessages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal DefaultErrorMessages() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Utility.Resources.DefaultErrorMessages", typeof(DefaultErrorMessages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 {0}参数不可为NULL。 的本地化字符串。
        /// </summary>
        public static string ArgumentNotNull {
            get {
                return ResourceManager.GetString("ArgumentNotNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}参数不可为NULL或者空字符。 的本地化字符串。
        /// </summary>
        public static string ArgumentNotNullOrEmpty {
            get {
                return ResourceManager.GetString("ArgumentNotNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 必须为 {1} 到 {2}之间的值。 的本地化字符串。
        /// </summary>
        public static string Compare {
            get {
                return ResourceManager.GetString("Compare", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 的值为NULL或者不是有效的日期值。 的本地化字符串。
        /// </summary>
        public static string DateTimeRequired {
            get {
                return ResourceManager.GetString("DateTimeRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 不是有效的值。 的本地化字符串。
        /// </summary>
        public static string Default {
            get {
                return ResourceManager.GetString("Default", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 不存在指定文件{0}。 的本地化字符串。
        /// </summary>
        public static string FileMustExist {
            get {
                return ResourceManager.GetString("FileMustExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 长度必须介于 {1} 与 {2}之间。 的本地化字符串。
        /// </summary>
        public static string Length {
            get {
                return ResourceManager.GetString("Length", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 不能为空字符串。 的本地化字符串。
        /// </summary>
        public static string NotEmpty {
            get {
                return ResourceManager.GetString("NotEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 必须介于 {1} 与 {2}之间。 的本地化字符串。
        /// </summary>
        public static string Range {
            get {
                return ResourceManager.GetString("Range", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 必须匹配表达式 {1}. 的本地化字符串。
        /// </summary>
        public static string Regex {
            get {
                return ResourceManager.GetString("Regex", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 为NULL或者不是有效的值。 的本地化字符串。
        /// </summary>
        public static string Required {
            get {
                return ResourceManager.GetString("Required", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0} 的值为NULL或者是空字符。 的本地化字符串。
        /// </summary>
        public static string StringRequired {
            get {
                return ResourceManager.GetString("StringRequired", resourceCulture);
            }
        }
    }
}
