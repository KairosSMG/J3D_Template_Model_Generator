﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace J3D_Template_Model_Generator.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.8.1.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C:\\")]
        public string 設定 {
            get {
                return ((string)(this["設定"]));
            }
            set {
                this["設定"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SuperBMD.exe ..\\FBX\\TestWaterPlanet.fbx ..\\Model\\TestWaterPlanet.bdl --rotate --b" +
            "dl --mat ..\\BTK\\Water_Temp\\Water_Temp_materials.json --texheader ..\\BTK\\Water_Te" +
            "mp\\Water_Temp_tex_headers.json")]
        public string expath {
            get {
                return ((string)(this["expath"]));
            }
            set {
                this["expath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("日本語")]
        public string LangageType {
            get {
                return ((string)(this["LangageType"]));
            }
            set {
                this["LangageType"] = value;
            }
        }
    }
}
