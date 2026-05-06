using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityAssessmentFinding
{
    [JsiiByValue(fqn: "oci.dataSafeSecurityAssessmentFinding.DataSafeSecurityAssessmentFindingTimeouts")]
    public class DataSafeSecurityAssessmentFindingTimeouts : oci.DataSafeSecurityAssessmentFinding.IDataSafeSecurityAssessmentFindingTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding#create DataSafeSecurityAssessmentFinding#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding#delete DataSafeSecurityAssessmentFinding#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/data_safe_security_assessment_finding#update DataSafeSecurityAssessmentFinding#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
