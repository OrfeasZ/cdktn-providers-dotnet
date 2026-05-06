using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstance
{
    [JsiiByValue(fqn: "oci.bdsBdsInstance.BdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs")]
    public class BdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs : oci.BdsBdsInstance.IBdsBdsInstanceStartClusterShapeConfigsNodeTypeShapeConfigs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#node_type BdsBdsInstance#node_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? NodeType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance#shape BdsBdsInstance#shape}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shape", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Shape
        {
            get;
            set;
        }
    }
}
