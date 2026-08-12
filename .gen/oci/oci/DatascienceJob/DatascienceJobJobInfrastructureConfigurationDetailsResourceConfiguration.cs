using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJob
{
    [JsiiByValue(fqn: "oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public class DatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration : oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_limit_configuration DatascienceJob#resource_limit_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get;
            set;
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.27.0/docs/resources/datascience_job#resource_request_configuration DatascienceJob#resource_request_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJob.DatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public oci.DatascienceJob.IDatascienceJobJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get;
            set;
        }
    }
}
