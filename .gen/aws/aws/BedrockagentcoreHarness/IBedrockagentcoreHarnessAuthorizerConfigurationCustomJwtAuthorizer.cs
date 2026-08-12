using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer")]
    public interface IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#discovery_url BedrockagentcoreHarness#discovery_url}.</summary>
        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
        string DiscoveryUrl
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_audience BedrockagentcoreHarness#allowed_audience}.</summary>
        [JsiiProperty(name: "allowedAudience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedAudience
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_clients BedrockagentcoreHarness#allowed_clients}.</summary>
        [JsiiProperty(name: "allowedClients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedClients
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_scopes BedrockagentcoreHarness#allowed_scopes}.</summary>
        [JsiiProperty(name: "allowedScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedScopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowed_workload_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_workload_configuration BedrockagentcoreHarness#allowed_workload_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "allowedWorkloadConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowedWorkloadConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>custom_claim block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#custom_claim BedrockagentcoreHarness#custom_claim}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerCustomClaim" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerCustomClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_endpoint block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#private_endpoint BedrockagentcoreHarness#private_endpoint}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privateEndpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateEndpoint
        {
            get
            {
                return null;
            }
        }

        /// <summary>private_endpoint_overrides block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#private_endpoint_overrides BedrockagentcoreHarness#private_endpoint_overrides}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "privateEndpointOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PrivateEndpointOverrides
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizer
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#discovery_url BedrockagentcoreHarness#discovery_url}.</summary>
            [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string DiscoveryUrl
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_audience BedrockagentcoreHarness#allowed_audience}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedAudience", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedAudience
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_clients BedrockagentcoreHarness#allowed_clients}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedClients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedClients
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_scopes BedrockagentcoreHarness#allowed_scopes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedScopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedScopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>allowed_workload_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#allowed_workload_configuration BedrockagentcoreHarness#allowed_workload_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowedWorkloadConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllowedWorkloadConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>custom_claim block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#custom_claim BedrockagentcoreHarness#custom_claim}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerCustomClaim" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customClaim", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerCustomClaim\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomClaim
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_endpoint block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#private_endpoint BedrockagentcoreHarness#private_endpoint}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpoint\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateEndpoint
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>private_endpoint_overrides block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.59.0/docs/resources/bedrockagentcore_harness#private_endpoint_overrides BedrockagentcoreHarness#private_endpoint_overrides}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "privateEndpointOverrides", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerPrivateEndpointOverrides\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? PrivateEndpointOverrides
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
