using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IntegrationIntegrationInstance
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetails")]
    public class IntegrationIntegrationInstanceNetworkEndpointDetails : oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#network_endpoint_type IntegrationIntegrationInstance#network_endpoint_type}.</summary>
        [JsiiProperty(name: "networkEndpointType", typeJson: "{\"primitive\":\"string\"}")]
        public string NetworkEndpointType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#allowlisted_http_ips IntegrationIntegrationInstance#allowlisted_http_ips}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#allowlisted_http_vcns IntegrationIntegrationInstance#allowlisted_http_vcns}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowlistedHttpVcns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsAllowlistedHttpVcns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowlistedHttpVcns = value;
            }
        }

        /// <summary>design_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#design_time IntegrationIntegrationInstance#design_time}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "designTime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime\"}", isOptional: true)]
        public oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsDesignTime? DesignTime
        {
            get;
            set;
        }

        private object? _isIntegrationVcnAllowlisted;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#is_integration_vcn_allowlisted IntegrationIntegrationInstance#is_integration_vcn_allowlisted}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "isIntegrationVcnAllowlisted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsIntegrationVcnAllowlisted
        {
            get => _isIntegrationVcnAllowlisted;
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
                _isIntegrationVcnAllowlisted = value;
            }
        }

        /// <summary>runtime block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/integration_integration_instance#runtime IntegrationIntegrationInstance#runtime}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "runtime", typeJson: "{\"fqn\":\"oci.integrationIntegrationInstance.IntegrationIntegrationInstanceNetworkEndpointDetailsRuntime\"}", isOptional: true)]
        public oci.IntegrationIntegrationInstance.IIntegrationIntegrationInstanceNetworkEndpointDetailsRuntime? Runtime
        {
            get;
            set;
        }
    }
}
