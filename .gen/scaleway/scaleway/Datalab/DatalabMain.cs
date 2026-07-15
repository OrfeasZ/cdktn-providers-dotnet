using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Datalab
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.datalab.DatalabMain")]
    public class DatalabMain : scaleway.Datalab.IDatalabMain
    {
        /// <summary>The node type for the main node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/datalab#node_type Datalab#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeType
        {
            get;
            set;
        }
    }
}
