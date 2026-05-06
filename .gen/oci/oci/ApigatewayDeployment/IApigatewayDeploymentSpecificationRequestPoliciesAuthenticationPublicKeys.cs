using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys")]
    public interface IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
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
        [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeysKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeys
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
            [JsiiProperty(name: "keys", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationPublicKeysKeys\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
