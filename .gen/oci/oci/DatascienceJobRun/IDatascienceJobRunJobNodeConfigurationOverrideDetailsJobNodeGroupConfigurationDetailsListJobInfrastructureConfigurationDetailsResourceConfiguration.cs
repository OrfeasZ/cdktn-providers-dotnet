using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public interface IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_limit_configuration DatascienceJobRun#resource_limit_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_request_configuration DatascienceJobRun#resource_request_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_limit_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_limit_configuration DatascienceJobRun#resource_limit_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
            }

            /// <summary>resource_request_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/9.0.0/docs/resources/datascience_job_run#resource_request_configuration DatascienceJobRun#resource_request_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
            public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
            }
        }
    }
}
