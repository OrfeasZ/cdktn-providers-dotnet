using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSubsettingPolicyHealthReportManagement
{
    [JsiiByValue(fqn: "oci.dataSafeSubsettingPolicyHealthReportManagement.DataSafeSubsettingPolicyHealthReportManagementTimeouts")]
    public class DataSafeSubsettingPolicyHealthReportManagementTimeouts : oci.DataSafeSubsettingPolicyHealthReportManagement.IDataSafeSubsettingPolicyHealthReportManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_health_report_management#create DataSafeSubsettingPolicyHealthReportManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_health_report_management#delete DataSafeSubsettingPolicyHealthReportManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.8.0/docs/resources/data_safe_subsetting_policy_health_report_management#update DataSafeSubsettingPolicyHealthReportManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
