using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource")]
    public interface ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#name LoggingUnifiedAgentConfiguration#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>scrape_targets block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#scrape_targets LoggingUnifiedAgentConfiguration#scrape_targets}
        /// </remarks>
        [JsiiProperty(name: "scrapeTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSourceScrapeTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ScrapeTargets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#name LoggingUnifiedAgentConfiguration#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>scrape_targets block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#scrape_targets LoggingUnifiedAgentConfiguration#scrape_targets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scrapeTargets", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSourceScrapeTargets\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ScrapeTargets
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
