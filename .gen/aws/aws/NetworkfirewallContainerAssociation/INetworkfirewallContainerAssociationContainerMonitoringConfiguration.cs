using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallContainerAssociation
{
    [JsiiInterface(nativeType: typeof(INetworkfirewallContainerAssociationContainerMonitoringConfiguration), fullyQualifiedName: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfiguration")]
    public interface INetworkfirewallContainerAssociationContainerMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/networkfirewall_container_association#cluster_arn NetworkfirewallContainerAssociation#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        string ClusterArn
        {
            get;
        }

        /// <summary>attribute_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/networkfirewall_container_association#attribute_filter NetworkfirewallContainerAssociation#attribute_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "attributeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AttributeFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkfirewallContainerAssociationContainerMonitoringConfiguration), fullyQualifiedName: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/networkfirewall_container_association#cluster_arn NetworkfirewallContainerAssociation#cluster_arn}.</summary>
            [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ClusterArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>attribute_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.60.0/docs/resources/networkfirewall_container_association#attribute_filter NetworkfirewallContainerAssociation#attribute_filter}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attributeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AttributeFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
