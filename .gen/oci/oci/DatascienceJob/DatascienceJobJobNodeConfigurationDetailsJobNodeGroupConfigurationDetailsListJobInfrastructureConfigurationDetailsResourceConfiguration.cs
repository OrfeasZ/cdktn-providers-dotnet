using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public class DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration : oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get;
            set;
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.23.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobNodeConfigurationDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get;
            set;
        }
    }
}
