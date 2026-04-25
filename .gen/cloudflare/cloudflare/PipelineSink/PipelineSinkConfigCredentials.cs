using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.pipelineSink.PipelineSinkConfigCredentials")]
    public class PipelineSinkConfigCredentials : cloudflare.PipelineSink.IPipelineSinkConfigCredentials
    {
        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#access_key_id PipelineSink#access_key_id}
        /// </remarks>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public string AccessKeyId
        {
            get;
            set;
        }

        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#secret_access_key PipelineSink#secret_access_key}
        /// </remarks>
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretAccessKey
        {
            get;
            set;
        }
    }
}
