using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatascienceJobRun
{
    [JsiiByValue(fqn: "oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration")]
    public class DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration : oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfiguration
    {
        /// <summary>resource_limit_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#resource_limit_configuration DatascienceJobRun#resource_limit_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceLimitConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration\"}", isOptional: true)]
        public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceLimitConfiguration? ResourceLimitConfiguration
        {
            get;
            set;
        }

        /// <summary>resource_request_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/datascience_job_run#resource_request_configuration DatascienceJobRun#resource_request_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRequestConfiguration", typeJson: "{\"fqn\":\"oci.datascienceJobRun.DatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration\"}", isOptional: true)]
        public oci.DatascienceJobRun.IDatascienceJobRunJobNodeConfigurationOverrideDetailsJobNodeGroupConfigurationDetailsListJobInfrastructureConfigurationDetailsResourceConfigurationResourceRequestConfiguration? ResourceRequestConfiguration
        {
            get;
            set;
        }
    }
}
