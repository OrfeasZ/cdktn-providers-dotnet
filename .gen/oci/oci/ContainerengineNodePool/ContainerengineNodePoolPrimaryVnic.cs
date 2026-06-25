using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.ContainerengineNodePool
{
    [JsiiByValue(fqn: "oci.containerengineNodePool.ContainerengineNodePoolPrimaryVnic")]
    public class ContainerengineNodePoolPrimaryVnic : oci.ContainerengineNodePool.IContainerengineNodePoolPrimaryVnic
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.20.0/docs/resources/containerengine_node_pool#security_attributes ContainerengineNodePool#security_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SecurityAttributes
        {
            get;
            set;
        }
    }
}
