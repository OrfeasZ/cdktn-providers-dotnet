using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceComputeTarget
{
    [JsiiByValue(fqn: "oci.datascienceComputeTarget.DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails")]
    public class DatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails : oci.DatascienceComputeTarget.IDatascienceComputeTargetComputeConfigurationDetailsInstanceConfigurationInstanceShapeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#memory_in_gbs DatascienceComputeTarget#memory_in_gbs}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_compute_target#ocpus DatascienceComputeTarget#ocpus}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Ocpus
        {
            get;
            set;
        }
    }
}
