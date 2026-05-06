using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptions")]
    public class GoldenGatePipelineProcessOptions : oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptions
    {
        /// <summary>initial_data_load block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#initial_data_load GoldenGatePipeline#initial_data_load}
        /// </remarks>
        [JsiiProperty(name: "initialDataLoad", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad\"}")]
        public oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad InitialDataLoad
        {
            get;
            set;
        }

        /// <summary>replicate_schema_change block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#replicate_schema_change GoldenGatePipeline#replicate_schema_change}
        /// </remarks>
        [JsiiProperty(name: "replicateSchemaChange", typeJson: "{\"fqn\":\"oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange\"}")]
        public oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange ReplicateSchemaChange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#should_restart_on_failure GoldenGatePipeline#should_restart_on_failure}.</summary>
        [JsiiProperty(name: "shouldRestartOnFailure", typeJson: "{\"primitive\":\"string\"}")]
        public string ShouldRestartOnFailure
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#start_using_default_mapping GoldenGatePipeline#start_using_default_mapping}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startUsingDefaultMapping", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartUsingDefaultMapping
        {
            get;
            set;
        }
    }
}
