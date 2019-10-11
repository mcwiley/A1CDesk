// ***********************************************************************
// Assembly         : A1CDesk
// Author           : m_c_w
// Created          : 10-05-2019
//
// Last Modified By : m_c_w
// Last Modified On : 10-05-2019
// ***********************************************************************
// <copyright file="Settings.Designer.cs" company="">
//     Copyright ©  2019
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace A1CDesk.Properties {


    /// <summary>
    /// Class Settings. This class cannot be inherited.
    /// Implements the <see cref="System.Configuration.ApplicationSettingsBase" />
    /// </summary>
    /// <seealso cref="System.Configuration.ApplicationSettingsBase" />
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {

        /// <summary>
        /// The default instance
        /// </summary>
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

        /// <summary>
        /// Gets the default.
        /// </summary>
        /// <value>The default.</value>
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }

        /// <summary>
        /// Gets the database 103045 a1cdb connection string.
        /// </summary>
        /// <value>The database 103045 a1cdb connection string.</value>
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=s13.winhost.com;Initial Catalog=DB_103045_a1cdb;Persist Security Info" +
            "=True;User ID=DB_103045_a1cdb_user;Password=Patty02$")]
        public string DB_103045_a1cdbConnectionString {
            get {
                return ((string)(this["DB_103045_a1cdbConnectionString"]));
            }
        }
    }
}
