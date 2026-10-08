using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicyHealthReportManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTargetCredentials")]
    public class DataSafeSubsettingPolicyHealthReportManagementTargetCredentials : oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#password DataSafeSubsettingPolicyHealthReportManagement#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_policy_health_report_management#user_name DataSafeSubsettingPolicyHealthReportManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
