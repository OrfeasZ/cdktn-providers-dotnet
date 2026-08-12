using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_model_deployment#memory_in_gbs DatascienceModelDeployment#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_model_deployment#ocpus DatascienceModelDeployment#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        double Ocpus
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceLimitConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_model_deployment#memory_in_gbs DatascienceModelDeployment#memory_in_gbs}.</summary>
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_model_deployment#ocpus DatascienceModelDeployment#ocpus}.</summary>
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
            public double Ocpus
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
