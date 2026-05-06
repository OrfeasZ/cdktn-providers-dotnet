using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetails")]
    public class AiVisionStreamSourceStreamSourceDetails : oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#camera_url AiVisionStreamSource#camera_url}.</summary>
        [JsiiProperty(name: "cameraUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string CameraUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#source_type AiVisionStreamSource#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string SourceType
        {
            get;
            set;
        }

        /// <summary>stream_network_access_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#stream_network_access_details AiVisionStreamSource#stream_network_access_details}
        /// </remarks>
        [JsiiProperty(name: "streamNetworkAccessDetails", typeJson: "{\"fqn\":\"oci.aiVisionStreamSource.AiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails\"}")]
        public oci.AiVisionStreamSource.IAiVisionStreamSourceStreamSourceDetailsStreamNetworkAccessDetails StreamNetworkAccessDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_source#secret_id AiVisionStreamSource#secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretId
        {
            get;
            set;
        }
    }
}
