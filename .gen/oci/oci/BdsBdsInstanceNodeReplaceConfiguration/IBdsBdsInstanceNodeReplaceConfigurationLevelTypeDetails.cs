using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceNodeReplaceConfiguration
{
    [JsiiInterface(nativeType: typeof(IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails), fullyQualifiedName: "oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails")]
    public interface IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#level_type BdsBdsInstanceNodeReplaceConfiguration#level_type}.</summary>
        [JsiiProperty(name: "levelType", typeJson: "{\"primitive\":\"string\"}")]
        string LevelType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_host_name BdsBdsInstanceNodeReplaceConfiguration#node_host_name}.</summary>
        [JsiiProperty(name: "nodeHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeHostName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_type BdsBdsInstanceNodeReplaceConfiguration#node_type}.</summary>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails), fullyQualifiedName: "oci.bdsBdsInstanceNodeReplaceConfiguration.BdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails")]
        internal sealed class _Proxy : DeputyBase, oci.BdsBdsInstanceNodeReplaceConfiguration.IBdsBdsInstanceNodeReplaceConfigurationLevelTypeDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#level_type BdsBdsInstanceNodeReplaceConfiguration#level_type}.</summary>
            [JsiiProperty(name: "levelType", typeJson: "{\"primitive\":\"string\"}")]
            public string LevelType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_host_name BdsBdsInstanceNodeReplaceConfiguration#node_host_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeHostName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeHostName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_node_replace_configuration#node_type BdsBdsInstanceNodeReplaceConfiguration#node_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
