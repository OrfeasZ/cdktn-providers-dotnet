using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration")]
    public interface IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#gpus DatascienceJobRun#gpus}.</summary>
        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Gpus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#memory_in_gbs DatascienceJobRun#memory_in_gbs}.</summary>
        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MemoryInGbs
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#ocpus DatascienceJobRun#ocpus}.</summary>
        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ocpus
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#gpus DatascienceJobRun#gpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Gpus
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#memory_in_gbs DatascienceJobRun#memory_in_gbs}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MemoryInGbs
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#ocpus DatascienceJobRun#ocpus}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ocpus
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
