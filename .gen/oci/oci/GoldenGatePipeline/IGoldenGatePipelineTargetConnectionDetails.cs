using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiInterface(nativeType: typeof(IGoldenGatePipelineTargetConnectionDetails), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetails")]
    public interface IGoldenGatePipelineTargetConnectionDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#connection_id GoldenGatePipeline#connection_id}.</summary>
        [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
        string ConnectionId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGatePipelineTargetConnectionDetails), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineTargetConnectionDetails")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGatePipeline.IGoldenGatePipelineTargetConnectionDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#connection_id GoldenGatePipeline#connection_id}.</summary>
            [JsiiProperty(name: "connectionId", typeJson: "{\"primitive\":\"string\"}")]
            public string ConnectionId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
