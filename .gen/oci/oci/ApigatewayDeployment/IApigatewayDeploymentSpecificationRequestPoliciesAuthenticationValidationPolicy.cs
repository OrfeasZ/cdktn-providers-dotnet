using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy")]
    public interface IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>additional_validation_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#additional_validation_policy ApigatewayDeployment#additional_validation_policy}
        /// </remarks>
        [JsiiProperty(name: "additionalValidationPolicy", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy? AdditionalValidationPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>client_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#client_details ApigatewayDeployment#client_details}
        /// </remarks>
        [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails? ClientDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_ssl_verify_disabled ApigatewayDeployment#is_ssl_verify_disabled}.</summary>
        [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsSslVerifyDisabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>keys block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#keys ApigatewayDeployment#keys}
        /// </remarks>
        [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Keys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#max_cache_duration_in_hours ApigatewayDeployment#max_cache_duration_in_hours}.</summary>
        [JsiiProperty(name: "maxCacheDurationInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxCacheDurationInHours
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_uri_details block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#source_uri_details ApigatewayDeployment#source_uri_details}
        /// </remarks>
        [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails? SourceUriDetails
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#uri ApigatewayDeployment#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>additional_validation_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#additional_validation_policy ApigatewayDeployment#additional_validation_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalValidationPolicy", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy? AdditionalValidationPolicy
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyAdditionalValidationPolicy?>();
            }

            /// <summary>client_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#client_details ApigatewayDeployment#client_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails? ClientDetails
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyClientDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_ssl_verify_disabled ApigatewayDeployment#is_ssl_verify_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSslVerifyDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>keys block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#keys ApigatewayDeployment#keys}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Keys
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#max_cache_duration_in_hours ApigatewayDeployment#max_cache_duration_in_hours}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxCacheDurationInHours", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxCacheDurationInHours
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>source_uri_details block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#source_uri_details ApigatewayDeployment#source_uri_details}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceUriDetails", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails? SourceUriDetails
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicySourceUriDetails?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#uri ApigatewayDeployment#uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
