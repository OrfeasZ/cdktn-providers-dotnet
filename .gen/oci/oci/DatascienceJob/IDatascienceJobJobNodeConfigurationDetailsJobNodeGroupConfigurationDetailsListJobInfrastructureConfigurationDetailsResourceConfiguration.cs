using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public interface IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_limit_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
            }

            /// <summary>resource_request_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
            }
        }
    }
}
