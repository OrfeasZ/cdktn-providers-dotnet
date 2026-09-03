using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeCustomLogSource
{
    [JsiiInterface(nativeType: typeof(ISecuritylakeCustomLogSourceConfiguration), fullyQualifiedName: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfiguration")]
    public interface ISecuritylakeCustomLogSourceConfiguration
    {
        /// <summary>crawler_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/securitylake_custom_log_source#crawler_configuration SecuritylakeCustomLogSource#crawler_configuration}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationCrawlerConfiguration" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "crawlerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationCrawlerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CrawlerConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>provider_identity block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/securitylake_custom_log_source#provider_identity SecuritylakeCustomLogSource#provider_identity}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "providerIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ProviderIdentity
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISecuritylakeCustomLogSourceConfiguration), fullyQualifiedName: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>crawler_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/securitylake_custom_log_source#crawler_configuration SecuritylakeCustomLogSource#crawler_configuration}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationCrawlerConfiguration" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "crawlerConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationCrawlerConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CrawlerConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>provider_identity block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/securitylake_custom_log_source#provider_identity SecuritylakeCustomLogSource#provider_identity}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "providerIdentity", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ProviderIdentity
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
