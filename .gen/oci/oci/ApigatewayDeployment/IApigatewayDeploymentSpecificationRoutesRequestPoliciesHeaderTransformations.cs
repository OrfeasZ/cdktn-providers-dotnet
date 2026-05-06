using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations")]
    public interface IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations
    {
        /// <summary>filter_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#filter_headers ApigatewayDeployment#filter_headers}
        /// </remarks>
        [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsFilterHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsFilterHeaders? FilterHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>rename_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rename_headers ApigatewayDeployment#rename_headers}
        /// </remarks>
        [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsRenameHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsRenameHeaders? RenameHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>set_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#set_headers ApigatewayDeployment#set_headers}
        /// </remarks>
        [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsSetHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsSetHeaders? SetHeaders
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>filter_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#filter_headers ApigatewayDeployment#filter_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsFilterHeaders\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsFilterHeaders? FilterHeaders
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsFilterHeaders?>();
            }

            /// <summary>rename_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#rename_headers ApigatewayDeployment#rename_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renameHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsRenameHeaders\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsRenameHeaders? RenameHeaders
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsRenameHeaders?>();
            }

            /// <summary>set_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#set_headers ApigatewayDeployment#set_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "setHeaders", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsSetHeaders\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsSetHeaders? SetHeaders
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesRequestPoliciesHeaderTransformationsSetHeaders?>();
            }
        }
    }
}
