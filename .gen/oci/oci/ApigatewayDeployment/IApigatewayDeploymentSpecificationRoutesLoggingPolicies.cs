using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesLoggingPolicies), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPolicies")]
    public interface IApigatewayDeploymentSpecificationRoutesLoggingPolicies
    {
        /// <summary>access_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#access_log ApigatewayDeployment#access_log}
        /// </remarks>
        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog? AccessLog
        {
            get
            {
                return null;
            }
        }

        /// <summary>execution_log block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#execution_log ApigatewayDeployment#execution_log}
        /// </remarks>
        [JsiiProperty(name: "executionLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog? ExecutionLog
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesLoggingPolicies), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPolicies")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPolicies
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>access_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#access_log ApigatewayDeployment#access_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog? AccessLog
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesAccessLog?>();
            }

            /// <summary>execution_log block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#execution_log ApigatewayDeployment#execution_log}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "executionLog", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog? ExecutionLog
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog?>();
            }
        }
    }
}
