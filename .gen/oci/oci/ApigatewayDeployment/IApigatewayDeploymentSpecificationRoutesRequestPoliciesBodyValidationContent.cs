using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent")]
    public interface IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#media_type ApigatewayDeployment#media_type}.</summary>
        [JsiiProperty(name: "mediaType", typeJson: "{\"primitive\":\"string\"}")]
        string MediaType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#validation_type ApigatewayDeployment#validation_type}.</summary>
        [JsiiProperty(name: "validationType", typeJson: "{\"primitive\":\"string\"}")]
        string ValidationType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesBodyValidationContent
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#media_type ApigatewayDeployment#media_type}.</summary>
            [JsiiProperty(name: "mediaType", typeJson: "{\"primitive\":\"string\"}")]
            public string MediaType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#validation_type ApigatewayDeployment#validation_type}.</summary>
            [JsiiProperty(name: "validationType", typeJson: "{\"primitive\":\"string\"}")]
            public string ValidationType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
