using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApiManagementApiDiagnostic
{
    [JsiiInterface(nativeType: typeof(IApiManagementApiDiagnosticConfig), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticConfig")]
    public interface IApiManagementApiDiagnosticConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>The ID (name) of the Diagnostics Logger.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_management_logger_id ApiManagementApiDiagnostic#api_management_logger_id}
        /// </remarks>
        [JsiiProperty(name: "apiManagementLoggerId", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementLoggerId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_management_name ApiManagementApiDiagnostic#api_management_name}.</summary>
        [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiManagementName
        {
            get;
        }

        /// <summary>The name of the API on which to configure the Diagnostics Logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_name ApiManagementApiDiagnostic#api_name}
        /// </remarks>
        [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
        string ApiName
        {
            get;
        }

        /// <summary>Identifier of the Diagnostics Logs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#identifier ApiManagementApiDiagnostic#identifier}
        /// </remarks>
        [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
        string Identifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#resource_group_name ApiManagementApiDiagnostic#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#always_log_errors ApiManagementApiDiagnostic#always_log_errors}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "alwaysLogErrors", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AlwaysLogErrors
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#backend_request ApiManagementApiDiagnostic#backend_request}
        /// </remarks>
        [JsiiProperty(name: "backendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequest? BackendRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>backend_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#backend_response ApiManagementApiDiagnostic#backend_response}
        /// </remarks>
        [JsiiProperty(name: "backendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponse? BackendResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#frontend_request ApiManagementApiDiagnostic#frontend_request}
        /// </remarks>
        [JsiiProperty(name: "frontendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequest? FrontendRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>frontend_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#frontend_response ApiManagementApiDiagnostic#frontend_response}
        /// </remarks>
        [JsiiProperty(name: "frontendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponse? FrontendResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>The HTTP Correlation Protocol to use.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#http_correlation_protocol ApiManagementApiDiagnostic#http_correlation_protocol}
        /// </remarks>
        [JsiiProperty(name: "httpCorrelationProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpCorrelationProtocol
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#id ApiManagementApiDiagnostic#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Log client IP address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#log_client_ip ApiManagementApiDiagnostic#log_client_ip}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "logClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LogClientIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether custom metrics emitted via the `emit-metric` policy are sent to Application Insights.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#metrics_enabled ApiManagementApiDiagnostic#metrics_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "metricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MetricsEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The format of the Operation Name for Application Insights telemetries.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#operation_name_format ApiManagementApiDiagnostic#operation_name_format}
        /// </remarks>
        [JsiiProperty(name: "operationNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OperationNameFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Sampling (%). For high traffic APIs, please read this [documentation](https://learn.microsoft.com/azure/api-management/api-management-howto-app-insights#performance-implications-and-log-sampling) to understand performance implications and log sampling.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#sampling_percentage ApiManagementApiDiagnostic#sampling_percentage}
        /// </remarks>
        [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SamplingPercentage
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#timeouts ApiManagementApiDiagnostic#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Logging verbosity.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#verbosity ApiManagementApiDiagnostic#verbosity}
        /// </remarks>
        [JsiiProperty(name: "verbosity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Verbosity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApiManagementApiDiagnosticConfig), fullyQualifiedName: "azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID (name) of the Diagnostics Logger.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_management_logger_id ApiManagementApiDiagnostic#api_management_logger_id}
            /// </remarks>
            [JsiiProperty(name: "apiManagementLoggerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementLoggerId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_management_name ApiManagementApiDiagnostic#api_management_name}.</summary>
            [JsiiProperty(name: "apiManagementName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiManagementName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the API on which to configure the Diagnostics Logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#api_name ApiManagementApiDiagnostic#api_name}
            /// </remarks>
            [JsiiProperty(name: "apiName", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Identifier of the Diagnostics Logs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#identifier ApiManagementApiDiagnostic#identifier}
            /// </remarks>
            [JsiiProperty(name: "identifier", typeJson: "{\"primitive\":\"string\"}")]
            public string Identifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#resource_group_name ApiManagementApiDiagnostic#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Always log errors. Send telemetry if there is an erroneous condition, regardless of sampling settings.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#always_log_errors ApiManagementApiDiagnostic#always_log_errors}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alwaysLogErrors", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? AlwaysLogErrors
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>backend_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#backend_request ApiManagementApiDiagnostic#backend_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendRequest\"}", isOptional: true)]
            public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequest? BackendRequest
            {
                get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendRequest?>();
            }

            /// <summary>backend_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#backend_response ApiManagementApiDiagnostic#backend_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticBackendResponse\"}", isOptional: true)]
            public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponse? BackendResponse
            {
                get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticBackendResponse?>();
            }

            /// <summary>frontend_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#frontend_request ApiManagementApiDiagnostic#frontend_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendRequest", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendRequest\"}", isOptional: true)]
            public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequest? FrontendRequest
            {
                get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendRequest?>();
            }

            /// <summary>frontend_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#frontend_response ApiManagementApiDiagnostic#frontend_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frontendResponse", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticFrontendResponse\"}", isOptional: true)]
            public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponse? FrontendResponse
            {
                get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticFrontendResponse?>();
            }

            /// <summary>The HTTP Correlation Protocol to use.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#http_correlation_protocol ApiManagementApiDiagnostic#http_correlation_protocol}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpCorrelationProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpCorrelationProtocol
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#id ApiManagementApiDiagnostic#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Log client IP address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#log_client_ip ApiManagementApiDiagnostic#log_client_ip}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? LogClientIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Whether custom metrics emitted via the `emit-metric` policy are sent to Application Insights.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#metrics_enabled ApiManagementApiDiagnostic#metrics_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? MetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The format of the Operation Name for Application Insights telemetries.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#operation_name_format ApiManagementApiDiagnostic#operation_name_format}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operationNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OperationNameFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Sampling (%). For high traffic APIs, please read this [documentation](https://learn.microsoft.com/azure/api-management/api-management-howto-app-insights#performance-implications-and-log-sampling) to understand performance implications and log sampling.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#sampling_percentage ApiManagementApiDiagnostic#sampling_percentage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "samplingPercentage", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SamplingPercentage
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#timeouts ApiManagementApiDiagnostic#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.apiManagementApiDiagnostic.ApiManagementApiDiagnosticTimeouts\"}", isOptional: true)]
            public azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.ApiManagementApiDiagnostic.IApiManagementApiDiagnosticTimeouts?>();
            }

            /// <summary>Logging verbosity.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/5.15.0/docs/resources/api_management_api_diagnostic#verbosity ApiManagementApiDiagnostic#verbosity}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verbosity", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Verbosity
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either <see cref="Io.Cdktn.ISSHProvisionerConnection" /> or <see cref="Io.Cdktn.IWinrmProvisionerConnection" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: either double or <see cref="Io.Cdktn.TerraformCount" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// <para>Type union: (either <see cref="Io.Cdktn.IFileProvisioner" /> or <see cref="Io.Cdktn.ILocalExecProvisioner" /> or <see cref="Io.Cdktn.IRemoteExecProvisioner" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
