using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCapability
{
    [JsiiByValue(fqn: "aws.eksCapability.EksCapabilityConfigurationArgoCdNetworkAccess")]
    public class EksCapabilityConfigurationArgoCdNetworkAccess : aws.EksCapability.IEksCapabilityConfigurationArgoCdNetworkAccess
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/eks_capability#vpce_ids EksCapability#vpce_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "vpceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VpceIds
        {
            get;
            set;
        }
    }
}
