using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamSource
{
    [JsiiInterface(nativeType: typeof(IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails), fullyQualifiedName: "oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails")]
    public interface IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#private_endpoint_id AiVisionStreamSource#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        string PrivateEndpointId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#stream_access_type AiVisionStreamSource#stream_access_type}.</summary>
        [JsiiProperty(name: "streamAccessType", typeJson: "{\"primitive\":\"string\"}")]
        string StreamAccessType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails), fullyQualifiedName: "oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails")]
        internal sealed class _Proxy : DeputyBase, oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#private_endpoint_id AiVisionStreamSource#private_endpoint_id}.</summary>
            [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
            public string PrivateEndpointId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#stream_access_type AiVisionStreamSource#stream_access_type}.</summary>
            [JsiiProperty(name: "streamAccessType", typeJson: "{\"primitive\":\"string\"}")]
            public string StreamAccessType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
