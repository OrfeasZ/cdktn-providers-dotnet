using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails")]
    public class AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails : oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#private_endpoint_id AiVisionStreamSource#private_endpoint_id}.</summary>
        [JsiiProperty(name: "privateEndpointId", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateEndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#stream_access_type AiVisionStreamSource#stream_access_type}.</summary>
        [JsiiProperty(name: "streamAccessType", typeJson: "{\"primitive\":\"string\"}")]
        public string StreamAccessType
        {
            get;
            set;
        }
    }
}
