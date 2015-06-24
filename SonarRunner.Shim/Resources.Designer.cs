﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SonarRunner.Shim {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SonarRunner.Shim.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Calling the sonar-runner....
        /// </summary>
        internal static string DIAG_CallingSonarRunner {
            get {
                return ResourceManager.GetString("DIAG_CallingSonarRunner", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File is not under the project directory and cannot currently be analysed by SonarQube. File: {0}, project: {1}.
        /// </summary>
        internal static string DIAG_FileIsOutsideProjectDirectory {
            get {
                return ResourceManager.GetString("DIAG_FileIsOutsideProjectDirectory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generating SonarQube project properties file to {0}.
        /// </summary>
        internal static string DIAG_GeneratingProjectProperties {
            get {
                return ResourceManager.GetString("DIAG_GeneratingProjectProperties", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project does not contain any files that can analyzed by SonarQube. Project file: {0}.
        /// </summary>
        internal static string DIAG_NoFilesToAnalyze {
            get {
                return ResourceManager.GetString("DIAG_NoFilesToAnalyze", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The exclude flag has been set so the project will not be analyzed by SonarQube. Project file: {0}.
        /// </summary>
        internal static string DIAG_ProjectIsExcluded {
            get {
                return ResourceManager.GetString("DIAG_ProjectIsExcluded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Generation of the sonar-properties file failed. Unable to complete SonarQube analysis..
        /// </summary>
        internal static string DIAG_PropertiesGenerationFailed {
            get {
                return ResourceManager.GetString("DIAG_PropertiesGenerationFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sonar-runner has finished.
        /// </summary>
        internal static string DIAG_SonarRunnerCompleted {
            get {
                return ResourceManager.GetString("DIAG_SonarRunnerCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Writing processing summary to {0}.
        /// </summary>
        internal static string DIAG_WritingSummary {
            get {
                return ResourceManager.GetString("DIAG_WritingSummary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An error occurred loading the analysis config file. Please check that it is a valid file and try again. Error: {0}.
        /// </summary>
        internal static string ERR_ErrorLoadingConfigFile {
            get {
                return ResourceManager.GetString("ERR_ErrorLoadingConfigFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The specified analysis config file does not exist: {0}.
        /// </summary>
        internal static string ERR_InvalidAnalysisConfigFilePath {
            get {
                return ResourceManager.GetString("ERR_InvalidAnalysisConfigFilePath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected to be called with one argument: the full path to the analysis config file.
        /// </summary>
        internal static string ERR_InvalidCommandLineArgs {
            get {
                return ResourceManager.GetString("ERR_InvalidCommandLineArgs", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No ProjectInfo.xml files were found. Check that the analysis targets are referenced by the MSBuild projects being built..
        /// </summary>
        internal static string ERR_NoProjectInfoFilesFound {
            get {
                return ResourceManager.GetString("ERR_NoProjectInfoFilesFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No valid projectInfo.xml were found. SonarQube analysis will not be performed..
        /// </summary>
        internal static string ERR_NoValidProjectInfoFiles {
            get {
                return ResourceManager.GetString("ERR_NoValidProjectInfoFiles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sonar-runner did not complete successfully.
        /// </summary>
        internal static string ERR_SonarRunnerExecutionFailed {
            get {
                return ResourceManager.GetString("ERR_SonarRunnerExecutionFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis setting key &quot;{0}&quot; set in the {1} is overridden by the value set in {2}.
        /// </summary>
        internal static string INFO_ConfigSettingOverridden {
            get {
                return ResourceManager.GetString("INFO_ConfigSettingOverridden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting &quot;{0}&quot; is assigned the same value in multiple locations. Locations: {1}.
        /// </summary>
        internal static string INFO_DuplicateSettingWithSameValue {
            get {
                return ResourceManager.GetString("INFO_DuplicateSettingWithSameValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} is not configured. Setting it to the default value of {1}.
        /// </summary>
        internal static string INFO_SonarRunnerOptsDefaultUsed {
            get {
                return ResourceManager.GetString("INFO_SonarRunnerOptsDefaultUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Excluded projects.
        /// </summary>
        internal static string REPORT_ExcludedProjectsTitle {
            get {
                return ResourceManager.GetString("REPORT_ExcludedProjectsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid projects.
        /// </summary>
        internal static string REPORT_InvalidProjectsTitle {
            get {
                return ResourceManager.GetString("REPORT_InvalidProjectsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {none}.
        /// </summary>
        internal static string REPORT_NoProjectsOfType {
            get {
                return ResourceManager.GetString("REPORT_NoProjectsOfType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Product projects.
        /// </summary>
        internal static string REPORT_ProductProjectsTitle {
            get {
                return ResourceManager.GetString("REPORT_ProductProjectsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skipped projects.
        /// </summary>
        internal static string REPORT_SkippedProjectsTitle {
            get {
                return ResourceManager.GetString("REPORT_SkippedProjectsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Test projects.
        /// </summary>
        internal static string REPORT_TestProjectsTitle {
            get {
                return ResourceManager.GetString("REPORT_TestProjectsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string String1 {
            get {
                return ResourceManager.GetString("String1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Code coverage report does not exist at the specified location. Path: {0}.
        /// </summary>
        internal static string WARN_CodeCoverageReportNotFound {
            get {
                return ResourceManager.GetString("WARN_CodeCoverageReportNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Core setting &quot;{0}&quot; can only be set as a property in the analysis config file. The attempts to set the value in the following locations will be ignored: {1}.
        /// </summary>
        internal static string WARN_CoreSettingCannotBeSet {
            get {
                return ResourceManager.GetString("WARN_CoreSettingCannotBeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Duplicate project GUID: &quot;{0}&quot;. Check that the project is only being built for a single platform/configuration and that that the project guid is unique. The project will not be analyzed by SonarQube. Project file: {1}.
        /// </summary>
        internal static string WARN_DuplicateProjectGuid {
            get {
                return ResourceManager.GetString("WARN_DuplicateProjectGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting &quot;{0}&quot; is assigned different values in multiple locations. These assignments will be ignored. Locations: {1}.
        /// </summary>
        internal static string WARN_DuplicateSettingWithDifferentValue {
            get {
                return ResourceManager.GetString("WARN_DuplicateSettingWithDifferentValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File referenced in the project does not exist: {0}.
        /// </summary>
        internal static string WARN_FileDoesNotExist {
            get {
                return ResourceManager.GetString("WARN_FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to FxCop analysis report does not exist at the specified location. Path: {0}.
        /// </summary>
        internal static string WARN_FxCopReportNotFound {
            get {
                return ResourceManager.GetString("WARN_FxCopReportNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The project has an invalid GUID &quot;{0}&quot;. The project will not be analyzed by SonarQube. Project file: {1}.
        /// </summary>
        internal static string WARN_InvalidProjectGuid {
            get {
                return ResourceManager.GetString("WARN_InvalidProjectGuid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Analysis setting key &quot;{0}&quot; is invalid and will be ignored. Source of the invalid key: {1}.
        /// </summary>
        internal static string WARN_InvalidSettingKey {
            get {
                return ResourceManager.GetString("WARN_InvalidSettingKey", resourceCulture);
            }
        }
    }
}