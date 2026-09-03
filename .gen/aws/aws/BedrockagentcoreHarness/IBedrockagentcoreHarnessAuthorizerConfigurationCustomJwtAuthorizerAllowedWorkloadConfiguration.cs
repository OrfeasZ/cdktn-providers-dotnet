using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockagentcoreHarness
{
    [JsiiInterface(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration")]
    public interface IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
    {
        /// <summary>hosting_environment block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#hosting_environment BedrockagentcoreHarness#hosting_environment}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "hostingEnvironment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HostingEnvironment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#workload_identities BedrockagentcoreHarness#workload_identities}.</summary>
        [JsiiProperty(name: "workloadIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WorkloadIdentities
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration), fullyQualifiedName: "aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>hosting_environment block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#hosting_environment BedrockagentcoreHarness#hosting_environment}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.BedrockagentcoreHarness.IBedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostingEnvironment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockagentcoreHarness.BedrockagentcoreHarnessAuthorizerConfigurationCustomJwtAuthorizerAllowedWorkloadConfigurationHostingEnvironment\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HostingEnvironment
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/bedrockagentcore_harness#workload_identities BedrockagentcoreHarness#workload_identities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "workloadIdentities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WorkloadIdentities
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
