using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStream
{
    [JsiiInterface(nativeType: typeof(IDataCloudflarePipelineStreamFilter), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamFilter")]
    public interface IDataCloudflarePipelineStreamFilter
    {
        /// <summary>Specifies the public ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_stream#pipeline_id DataCloudflarePipelineStream#pipeline_id}
        /// </remarks>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflarePipelineStreamFilter), fullyQualifiedName: "cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the public ID of the pipeline.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_stream#pipeline_id DataCloudflarePipelineStream#pipeline_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
