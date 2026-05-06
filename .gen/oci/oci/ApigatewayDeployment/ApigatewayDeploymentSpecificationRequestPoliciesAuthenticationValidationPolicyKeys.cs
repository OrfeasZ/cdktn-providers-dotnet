using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys")]
    public class ApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys : oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPoliciesAuthenticationValidationPolicyKeys
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#format ApigatewayDeployment#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#alg ApigatewayDeployment#alg}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "alg", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Alg
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#e ApigatewayDeployment#e}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "e", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? E
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key ApigatewayDeployment#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#key_ops ApigatewayDeployment#key_ops}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyOps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? KeyOps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kid ApigatewayDeployment#kid}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#kty ApigatewayDeployment#kty}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kty", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kty
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#n ApigatewayDeployment#n}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "n", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? N
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#use ApigatewayDeployment#use}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "use", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Use
        {
            get;
            set;
        }
    }
}
