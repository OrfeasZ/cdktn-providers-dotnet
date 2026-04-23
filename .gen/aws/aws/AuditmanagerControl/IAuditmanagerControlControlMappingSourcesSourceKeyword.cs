using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AuditmanagerControl
{
    [JsiiInterface(nativeType: typeof(IAuditmanagerControlControlMappingSourcesSourceKeyword), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
    public interface IAuditmanagerControlControlMappingSourcesSourceKeyword
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
        [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeywordInputType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
        [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeywordValue
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAuditmanagerControlControlMappingSourcesSourceKeyword), fullyQualifiedName: "aws.auditmanagerControl.AuditmanagerControlControlMappingSourcesSourceKeyword")]
        internal sealed class _Proxy : DeputyBase, aws.AuditmanagerControl.IAuditmanagerControlControlMappingSourcesSourceKeyword
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_input_type AuditmanagerControl#keyword_input_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keywordInputType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeywordInputType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/auditmanager_control#keyword_value AuditmanagerControl#keyword_value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keywordValue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeywordValue
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
