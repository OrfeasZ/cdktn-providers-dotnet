using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration")]
    public class DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration : oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#gpus DatascienceJob#gpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Gpus
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#memory_in_gbs DatascienceJob#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#ocpus DatascienceJob#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
