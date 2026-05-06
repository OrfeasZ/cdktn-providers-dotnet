using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.apigatewayDeployment.ApigatewayDeploymentSpecification")]
    public class ApigatewayDeploymentSpecification : oci.ApigatewayDeployment.IApigatewayDeploymentSpecification
    {
        private object _routes;

        /// <summary>routes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#routes ApigatewayDeployment#routes}
        /// </remarks>
        [JsiiProperty(name: "routes", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutes\"},\"kind\":\"array\"}}]}}")]
        public object Routes
        {
            get => _routes;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutes).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _routes = value;
            }
        }

        /// <summary>logging_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#logging_policies ApigatewayDeployment#logging_policies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "loggingPolicies", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationLoggingPolicies\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationLoggingPolicies? LoggingPolicies
        {
            get;
            set;
        }

        /// <summary>request_policies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#request_policies ApigatewayDeployment#request_policies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestPolicies", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRequestPolicies\"}", isOptional: true)]
        public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRequestPolicies? RequestPolicies
        {
            get;
            set;
        }
    }
}
