using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineSink
{
    [JsiiInterface(nativeType: typeof(IDataCloudflarePipelineSinkFilter), fullyQualifiedName: "cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkFilter")]
    public interface IDataCloudflarePipelineSinkFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_sink#pipeline_id DataCloudflarePipelineSink#pipeline_id}.</summary>
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PipelineId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflarePipelineSinkFilter), fullyQualifiedName: "cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_sink#pipeline_id DataCloudflarePipelineSink#pipeline_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PipelineId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
