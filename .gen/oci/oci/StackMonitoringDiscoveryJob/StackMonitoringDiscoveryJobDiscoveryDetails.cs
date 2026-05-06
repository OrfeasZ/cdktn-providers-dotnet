using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetails")]
    public class StackMonitoringDiscoveryJobDiscoveryDetails : oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#agent_id StackMonitoringDiscoveryJob#agent_id}.</summary>
        [JsiiProperty(name: "agentId", typeJson: "{\"primitive\":\"string\"}")]
        public string AgentId
        {
            get;
            set;
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties StackMonitoringDiscoveryJob#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsProperties\"}")]
        public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsProperties Properties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_name StackMonitoringDiscoveryJob#resource_name}.</summary>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#resource_type StackMonitoringDiscoveryJob#resource_type}.</summary>
        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceType
        {
            get;
            set;
        }

        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#credentials StackMonitoringDiscoveryJob#credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "credentials", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentials\"}", isOptional: true)]
        public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentials? Credentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#license StackMonitoringDiscoveryJob#license}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "license", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? License
        {
            get;
            set;
        }

        /// <summary>tags block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#tags StackMonitoringDiscoveryJob#tags}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsTags\"}", isOptional: true)]
        public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsTags? Tags
        {
            get;
            set;
        }
    }
}
