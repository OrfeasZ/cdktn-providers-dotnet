using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsCloudGateMapping
{
    [JsiiByValue(fqn: "oci.identityDomainsCloudGateMapping.IdentityDomainsCloudGateMappingUpstreamServerGroup")]
    public class IdentityDomainsCloudGateMappingUpstreamServerGroup : oci.IdentityDomainsCloudGateMapping.IIdentityDomainsCloudGateMappingUpstreamServerGroup
    {
        private object? _ssl;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#ssl IdentityDomainsCloudGateMapping#ssl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ssl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Ssl
        {
            get => _ssl;
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
                _ssl = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_cloud_gate_mapping#value IdentityDomainsCloudGateMapping#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
