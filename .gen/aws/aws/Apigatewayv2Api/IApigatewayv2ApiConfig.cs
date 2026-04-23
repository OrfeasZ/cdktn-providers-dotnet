using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Api
{
    [JsiiInterface(nativeType: typeof(IApigatewayv2ApiConfig), fullyQualifiedName: "aws.apigatewayv2Api.Apigatewayv2ApiConfig")]
    public interface IApigatewayv2ApiConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#name Apigatewayv2Api#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#protocol_type Apigatewayv2Api#protocol_type}.</summary>
        [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
        string ProtocolType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#api_key_selection_expression Apigatewayv2Api#api_key_selection_expression}.</summary>
        [JsiiProperty(name: "apiKeySelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiKeySelectionExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#body Apigatewayv2Api#body}.</summary>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>cors_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#cors_configuration Apigatewayv2Api#cors_configuration}
        /// </remarks>
        [JsiiProperty(name: "corsConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2Api.Apigatewayv2ApiCorsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Apigatewayv2Api.IApigatewayv2ApiCorsConfiguration? CorsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#credentials_arn Apigatewayv2Api#credentials_arn}.</summary>
        [JsiiProperty(name: "credentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CredentialsArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#description Apigatewayv2Api#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#disable_execute_api_endpoint Apigatewayv2Api#disable_execute_api_endpoint}.</summary>
        [JsiiProperty(name: "disableExecuteApiEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DisableExecuteApiEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#fail_on_warnings Apigatewayv2Api#fail_on_warnings}.</summary>
        [JsiiProperty(name: "failOnWarnings", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FailOnWarnings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#id Apigatewayv2Api#id}.</summary>
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#ip_address_type Apigatewayv2Api#ip_address_type}.</summary>
        [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddressType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#region Apigatewayv2Api#region}
        /// </remarks>
        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Region
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#route_key Apigatewayv2Api#route_key}.</summary>
        [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#route_selection_expression Apigatewayv2Api#route_selection_expression}.</summary>
        [JsiiProperty(name: "routeSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RouteSelectionExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#tags Apigatewayv2Api#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#tags_all Apigatewayv2Api#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#target Apigatewayv2Api#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Target
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#version Apigatewayv2Api#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApigatewayv2ApiConfig), fullyQualifiedName: "aws.apigatewayv2Api.Apigatewayv2ApiConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Apigatewayv2Api.IApigatewayv2ApiConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#name Apigatewayv2Api#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#protocol_type Apigatewayv2Api#protocol_type}.</summary>
            [JsiiProperty(name: "protocolType", typeJson: "{\"primitive\":\"string\"}")]
            public string ProtocolType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#api_key_selection_expression Apigatewayv2Api#api_key_selection_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "apiKeySelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiKeySelectionExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#body Apigatewayv2Api#body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Body
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>cors_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#cors_configuration Apigatewayv2Api#cors_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "corsConfiguration", typeJson: "{\"fqn\":\"aws.apigatewayv2Api.Apigatewayv2ApiCorsConfiguration\"}", isOptional: true)]
            public aws.Apigatewayv2Api.IApigatewayv2ApiCorsConfiguration? CorsConfiguration
            {
                get => GetInstanceProperty<aws.Apigatewayv2Api.IApigatewayv2ApiCorsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#credentials_arn Apigatewayv2Api#credentials_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentialsArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CredentialsArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#description Apigatewayv2Api#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#disable_execute_api_endpoint Apigatewayv2Api#disable_execute_api_endpoint}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "disableExecuteApiEndpoint", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? DisableExecuteApiEndpoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#fail_on_warnings Apigatewayv2Api#fail_on_warnings}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "failOnWarnings", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? FailOnWarnings
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#id Apigatewayv2Api#id}.</summary>
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

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#ip_address_type Apigatewayv2Api#ip_address_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddressType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddressType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#region Apigatewayv2Api#region}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Region
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#route_key Apigatewayv2Api#route_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#route_selection_expression Apigatewayv2Api#route_selection_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "routeSelectionExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RouteSelectionExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#tags Apigatewayv2Api#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#tags_all Apigatewayv2Api#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#target Apigatewayv2Api#target}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Target
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/apigatewayv2_api#version Apigatewayv2Api#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
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
