using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiByValue(fqn: "aws.opensearchDomain.OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions")]
    public class OpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions : aws.OpensearchDomain.IOpensearchDomainAimlOptionsNaturalLanguageQueryGenerationOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/opensearch_domain#desired_state OpensearchDomain#desired_state}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DesiredState
        {
            get;
            set;
        }
    }
}
