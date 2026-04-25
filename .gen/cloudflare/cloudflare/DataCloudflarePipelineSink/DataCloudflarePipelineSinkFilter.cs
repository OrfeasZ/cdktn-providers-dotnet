using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineSink
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflarePipelineSink.DataCloudflarePipelineSinkFilter")]
    public class DataCloudflarePipelineSinkFilter : cloudflare.DataCloudflarePipelineSink.IDataCloudflarePipelineSinkFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_sink#pipeline_id DataCloudflarePipelineSink#pipeline_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PipelineId
        {
            get;
            set;
        }
    }
}
