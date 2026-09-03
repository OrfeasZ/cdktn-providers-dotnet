using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EksCluster
{
    [JsiiInterface(nativeType: typeof(IEksClusterKubeApiServerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeApiServerConfig")]
    public interface IEksClusterKubeApiServerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#event_ttl EksCluster#event_ttl}.</summary>
        [JsiiProperty(name: "eventTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EventTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>service_node_port_range block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#service_node_port_range EksCluster#service_node_port_range}
        /// </remarks>
        [JsiiProperty(name: "serviceNodePortRange", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange? ServiceNodePortRange
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEksClusterKubeApiServerConfig), fullyQualifiedName: "aws.eksCluster.EksClusterKubeApiServerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.EksCluster.IEksClusterKubeApiServerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#event_ttl EksCluster#event_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "eventTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EventTtl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>service_node_port_range block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/eks_cluster#service_node_port_range EksCluster#service_node_port_range}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceNodePortRange", typeJson: "{\"fqn\":\"aws.eksCluster.EksClusterKubeApiServerConfigServiceNodePortRange\"}", isOptional: true)]
            public aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange? ServiceNodePortRange
            {
                get => GetInstanceProperty<aws.EksCluster.IEksClusterKubeApiServerConfigServiceNodePortRange?>();
            }
        }
    }
}
