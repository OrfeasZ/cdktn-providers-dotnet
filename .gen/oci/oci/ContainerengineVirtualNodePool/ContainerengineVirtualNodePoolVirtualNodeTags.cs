using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineVirtualNodePool
{
    [JsiiByValue(fqn: "oci.containerengineVirtualNodePool.ContainerengineVirtualNodePoolVirtualNodeTags")]
    public class ContainerengineVirtualNodePoolVirtualNodeTags : oci.ContainerengineVirtualNodePool.IContainerengineVirtualNodePoolVirtualNodeTags
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#defined_tags ContainerengineVirtualNodePool#defined_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "definedTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? DefinedTags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/containerengine_virtual_node_pool#freeform_tags ContainerengineVirtualNodePool#freeform_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "freeformTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? FreeformTags
        {
            get;
            set;
        }
    }
}
