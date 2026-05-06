using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayGateway.ApigatewayGatewayResponseCacheDetails")]
    public class ApigatewayGatewayResponseCacheDetails : oci.ApigatewayGateway.IApigatewayGatewayResponseCacheDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#type ApigatewayGateway#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#authentication_secret_id ApigatewayGateway#authentication_secret_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationSecretId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationSecretId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#authentication_secret_version_number ApigatewayGateway#authentication_secret_version_number}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationSecretVersionNumber", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthenticationSecretVersionNumber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#connect_timeout_in_ms ApigatewayGateway#connect_timeout_in_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectTimeoutInMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ConnectTimeoutInMs
        {
            get;
            set;
        }

        private object? _isSslEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#is_ssl_enabled ApigatewayGateway#is_ssl_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSslEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSslEnabled
        {
            get => _isSslEnabled;
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
                _isSslEnabled = value;
            }
        }

        private object? _isSslVerifyDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#is_ssl_verify_disabled ApigatewayGateway#is_ssl_verify_disabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? IsSslVerifyDisabled
        {
            get => _isSslVerifyDisabled;
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
                _isSslVerifyDisabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#read_timeout_in_ms ApigatewayGateway#read_timeout_in_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readTimeoutInMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadTimeoutInMs
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#send_timeout_in_ms ApigatewayGateway#send_timeout_in_ms}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendTimeoutInMs", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? SendTimeoutInMs
        {
            get;
            set;
        }

        private object? _servers;

        /// <summary>servers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_gateway#servers ApigatewayGateway#servers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "servers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayGateway.ApigatewayGatewayResponseCacheDetailsServers\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Servers
        {
            get => _servers;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApigatewayGateway.IApigatewayGatewayResponseCacheDetailsServers[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayGateway.IApigatewayGatewayResponseCacheDetailsServers).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _servers = value;
            }
        }
    }
}
