using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    [JsiiInterface(nativeType: typeof(IGoldenGatePipelineProcessOptions), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptions")]
    public interface IGoldenGatePipelineProcessOptions
    {
        /// <summary>initial_data_load block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#initial_data_load GoldenGatePipeline#initial_data_load}
        /// </remarks>
        [JsiiProperty(name: "initialDataLoad", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}")]
        oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad InitialDataLoad
        {
            get;
        }

        /// <summary>replicate_schema_change block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#replicate_schema_change GoldenGatePipeline#replicate_schema_change}
        /// </remarks>
        [JsiiProperty(name: "replicateSchemaChange", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}")]
        oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange ReplicateSchemaChange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#should_restart_on_failure GoldenGatePipeline#should_restart_on_failure}.</summary>
        [JsiiProperty(name: "shouldRestartOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        string ShouldRestartOnFailure
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#start_using_default_mapping GoldenGatePipeline#start_using_default_mapping}.</summary>
        [JsiiProperty(name: "startUsingDefaultMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartUsingDefaultMapping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGatePipelineProcessOptions), fullyQualifiedName: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptions")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>initial_data_load block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#initial_data_load GoldenGatePipeline#initial_data_load}
            /// </remarks>
            [JsiiProperty(name: "initialDataLoad", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}")]
            public oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad InitialDataLoad
            {
                get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad>()!;
            }

            /// <summary>replicate_schema_change block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#replicate_schema_change GoldenGatePipeline#replicate_schema_change}
            /// </remarks>
            [JsiiProperty(name: "replicateSchemaChange", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}")]
            public oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange ReplicateSchemaChange
            {
                get => GetInstanceProperty<oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#should_restart_on_failure GoldenGatePipeline#should_restart_on_failure}.</summary>
            [JsiiProperty(name: "shouldRestartOnFailure", typeJson: "{\"primitive\":\"string\"}")]
            public string ShouldRestartOnFailure
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#start_using_default_mapping GoldenGatePipeline#start_using_default_mapping}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startUsingDefaultMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartUsingDefaultMapping
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
