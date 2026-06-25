using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration")]
    public interface IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_job_run#resource_limit_configuration DatascienceJobRun#resource_limit_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_job_run#resource_request_configuration DatascienceJobRun#resource_request_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_limit_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_job_run#resource_limit_configuration DatascienceJobRun#resource_limit_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceLimitConfiguration?>();
            }

            /// <summary>resource_request_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/datascience_job_run#resource_request_configuration DatascienceJobRun#resource_request_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobInfrastructureConfigurationOverrideDetailsResourceConfigurationResourceRequestConfiguration?>();
            }
        }
    }
}
