using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails")]
    public class ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetails
    {
        /// <summary>password block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#password ApmSyntheticsMonitor#password}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword\"}", isOptional: true)]
        public oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationFtpBasicAuthenticationDetailsPassword? Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#username ApmSyntheticsMonitor#username}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Username
        {
            get;
            set;
        }
    }
}
