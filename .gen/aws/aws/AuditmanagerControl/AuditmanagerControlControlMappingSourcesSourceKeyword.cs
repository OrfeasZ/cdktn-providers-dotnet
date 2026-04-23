using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    [JsiiByValue(fqn: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
    public class AuditmanagerControlControlMappingSourcesSourceKeyword : aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordInputType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordValue
        {
            get;
            set;
        }
    }
}
