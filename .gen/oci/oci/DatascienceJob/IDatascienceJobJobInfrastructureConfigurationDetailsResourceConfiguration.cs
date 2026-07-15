using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public interface IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
        /// </remarks>
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>resource_limit_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration?>();
            }

            /// <summary>resource_request_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration?>();
            }
        }
    }
}
