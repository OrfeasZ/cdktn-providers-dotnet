using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StreamingStreamPool
{
    [JsiiInterface(nativeType: typeof(IStreamingStreamPoolPrivateEndpointSettings), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolPrivateEndpointSettings")]
    public interface IStreamingStreamPoolPrivateEndpointSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#nsg_ids StreamingStreamPool#nsg_ids}.</summary>
        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NsgIds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#private_endpoint_ip StreamingStreamPool#private_endpoint_ip}.</summary>
        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PrivateEndpointIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#subnet_id StreamingStreamPool#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStreamingStreamPoolPrivateEndpointSettings), fullyQualifiedName: "oci.streamingStreamPool.StreamingStreamPoolPrivateEndpointSettings")]
        internal sealed class _Proxy : DeputyBase, oci.StreamingStreamPool.IStreamingStreamPoolPrivateEndpointSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#nsg_ids StreamingStreamPool#nsg_ids}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NsgIds
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#private_endpoint_ip StreamingStreamPool#private_endpoint_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PrivateEndpointIp
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/streaming_stream_pool#subnet_id StreamingStreamPool#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
