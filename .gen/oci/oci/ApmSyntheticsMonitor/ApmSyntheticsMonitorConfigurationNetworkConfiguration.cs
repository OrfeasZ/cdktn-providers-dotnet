using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration")]
    public class ApmSyntheticsMonitorConfigurationNetworkConfiguration : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#number_of_hops ApmSyntheticsMonitor#number_of_hops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfHops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfHops
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_mode ApmSyntheticsMonitor#probe_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProbeMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_per_hop ApmSyntheticsMonitor#probe_per_hop}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "probePerHop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProbePerHop
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#protocol ApmSyntheticsMonitor#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#transmission_rate ApmSyntheticsMonitor#transmission_rate}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "transmissionRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TransmissionRate
        {
            get;
            set;
        }
    }
}
