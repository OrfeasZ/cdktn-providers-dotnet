using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Datalab
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.datalab.DatalabWorker")]
    public class DatalabWorker : scaleway.Datalab.IDatalabWorker
    {
        /// <summary>The number of worker nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.79.0/docs/resources/datalab#node_count Datalab#node_count}
        /// </remarks>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        public double NodeCount
        {
            get;
            set;
        }

        /// <summary>The node type for worker nodes.</summary>
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
