using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceModelDeployment
{
    [JsiiInterface(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration")]
    public interface IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#memory_in_gbs DatascienceModelDeployment#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        double MemoryInGbs
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#ocpus DatascienceModelDeployment#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        double Ocpus
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#gpus DatascienceModelDeployment#gpus}.</summary>
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Gpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration), fullyQualifiedName: "oci.datascienceModelDeployment.DatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceModelDeployment.IDatascienceModelDeploymentModelDeploymentConfigurationDetailsInfrastructureConfigurationDetailsModelDeploymentResourceConfigurationResourceRequestConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#memory_in_gbs DatascienceModelDeployment#memory_in_gbs}.</summary>
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
            public double MemoryInGbs
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#ocpus DatascienceModelDeployment#ocpus}.</summary>
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
            public double Ocpus
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_model_deployment#gpus DatascienceModelDeployment#gpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Gpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
