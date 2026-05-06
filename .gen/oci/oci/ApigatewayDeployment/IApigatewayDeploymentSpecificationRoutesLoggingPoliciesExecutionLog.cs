using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog")]
    public interface IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_enabled ApigatewayDeployment#is_enabled}.</summary>
        [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#log_level ApigatewayDeployment#log_level}.</summary>
        [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogLevel
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesLoggingPoliciesExecutionLog
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_enabled ApigatewayDeployment#is_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#log_level ApigatewayDeployment#log_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogLevel
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
