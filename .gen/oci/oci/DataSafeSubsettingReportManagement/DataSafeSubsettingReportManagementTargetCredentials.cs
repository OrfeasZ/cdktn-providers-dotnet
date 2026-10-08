using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingReportManagement
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.dataSafeSubsettingReportManagement.DataSafeSubsettingReportManagementTargetCredentials")]
    public class DataSafeSubsettingReportManagementTargetCredentials : oci.DataSafeSubsettingReportManagement.IDataSafeSubsettingReportManagementTargetCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_report_management#password DataSafeSubsettingReportManagement#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.9.0/docs/resources/data_safe_subsetting_report_management#user_name DataSafeSubsettingReportManagement#user_name}.</summary>
        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public string UserName
        {
            get;
            set;
        }
    }
}
