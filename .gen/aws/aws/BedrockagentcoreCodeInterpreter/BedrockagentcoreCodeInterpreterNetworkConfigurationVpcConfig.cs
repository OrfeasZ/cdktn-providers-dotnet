using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreCodeInterpreter
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.bedrockagentcoreCodeInterpreter.BedrockagentcoreCodeInterpreterNetworkConfigurationVpcConfig")]
    public class BedrockagentcoreCodeInterpreterNetworkConfigurationVpcConfig : aws.BedrockagentcoreCodeInterpreter.IBedrockagentcoreCodeInterpreterNetworkConfigurationVpcConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_code_interpreter#security_groups BedrockagentcoreCodeInterpreter#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] SecurityGroups
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/bedrockagentcore_code_interpreter#subnets BedrockagentcoreCodeInterpreter#subnets}.</summary>
        [JsiiProperty(name: "subnets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Subnets
        {
            get;
            set;
        }
    }
}
