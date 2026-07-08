using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    [JsiiByValue(fqn: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime")]
    public class IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime : oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AllowlistedHttpIps
        {
            get;
            set;
        }

        private object? _allowlistedHttpVcns;

        /// <summary>allowlisted_http_vcns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.22.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeAllowlistedHttpVcns" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowlistedHttpVcns
        {
            get => _allowlistedHttpVcns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeAllowlistedHttpVcns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTimeAllowlistedHttpVcns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowlistedHttpVcns = value;
            }
        }
    }
}
