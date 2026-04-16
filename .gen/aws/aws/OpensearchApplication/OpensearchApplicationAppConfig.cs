using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchApplication
{
    [JsiiByValue(fqn: "aws.opensearchApplication.OpensearchApplicationAppConfig")]
    public class OpensearchApplicationAppConfig : aws.OpensearchApplication.IOpensearchApplicationAppConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_application#key OpensearchApplication#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/opensearch_application#value OpensearchApplication#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
