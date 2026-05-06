using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamGroup
{
    [JsiiByValue(fqn: "oci.aiVisionStreamGroup.AiVisionStreamGroupStreamOverlaps")]
    public class AiVisionStreamGroupStreamOverlaps : oci.AiVisionStreamGroup.IAiVisionStreamGroupStreamOverlaps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_group#overlapping_streams AiVisionStreamGroup#overlapping_streams}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overlappingStreams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? OverlappingStreams
        {
            get;
            set;
        }
    }
}
