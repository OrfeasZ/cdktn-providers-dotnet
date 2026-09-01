using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Datalab
{
    [JsiiInterface(nativeType: typeof(IDatalabWorker), fullyQualifiedName: "scaleway.datalab.DatalabWorker")]
    public interface IDatalabWorker
    {
        /// <summary>The number of worker nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/datalab#node_count Datalab#node_count}
        /// </remarks>
        [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
        double NodeCount
        {
            get;
        }

        /// <summary>The node type for worker nodes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/datalab#node_type Datalab#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatalabWorker), fullyQualifiedName: "scaleway.datalab.DatalabWorker")]
        internal sealed class _Proxy : DeputyBase, scaleway.Datalab.IDatalabWorker
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of worker nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/datalab#node_count Datalab#node_count}
            /// </remarks>
            [JsiiProperty(name: "nodeCount", typeJson: "{\"primitive\":\"number\"}")]
            public double NodeCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>The node type for worker nodes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.82.0/docs/resources/datalab#node_type Datalab#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
