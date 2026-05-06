using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeMaskingPolicyHealthReportManagement
{
    [JsiiByValue(fqn: "oci.dataSafeMaskingPolicyHealthReportManagement.DataSafeMaskingPolicyHealthReportManagementTimeouts")]
    public class DataSafeMaskingPolicyHealthReportManagementTimeouts : oci.DataSafeMaskingPolicyHealthReportManagement.IDataSafeMaskingPolicyHealthReportManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy_health_report_management#create DataSafeMaskingPolicyHealthReportManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy_health_report_management#delete DataSafeMaskingPolicyHealthReportManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_masking_policy_health_report_management#update DataSafeMaskingPolicyHealthReportManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
