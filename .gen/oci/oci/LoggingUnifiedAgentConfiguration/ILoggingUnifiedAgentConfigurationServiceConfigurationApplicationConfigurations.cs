using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations")]
    public interface ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations
    {
        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#destination LoggingUnifiedAgentConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination\"}")]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#source_type LoggingUnifiedAgentConfiguration#source_type}.</summary>
        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        string SourceType
        {
            get;
        }

        /// <summary>source block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#source LoggingUnifiedAgentConfiguration#source}
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>sources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#sources LoggingUnifiedAgentConfiguration#sources}
        /// </remarks>
        [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Sources
        {
            get
            {
                return null;
            }
        }

        /// <summary>unified_agent_configuration_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#unified_agent_configuration_filter LoggingUnifiedAgentConfiguration#unified_agent_configuration_filter}
        /// </remarks>
        [JsiiProperty(name: "unifiedAgentConfigurationFilter", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsUnifiedAgentConfigurationFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsUnifiedAgentConfigurationFilter? UnifiedAgentConfigurationFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#destination LoggingUnifiedAgentConfiguration#destination}
            /// </remarks>
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination\"}")]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination Destination
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsDestination>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#source_type LoggingUnifiedAgentConfiguration#source_type}.</summary>
            [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#source LoggingUnifiedAgentConfiguration#source}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource\"}", isOptional: true)]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource? Source
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSource?>();
            }

            /// <summary>sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#sources LoggingUnifiedAgentConfiguration#sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>unified_agent_configuration_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#unified_agent_configuration_filter LoggingUnifiedAgentConfiguration#unified_agent_configuration_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unifiedAgentConfigurationFilter", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsUnifiedAgentConfigurationFilter\"}", isOptional: true)]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsUnifiedAgentConfigurationFilter? UnifiedAgentConfigurationFilter
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurationsUnifiedAgentConfigurationFilter?>();
            }
        }
    }
}
