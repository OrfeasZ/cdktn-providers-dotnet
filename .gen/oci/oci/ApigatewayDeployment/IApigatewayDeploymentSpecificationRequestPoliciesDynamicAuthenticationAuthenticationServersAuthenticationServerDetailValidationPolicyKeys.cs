using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys")]
    public interface IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#format ApigatewayDeployment#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        string Format
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#alg ApigatewayDeployment#alg}.</summary>
        [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Alg
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#e ApigatewayDeployment#e}.</summary>
        [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? E
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key ApigatewayDeployment#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Key
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key_ops ApigatewayDeployment#key_ops}.</summary>
        [JsiiProperty(name: "keyOps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? KeyOps
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kid ApigatewayDeployment#kid}.</summary>
        [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kid
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kty ApigatewayDeployment#kty}.</summary>
        [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kty
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#n ApigatewayDeployment#n}.</summary>
        [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? N
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#use ApigatewayDeployment#use}.</summary>
        [JsiiProperty(name: "use", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Use
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesDynamicAuthenticationAuthenticationServersAuthenticationServerDetailValidationPolicyKeys
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#format ApigatewayDeployment#format}.</summary>
            [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
            public string Format
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#alg ApigatewayDeployment#alg}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Alg
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#e ApigatewayDeployment#e}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? E
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key ApigatewayDeployment#key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Key
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key_ops ApigatewayDeployment#key_ops}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyOps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? KeyOps
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kid ApigatewayDeployment#kid}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kty ApigatewayDeployment#kty}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Kty
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#n ApigatewayDeployment#n}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? N
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#use ApigatewayDeployment#use}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "use", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Use
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
