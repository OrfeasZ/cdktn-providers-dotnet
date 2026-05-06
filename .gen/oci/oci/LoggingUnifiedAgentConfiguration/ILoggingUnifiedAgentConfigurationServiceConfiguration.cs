using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfiguration), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfiguration")]
    public interface ILoggingUnifiedAgentConfigurationServiceConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#configuration_type LoggingUnifiedAgentConfiguration#configuration_type}.</summary>
        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationType
        {
            get;
        }

        /// <summary>application_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#application_configurations LoggingUnifiedAgentConfiguration#application_configurations}
        /// </remarks>
        [JsiiProperty(name: "applicationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ApplicationConfigurations
        {
            get
            {
                return null;
            }
        }

        /// <summary>destination block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#destination LoggingUnifiedAgentConfiguration#destination}
        /// </remarks>
        [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestination\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestination? Destination
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
        [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "unifiedAgentConfigurationFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? UnifiedAgentConfigurationFilter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationServiceConfiguration), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfiguration")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#configuration_type LoggingUnifiedAgentConfiguration#configuration_type}.</summary>
            [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>application_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#application_configurations LoggingUnifiedAgentConfiguration#application_configurations}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationApplicationConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ApplicationConfigurations
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>destination block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#destination LoggingUnifiedAgentConfiguration#destination}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "destination", typeJson: "{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationDestination\"}", isOptional: true)]
            public oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestination? Destination
            {
                get => GetInstanceProperty<oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationServiceConfigurationDestination?>();
            }

            /// <summary>sources block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#sources LoggingUnifiedAgentConfiguration#sources}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationSources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Sources
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>unified_agent_configuration_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#unified_agent_configuration_filter LoggingUnifiedAgentConfiguration#unified_agent_configuration_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "unifiedAgentConfigurationFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationServiceConfigurationUnifiedAgentConfigurationFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? UnifiedAgentConfigurationFilter
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
