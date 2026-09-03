using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration")]
    public class DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration : oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#memory_in_gbs DatascienceModelDeployment#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public double MemoryInGbs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#ocpus DatascienceModelDeployment#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public double Ocpus
        {
            get;
            set;
        }
    }
}
