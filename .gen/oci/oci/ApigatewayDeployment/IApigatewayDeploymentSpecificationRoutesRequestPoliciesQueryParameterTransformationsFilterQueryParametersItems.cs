using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems")]
    public interface IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#name ApigatewayDeployment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesQueryParameterTransformationsFilterQueryParametersItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#name ApigatewayDeployment#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
