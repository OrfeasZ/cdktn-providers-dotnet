using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineSink
{
    [JsiiInterface(nativeType: typeof(IPipelineSinkConfigCredentials), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigCredentials")]
    public interface IPipelineSinkConfigCredentials
    {
        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#access_key_id PipelineSink#access_key_id}
        /// </remarks>
        [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string AccessKeyId
        {
            get;
        }

        /// <summary>Cloudflare Account ID for the bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#secret_access_key PipelineSink#secret_access_key}
        /// </remarks>
        [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
        string SecretAccessKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPipelineSinkConfigCredentials), fullyQualifiedName: "cloudflare.pipelineSink.PipelineSinkConfigCredentials")]
        internal sealed class _Proxy : DeputyBase, cloudflare.PipelineSink.IPipelineSinkConfigCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Cloudflare Account ID for the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#access_key_id PipelineSink#access_key_id}
            /// </remarks>
            [JsiiProperty(name: "accessKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccessKeyId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Cloudflare Account ID for the bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_sink#secret_access_key PipelineSink#secret_access_key}
            /// </remarks>
            [JsiiProperty(name: "secretAccessKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretAccessKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
