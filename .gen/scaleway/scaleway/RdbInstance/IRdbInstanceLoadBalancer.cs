using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.RdbInstance
{
    [JsiiInterface(nativeType: typeof(IRdbInstanceLoadBalancer), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceLoadBalancer")]
    public interface IRdbInstanceLoadBalancer
    {
        /// <summary>The endpoint ID.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#endpoint_id RdbInstance#endpoint_id}
        /// </remarks>
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndpointId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRdbInstanceLoadBalancer), fullyQualifiedName: "scaleway.rdbInstance.RdbInstanceLoadBalancer")]
        internal sealed class _Proxy : DeputyBase, scaleway.RdbInstance.IRdbInstanceLoadBalancer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The endpoint ID.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/rdb_instance#endpoint_id RdbInstance#endpoint_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndpointId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
