using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Datalab
{
    [JsiiInterface(nativeType: typeof(IDatalabMain), fullyQualifiedName: "scaleway.datalab.DatalabMain")]
    public interface IDatalabMain
    {
        /// <summary>The node type for the main node.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.80.0/docs/resources/datalab#node_type Datalab#node_type}
        /// </remarks>
        [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
        string NodeType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatalabMain), fullyQualifiedName: "scaleway.datalab.DatalabMain")]
        internal sealed class _Proxy : DeputyBase, scaleway.Datalab.IDatalabMain
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The node type for the main node.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.80.0/docs/resources/datalab#node_type Datalab#node_type}
            /// </remarks>
            [JsiiProperty(name: "nodeType", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
