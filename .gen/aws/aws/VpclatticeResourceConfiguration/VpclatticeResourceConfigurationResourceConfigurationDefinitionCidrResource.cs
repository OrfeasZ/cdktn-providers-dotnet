using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeResourceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource")]
    public class VpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource : aws.VpclatticeResourceConfiguration.IVpclatticeResourceConfigurationResourceConfigurationDefinitionCidrResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.71.0/docs/resources/vpclattice_resource_configuration#cidr_ranges VpclatticeResourceConfiguration#cidr_ranges}.</summary>
        [JsiiProperty(name: "cidrRanges", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CidrRanges
        {
            get;
            set;
        }
    }
}
