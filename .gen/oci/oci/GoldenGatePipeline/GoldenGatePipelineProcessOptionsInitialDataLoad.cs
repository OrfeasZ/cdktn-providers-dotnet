using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGatePipeline
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGatePipeline.GoldenGatePipelineProcessOptionsInitialDataLoad")]
    public class GoldenGatePipelineProcessOptionsInitialDataLoad : oci.GoldenGatePipeline.IGoldenGatePipelineProcessOptionsInitialDataLoad
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#is_initial_load GoldenGatePipeline#is_initial_load}.</summary>
        [JsiiProperty(name: "isInitialLoad", typeJson: "{\"primitive\":\"string\"}")]
        public string IsInitialLoad
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_pipeline#action_on_existing_table GoldenGatePipeline#action_on_existing_table}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "actionOnExistingTable", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ActionOnExistingTable
        {
            get;
            set;
        }
    }
}
