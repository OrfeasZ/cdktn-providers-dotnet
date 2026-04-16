using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstanceSnapshot
{
    [JsiiByValue(fqn: "scaleway.instanceSnapshot.InstanceSnapshotTimeouts")]
    public class InstanceSnapshotTimeouts : scaleway.InstanceSnapshot.IInstanceSnapshotTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_snapshot#create InstanceSnapshot#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_snapshot#default InstanceSnapshot#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_snapshot#delete InstanceSnapshot#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
