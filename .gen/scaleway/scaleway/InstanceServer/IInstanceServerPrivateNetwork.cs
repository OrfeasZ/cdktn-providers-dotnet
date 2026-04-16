using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceServer
{
    [JsiiInterface(nativeType: typeof(IInstanceServerPrivateNetwork), fullyQualifiedName: "scaleway.instanceServer.InstanceServerPrivateNetwork")]
    public interface IInstanceServerPrivateNetwork
    {
        /// <summary>The Private Network ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#pn_id InstanceServer#pn_id}
        /// </remarks>
        [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
        string PnId
        {
            get;
        }

        /// <summary>The zone you want to attach the resource to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#zone InstanceServer#zone}
        /// </remarks>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstanceServerPrivateNetwork), fullyQualifiedName: "scaleway.instanceServer.InstanceServerPrivateNetwork")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstanceServer.IInstanceServerPrivateNetwork
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The Private Network ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#pn_id InstanceServer#pn_id}
            /// </remarks>
            [JsiiProperty(name: "pnId", typeJson: "{\"primitive\":\"string\"}")]
            public string PnId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The zone you want to attach the resource to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_server#zone InstanceServer#zone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
