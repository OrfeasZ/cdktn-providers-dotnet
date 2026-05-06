using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ApigatewayDeployment
{
    [JsiiInterface(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesBackend), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackend")]
    public interface IApigatewayDeploymentSpecificationRoutesBackend
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#type ApigatewayDeployment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#allowed_post_logout_uris ApigatewayDeployment#allowed_post_logout_uris}.</summary>
        [JsiiProperty(name: "allowedPostLogoutUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedPostLogoutUris
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#body ApigatewayDeployment#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#connect_timeout_in_seconds ApigatewayDeployment#connect_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "connectTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ConnectTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#function_id ApigatewayDeployment#function_id}.</summary>
        [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionId
        {
            get
            {
                return null;
            }
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#headers ApigatewayDeployment#headers}
        /// </remarks>
        [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Headers
        {
            get
            {
                return null;
            }
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#post_logout_state ApigatewayDeployment#post_logout_state}.</summary>
        [JsiiProperty(name: "postLogoutState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PostLogoutState
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#read_timeout_in_seconds ApigatewayDeployment#read_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "readTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReadTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>routing_backends block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#routing_backends ApigatewayDeployment#routing_backends}
        /// </remarks>
        [JsiiProperty(name: "routingBackends", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackends\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RoutingBackends
        {
            get
            {
                return null;
            }
        }

        /// <summary>selection_source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#selection_source ApigatewayDeployment#selection_source}
        /// </remarks>
        [JsiiProperty(name: "selectionSource", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendSelectionSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendSelectionSource? SelectionSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#send_timeout_in_seconds ApigatewayDeployment#send_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "sendTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SendTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#status ApigatewayDeployment#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#url ApigatewayDeployment#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayDeploymentSpecificationRoutesBackend), fullyQualifiedName: "oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackend")]
        internal sealed class _Proxy : DeputyBase, oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackend
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#allowed_post_logout_uris ApigatewayDeployment#allowed_post_logout_uris}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedPostLogoutUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedPostLogoutUris
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#body ApigatewayDeployment#body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Body
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#connect_timeout_in_seconds ApigatewayDeployment#connect_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "connectTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ConnectTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#function_id ApigatewayDeployment#function_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#headers ApigatewayDeployment#headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "headers", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendHeaders\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Headers
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#is_ssl_verify_disabled ApigatewayDeployment#is_ssl_verify_disabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isSslVerifyDisabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsSslVerifyDisabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#post_logout_state ApigatewayDeployment#post_logout_state}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "postLogoutState", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PostLogoutState
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#read_timeout_in_seconds ApigatewayDeployment#read_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReadTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>routing_backends block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#routing_backends ApigatewayDeployment#routing_backends}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "routingBackends", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendRoutingBackends\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RoutingBackends
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>selection_source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#selection_source ApigatewayDeployment#selection_source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selectionSource", typeJson: "{\"fqn\":\"oci.apigatewayDeployment.ApigatewayDeploymentSpecificationRoutesBackendSelectionSource\"}", isOptional: true)]
            public oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendSelectionSource? SelectionSource
            {
                get => GetInstanceProperty<oci.ApigatewayDeployment.IApigatewayDeploymentSpecificationRoutesBackendSelectionSource?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#send_timeout_in_seconds ApigatewayDeployment#send_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sendTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SendTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#status ApigatewayDeployment#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Status
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/apigateway_deployment#url ApigatewayDeployment#url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Url
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
