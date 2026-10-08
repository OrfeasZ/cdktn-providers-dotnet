using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicyHealthReportManagement
{
    [JsiiInterface(nativeType: typeof(IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentials")]
    public interface IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#password DataSafeSubsettingPolicyHealthReportManagement#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#user_name DataSafeSubsettingPolicyHealthReportManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        string UserName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials), fullyQualifiedName: "oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentials")]
        internal sealed class _Proxy : DeputyBase, oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#password DataSafeSubsettingPolicyHealthReportManagement#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#user_name DataSafeSubsettingPolicyHealthReportManagement#user_name}.</summary>
            [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
            public string UserName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
