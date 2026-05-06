using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsReplicateSchemaChange")]
    public class GoldenGatePipelineProcessOptionsReplicateSchemaChange : oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsReplicateSchemaChange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#can_replicate_schema_change GoldenGatePipeline#can_replicate_schema_change}.</summary>
        [JsiiProperty(name: "canReplicateSchemaChange", typeJson: "{\"primitive\":\"string\"}")]
        public string CanReplicateSchemaChange
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_ddl_error GoldenGatePipeline#action_on_ddl_error}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnDdlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnDdlError
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_dml_error GoldenGatePipeline#action_on_dml_error}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnDmlError", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnDmlError
        {
            get;
            set;
        }
    }
}
