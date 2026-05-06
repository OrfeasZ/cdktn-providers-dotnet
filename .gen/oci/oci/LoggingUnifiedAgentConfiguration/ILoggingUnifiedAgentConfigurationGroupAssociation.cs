using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiInterface(nativeType: typeof(ILoggingUnifiedAgentConfigurationGroupAssociation), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationGroupAssociation")]
    public interface ILoggingUnifiedAgentConfigurationGroupAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#group_list LoggingUnifiedAgentConfiguration#group_list}.</summary>
        [JsiiProperty(name: "groupList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? GroupList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILoggingUnifiedAgentConfigurationGroupAssociation), fullyQualifiedName: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationGroupAssociation")]
        internal sealed class _Proxy : DeputyBase, oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationGroupAssociation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#group_list LoggingUnifiedAgentConfiguration#group_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? GroupList
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
