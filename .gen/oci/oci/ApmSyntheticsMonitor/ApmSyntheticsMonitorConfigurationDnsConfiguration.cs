using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApmSyntheticsMonitor
{
    [JsiiByValue(fqn: "oci.apmSyntheticsMonitor.ApmSyntheticsMonitorConfigurationDnsConfiguration")]
    public class ApmSyntheticsMonitorConfigurationDnsConfiguration : oci.ApmSyntheticsMonitor.IApmSyntheticsMonitorConfigurationDnsConfiguration
    {
        private object? _isOverrideDns;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#is_override_dns ApmSyntheticsMonitor#is_override_dns}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isOverrideDns", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsOverrideDns
        {
            get => _isOverrideDns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isOverrideDns = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apm_synthetics_monitor#override_dns_ip ApmSyntheticsMonitor#override_dns_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "overrideDnsIp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? OverrideDnsIp
        {
            get;
            set;
        }
    }
}
