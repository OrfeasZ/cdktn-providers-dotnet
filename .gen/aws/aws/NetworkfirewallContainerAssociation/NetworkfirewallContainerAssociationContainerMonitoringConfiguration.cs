using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkfirewallContainerAssociation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfiguration")]
    public class NetworkfirewallContainerAssociationContainerMonitoringConfiguration : aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_container_association#cluster_arn NetworkfirewallContainerAssociation#cluster_arn}.</summary>
        [JsiiProperty(name: "clusterArn", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterArn
        {
            get;
            set;
        }

        private object? _attributeFilter;

        /// <summary>attribute_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/networkfirewall_container_association#attribute_filter NetworkfirewallContainerAssociation#attribute_filter}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributeFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.networkfirewallContainerAssociation.NetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AttributeFilter
        {
            get => _attributeFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.NetworkfirewallContainerAssociation.INetworkfirewallContainerAssociationContainerMonitoringConfigurationAttributeFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _attributeFilter = value;
            }
        }
    }
}
