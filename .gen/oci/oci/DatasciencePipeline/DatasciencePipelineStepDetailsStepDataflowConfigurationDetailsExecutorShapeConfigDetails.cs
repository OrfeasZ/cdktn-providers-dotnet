using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipeline
{
    [JsiiByValue(fqn: "oci.datasciencePipeline.DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails")]
    public class DatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails : oci.DatasciencePipeline.IDatasciencePipelineStepDetailsStepDataflowConfigurationDetailsExecutorShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs DatasciencePipeline#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#memory_in_gbs_parameterized DatasciencePipeline#memory_in_gbs_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryInGbsParameterized
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus DatasciencePipeline#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline#ocpus_parameterized DatasciencePipeline#ocpus_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpusParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OcpusParameterized
        {
            get;
            set;
        }
    }
}
