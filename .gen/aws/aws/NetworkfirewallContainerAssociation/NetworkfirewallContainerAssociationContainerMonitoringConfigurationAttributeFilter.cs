using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallContainerAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter")]
    public class NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter : aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/networkfirewall_container_association#key NetworkfirewallContainerAssociation#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/networkfirewall_container_association#value NetworkfirewallContainerAssociation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
