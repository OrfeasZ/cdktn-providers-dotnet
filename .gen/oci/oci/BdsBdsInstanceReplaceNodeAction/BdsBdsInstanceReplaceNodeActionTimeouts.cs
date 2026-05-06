using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.BdsBdsInstanceReplaceNodeAction
{
    [JsiiByValue(fqn: "oci.bdsBdsInstanceReplaceNodeAction.BdsBdsInstanceReplaceNodeActionTimeouts")]
    public class BdsBdsInstanceReplaceNodeActionTimeouts : oci.BdsBdsInstanceReplaceNodeAction.IBdsBdsInstanceReplaceNodeActionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/bds_bds_instance_replace_node_action#create BdsBdsInstanceReplaceNodeAction#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
