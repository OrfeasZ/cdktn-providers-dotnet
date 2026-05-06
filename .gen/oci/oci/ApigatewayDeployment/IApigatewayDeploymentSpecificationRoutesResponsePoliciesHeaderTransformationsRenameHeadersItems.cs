using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems")]
    public interface IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#from ApigatewayDeployment#from}.</summary>
        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        string From
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#to ApigatewayDeployment#to}.</summary>
        [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
        string To
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesResponsePoliciesHeaderTransformationsRenameHeadersItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#from ApigatewayDeployment#from}.</summary>
            [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
            public string From
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#to ApigatewayDeployment#to}.</summary>
            [JsiiProperty(name: "to", typeJson: "{\"primitive\":\"string\"}")]
            public string To
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
