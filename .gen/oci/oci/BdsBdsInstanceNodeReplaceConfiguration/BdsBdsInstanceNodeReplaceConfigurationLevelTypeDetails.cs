using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeReplaceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails")]
    public class BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails : oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#level_type BdsBdsInstanceNodeReplaceConfiguration#level_type}.</summary>
        [JsiiProperty(name: "levelType", typeJson: "{\"primitive\":\"string\"}")]
        public string LevelType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_host_name BdsBdsInstanceNodeReplaceConfiguration#node_host_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeHostName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_type BdsBdsInstanceNodeReplaceConfiguration#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }
    }
}
