using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.PipelineStream
{
    [JsiiByValue(fqn: "cloudflare.pipelineStream.PipelineStreamHttpCors")]
    public class PipelineStreamHttpCors : cloudflare.PipelineStream.IPipelineStreamHttpCors
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.19.0/docs/resources/pipeline_stream#origins PipelineStream#origins}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Origins
        {
            get;
            set;
        }
    }
}
