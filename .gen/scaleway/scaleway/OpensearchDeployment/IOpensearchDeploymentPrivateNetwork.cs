using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.OpensearchDeployment
{
    [JsiiInterface(nativeType: typeof(IOpensearchDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork")]
    public interface IOpensearchDeploymentPrivateNetwork
    {
        /// <summary>UUID of the Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#private_network_id OpensearchDeployment#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateNetworkId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOpensearchDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.opensearchDeployment.OpensearchDeploymentPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.OpensearchDeployment.IOpensearchDeploymentPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the Private Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/opensearch_deployment#private_network_id OpensearchDeployment#private_network_id}
            /// </remarks>
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
