using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiInterface(nativeType: typeof(IDatascienceJobJobNodeConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetails")]
    public interface IDatascienceJobJobNodeConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_type DatascienceJob#job_node_type}.</summary>
        [JsiiProperty(name: "jobNodeType", typeJson: "{\"primitive\":\"string\"}")]
        string JobNodeType
        {
            get;
        }

        /// <summary>job_network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_network_configuration DatascienceJob#job_network_configuration}
        /// </remarks>
        [JsiiProperty(name: "jobNetworkConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration? JobNetworkConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>job_node_group_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_group_configuration_details_list DatascienceJob#job_node_group_configuration_details_list}
        /// </remarks>
        [JsiiProperty(name: "jobNodeGroupConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JobNodeGroupConfigurationDetailsList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaximumRuntimeInMinutes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_order DatascienceJob#startup_order}.</summary>
        [JsiiProperty(name: "startupOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StartupOrder
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatascienceJobJobNodeConfigurationDetails), fullyQualifiedName: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_type DatascienceJob#job_node_type}.</summary>
            [JsiiProperty(name: "jobNodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string JobNodeType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>job_network_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_network_configuration DatascienceJob#job_network_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobNetworkConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration\"}", isOptional: true)]
            public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration? JobNetworkConfiguration
            {
                get => GetInstanceProperty<oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration?>();
            }

            /// <summary>job_node_group_configuration_details_list block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_group_configuration_details_list DatascienceJob#job_node_group_configuration_details_list}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jobNodeGroupConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? JobNodeGroupConfigurationDetailsList
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaximumRuntimeInMinutes
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_order DatascienceJob#startup_order}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startupOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StartupOrder
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
