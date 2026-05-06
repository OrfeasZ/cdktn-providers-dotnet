using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatasciencePipelineRun
{
    [JsiiByValue(fqn: "oci.datasciencePipelineRun.DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails")]
    public class DatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails : oci.DatasciencePipelineRun.IDatasciencePipelineRunInfrastructureConfigurationOverrideDetailsShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#cpu_baseline DatasciencePipelineRun#cpu_baseline}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpuBaseline", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CpuBaseline
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#memory_in_gbs DatasciencePipelineRun#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#memory_in_gbs_parameterized DatasciencePipelineRun#memory_in_gbs_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbsParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MemoryInGbsParameterized
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#ocpus DatasciencePipelineRun#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_pipeline_run#ocpus_parameterized DatasciencePipelineRun#ocpus_parameterized}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpusParameterized", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OcpusParameterized
        {
            get;
            set;
        }
    }
}
