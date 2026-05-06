using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeUnsetSecurityAssessmentBaseline
{
    [JsiiByValue(fqn: "oci.dataSafeUnsetSecurityAssessmentBaseline.DataSafeUnsetSecurityAssessmentBaselineTimeouts")]
    public class DataSafeUnsetSecurityAssessmentBaselineTimeouts : oci.DataSafeUnsetSecurityAssessmentBaseline.IDataSafeUnsetSecurityAssessmentBaselineTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline#create DataSafeUnsetSecurityAssessmentBaseline#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline#delete DataSafeUnsetSecurityAssessmentBaseline#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_unset_security_assessment_baseline#update DataSafeUnsetSecurityAssessmentBaseline#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
