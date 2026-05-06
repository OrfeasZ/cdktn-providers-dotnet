using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnsetUserAssessmentBaseline
{
    [JsiiByValue(fqn: "oci.dataSafeUnsetUserAssessmentBaseline.DataSafeUnsetUserAssessmentBaselineTimeouts")]
    public class DataSafeUnsetUserAssessmentBaselineTimeouts : oci.DataSafeUnsetUserAssessmentBaseline.IDataSafeUnsetUserAssessmentBaselineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline#create DataSafeUnsetUserAssessmentBaseline#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline#delete DataSafeUnsetUserAssessmentBaseline#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_user_assessment_baseline#update DataSafeUnsetUserAssessmentBaseline#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
