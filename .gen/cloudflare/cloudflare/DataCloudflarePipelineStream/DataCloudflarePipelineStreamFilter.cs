using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflarePipelineStream
{
    [JsiiByValue(fqn: "cloudflare.dataCloudflarePipelineStream.DataCloudflarePipelineStreamFilter")]
    public class DataCloudflarePipelineStreamFilter : cloudflare.DataCloudflarePipelineStream.IDataCloudflarePipelineStreamFilter
    {
        /// <summary>Specifies the public ID of the pipeline.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/data-sources/pipeline_stream#pipeline_id DataCloudflarePipelineStream#pipeline_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "pipelineId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PipelineId
        {
            get;
            set;
        }
    }
}
