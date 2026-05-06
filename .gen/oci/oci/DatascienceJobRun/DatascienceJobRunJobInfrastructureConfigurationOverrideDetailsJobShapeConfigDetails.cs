using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiByValue(fqn: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails")]
    public class DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails : oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsJobShapeConfigDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#memory_in_gbs DatascienceJobRun#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job_run#ocpus DatascienceJobRun#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
