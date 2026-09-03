using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcorePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcorePolicy.BedrockagentcorePolicyDefinitionCedar")]
    public class BedrockagentcorePolicyDefinitionCedar : aws.BedrockagentcorePolicy.IBedrockagentcorePolicyDefinitionCedar
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_policy#statement BedrockagentcorePolicy#statement}.</summary>
        [JsiiProperty(name: "statement", typeJson: "{\"primitive\":\"string\"}")]
        public string Statement
        {
            get;
            set;
        }
    }
}
