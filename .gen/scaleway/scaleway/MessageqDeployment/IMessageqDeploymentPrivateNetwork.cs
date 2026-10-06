using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.MessageqDeployment
{
    [JsiiInterface(nativeType: typeof(IMessageqDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.messageqDeployment.MessageqDeploymentPrivateNetwork")]
    public interface IMessageqDeploymentPrivateNetwork
    {
        /// <summary>UUID of the Private Network.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/messageq_deployment#private_network_id MessageqDeployment#private_network_id}
        /// </remarks>
        [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateNetworkId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMessageqDeploymentPrivateNetwork), fullyQualifiedName: "scaleway.messageqDeployment.MessageqDeploymentPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.MessageqDeployment.IMessageqDeploymentPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>UUID of the Private Network.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.85.0/docs/resources/messageq_deployment#private_network_id MessageqDeployment#private_network_id}
            /// </remarks>
            [JsiiProperty(name: "privateNetworkId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateNetworkId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
