using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingReportManagement
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingReportManagementTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentials")]
    public interface IDataSafeSubsettingReportManagementTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_report_management#password DataSafeSubsettingReportManagement#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_report_management#user_name DataSafeSubsettingReportManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingReportManagementTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_report_management#password DataSafeSubsettingReportManagement#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_report_management#user_name DataSafeSubsettingReportManagement#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
