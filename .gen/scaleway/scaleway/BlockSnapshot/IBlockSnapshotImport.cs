using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.BlockSnapshot
{
    [JsiiInterface(nativeType: typeof(IBlockSnapshotImport), fullyQualifiedName: "scaleway.blockSnapshot.BlockSnapshotImport")]
    public interface IBlockSnapshotImport
    {
        /// <summary>Bucket containing qcow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/block_snapshot#bucket BlockSnapshot#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Key of the qcow file in the specified bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/block_snapshot#key BlockSnapshot#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBlockSnapshotImport), fullyQualifiedName: "scaleway.blockSnapshot.BlockSnapshotImport")]
        internal sealed class _Proxy : DeputyBase, scaleway.BlockSnapshot.IBlockSnapshotImport
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Bucket containing qcow.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/block_snapshot#bucket BlockSnapshot#bucket}
            /// </remarks>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Key of the qcow file in the specified bucket.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/block_snapshot#key BlockSnapshot#key}
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
