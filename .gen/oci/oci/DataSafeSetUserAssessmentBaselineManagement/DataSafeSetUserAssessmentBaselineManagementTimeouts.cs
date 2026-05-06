using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSetUserAssessmentBaselineManagement
{
    [JsiiByValue(fqn: "oci.dataSafeSetUserAssessmentBaselineManagement.DataSafeSetUserAssessmentBaselineManagementTimeouts")]
    public class DataSafeSetUserAssessmentBaselineManagementTimeouts : oci.DataSafeSetUserAssessmentBaselineManagement.IDataSafeSetUserAssessmentBaselineManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_user_assessment_baseline_management#create DataSafeSetUserAssessmentBaselineManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_user_assessment_baseline_management#delete DataSafeSetUserAssessmentBaselineManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_set_user_assessment_baseline_management#update DataSafeSetUserAssessmentBaselineManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
