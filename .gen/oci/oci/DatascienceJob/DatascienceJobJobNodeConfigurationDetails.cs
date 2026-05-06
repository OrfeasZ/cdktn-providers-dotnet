using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetails")]
    public class DatascienceJobJobNodeConfigurationDetails : oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_type DatascienceJob#job_node_type}.</summary>
        [JsiiProperty(name: "jobNodeType", typeJson: "{\"primitive\":\"string\"}")]
        public string JobNodeType
        {
            get;
            set;
        }

        /// <summary>job_network_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_network_configuration DatascienceJob#job_network_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobNetworkConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNetworkConfiguration? JobNetworkConfiguration
        {
            get;
            set;
        }

        private object? _jobNodeGroupConfigurationDetailsList;

        /// <summary>job_node_group_configuration_details_list block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#job_node_group_configuration_details_list DatascienceJob#job_node_group_configuration_details_list}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jobNodeGroupConfigurationDetailsList", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? JobNodeGroupConfigurationDetailsList
        {
            get => _jobNodeGroupConfigurationDetailsList;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListStruct).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _jobNodeGroupConfigurationDetailsList = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#maximum_runtime_in_minutes DatascienceJob#maximum_runtime_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumRuntimeInMinutes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaximumRuntimeInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/datascience_job#startup_order DatascienceJob#startup_order}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startupOrder", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? StartupOrder
        {
            get;
            set;
        }
    }
}
