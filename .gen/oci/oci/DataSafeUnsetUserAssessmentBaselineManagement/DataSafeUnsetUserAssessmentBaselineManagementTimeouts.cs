using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnsetUserAssessmentBaselineManagement
{
    [JsiiByValue(fqn: "oci.dataSafeUnsetUserAssessmentBaselineManagement.DataSafeUnsetUserAssessmentBaselineManagementTimeouts")]
    public class DataSafeUnsetUserAssessmentBaselineManagementTimeouts : oci.DataSafeUnsetUserAssessmentBaselineManagement.IDataSafeUnsetUserAssessmentBaselineManagementTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline_management#create DataSafeUnsetUserAssessmentBaselineManagement#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline_management#delete DataSafeUnsetUserAssessmentBaselineManagement#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline_management#update DataSafeUnsetUserAssessmentBaselineManagement#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
