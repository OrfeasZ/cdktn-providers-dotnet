using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiInterface(nativeType: typeof(IGoldenGatePipelineProcessOptionsInitialDataLoad), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
    public interface IGoldenGatePipelineProcessOptionsInitialDataLoad
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
        [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
        string IsInitialLoad
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
        [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ActionOnExistingTable
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGatePipelineProcessOptionsInitialDataLoad), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
            [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
            public string IsInitialLoad
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ActionOnExistingTable
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
