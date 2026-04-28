using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSnapshot
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "scaleway.instanceSnapshot.InstanceSnapshotImport")]
    public class InstanceSnapshotImport : scaleway.InstanceSnapshot.IInstanceSnapshotImport
    {
        /// <summary>Bucket containing qcow.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_snapshot#bucket InstanceSnapshot#bucket}
        /// </remarks>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Key of the qcow file in the specified bucket.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_snapshot#key InstanceSnapshot#key}
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }
    }
}
