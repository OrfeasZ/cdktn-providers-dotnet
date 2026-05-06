using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>additional_validation_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#additional_validation_policy ApigatewayDeployment#additional_validation_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalValidationPolicy", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyAdditionalValidationPolicy\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyAdditionalValidationPolicy? AdditionalValidationPolicy
        {
            get;
            set;
        }

        /// <summary>client_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#client_details ApigatewayDeployment#client_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyClientDetails\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyClientDetails? ClientDetails
        {
            get;
            set;
        }

        private object? _isSslVerifyDisabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_ssl_verify_disabled ApigatewayDeployment#is_ssl_verify_disabled}.</summary>
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

        private object? _keys;

        /// <summary>keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#keys ApigatewayDeployment#keys}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Keys
        {
            get => _keys;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _keys = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#max_cache_duration_in_hours ApigatewayDeployment#max_cache_duration_in_hours}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxCacheDurationInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxCacheDurationInHours
        {
            get;
            set;
        }

        /// <summary>source_uri_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#source_uri_details ApigatewayDeployment#source_uri_details}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicySourceUriDetails\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicySourceUriDetails? SourceUriDetails
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#uri ApigatewayDeployment#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }
    }
}
