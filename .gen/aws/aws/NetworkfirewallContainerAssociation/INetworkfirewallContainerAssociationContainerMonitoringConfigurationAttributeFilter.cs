using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallContainerAssociation
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter), fullyQualifiedName: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter")]
    public interface INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/networkfirewall_container_association#key NetworkfirewallContainerAssociation#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/networkfirewall_container_association#value NetworkfirewallContainerAssociation#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter), fullyQualifiedName: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/networkfirewall_container_association#key NetworkfirewallContainerAssociation#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/networkfirewall_container_association#value NetworkfirewallContainerAssociation#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
