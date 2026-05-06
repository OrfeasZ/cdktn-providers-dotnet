using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.LoggingUnifiedAgentConfiguration
{
    [JsiiByValue(fqn: "oci.loggingUnifiedAgentConfiguration.LoggingUnifiedAgentConfigurationGroupAssociation")]
    public class LoggingUnifiedAgentConfigurationGroupAssociation : oci.LoggingUnifiedAgentConfiguration.ILoggingUnifiedAgentConfigurationGroupAssociation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/logging_unified_agent_configuration#group_list LoggingUnifiedAgentConfiguration#group_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? GroupList
        {
            get;
            set;
        }
    }
}
