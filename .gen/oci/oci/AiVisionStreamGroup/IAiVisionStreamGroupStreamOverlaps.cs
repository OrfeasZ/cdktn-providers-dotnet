using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiVisionStreamGroup
{
    [JsiiInterface(nativeType: typeof(IAiVisionStreamGroupStreamOverlaps), fullyQualifiedName: "oci.aiVisionStreamGroup.AiVisionStreamGroupStreamOverlaps")]
    public interface IAiVisionStreamGroupStreamOverlaps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_group#overlapping_streams AiVisionStreamGroup#overlapping_streams}.</summary>
        [JsiiProperty(name: "overlappingStreams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? OverlappingStreams
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAiVisionStreamGroupStreamOverlaps), fullyQualifiedName: "oci.aiVisionStreamGroup.AiVisionStreamGroupStreamOverlaps")]
        internal sealed class _Proxy : DeputyBase, oci.AiVisionStreamGroup.IAiVisionStreamGroupStreamOverlaps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/ai_vision_stream_group#overlapping_streams AiVisionStreamGroup#overlapping_streams}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "overlappingStreams", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? OverlappingStreams
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
