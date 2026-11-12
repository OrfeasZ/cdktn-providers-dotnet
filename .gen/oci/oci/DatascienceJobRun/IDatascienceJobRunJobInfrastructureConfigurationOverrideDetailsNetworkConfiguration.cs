using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration")]
    public interface IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#network_type DatascienceJobRun#network_type}.</summary>
        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        string NetworkType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#subnet_id DatascienceJobRun#subnet_id}.</summary>
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#network_type DatascienceJobRun#network_type}.</summary>
            [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
            public string NetworkType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.13.0/docs/resources/datascience_job_run#subnet_id DatascienceJobRun#subnet_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
