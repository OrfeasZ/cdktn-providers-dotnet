using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.StackMonitoringDiscoveryJob
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItems")]
    public class StackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItems : oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#credential_name StackMonitoringDiscoveryJob#credential_name}.</summary>
        [JsiiProperty(name: "credentialName", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#credential_type StackMonitoringDiscoveryJob#credential_type}.</summary>
        [JsiiProperty(name: "credentialType", typeJson: "{\"primitive\":\"string\"}")]
        public string CredentialType
        {
            get;
            set;
        }

        /// <summary>properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/stack_monitoring_discovery_job#properties StackMonitoringDiscoveryJob#properties}
        /// </remarks>
        [JsiiProperty(name: "properties", typeJson: "{\"fqn\":\"oci.stackMonitoringDiscoveryJob.StackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItemsProperties\"}")]
        public oci.StackMonitoringDiscoveryJob.IStackMonitoringDiscoveryJobDiscoveryDetailsCredentialsItemsProperties Properties
        {
            get;
            set;
        }
    }
}
