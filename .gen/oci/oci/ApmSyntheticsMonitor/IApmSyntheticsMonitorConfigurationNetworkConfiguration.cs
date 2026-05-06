using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiInterface(nativeType: typeof(IApmSyntheticsMonitorConfigurationNetworkConfiguration), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration")]
    public interface IApmSyntheticsMonitorConfigurationNetworkConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#number_of_hops ApmSyntheticsMonitor#number_of_hops}.</summary>
        [JsiiProperty(name: "numberOfHops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfHops
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_mode ApmSyntheticsMonitor#probe_mode}.</summary>
        [JsiiProperty(name: "probeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProbeMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_per_hop ApmSyntheticsMonitor#probe_per_hop}.</summary>
        [JsiiProperty(name: "probePerHop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ProbePerHop
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#protocol ApmSyntheticsMonitor#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Protocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#transmission_rate ApmSyntheticsMonitor#transmission_rate}.</summary>
        [JsiiProperty(name: "transmissionRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TransmissionRate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApmSyntheticsMonitorConfigurationNetworkConfiguration), fullyQualifiedName: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationNetworkConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationNetworkConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#number_of_hops ApmSyntheticsMonitor#number_of_hops}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfHops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfHops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_mode ApmSyntheticsMonitor#probe_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "probeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProbeMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#probe_per_hop ApmSyntheticsMonitor#probe_per_hop}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "probePerHop", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ProbePerHop
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#protocol ApmSyntheticsMonitor#protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Protocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#transmission_rate ApmSyntheticsMonitor#transmission_rate}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "transmissionRate", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TransmissionRate
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
