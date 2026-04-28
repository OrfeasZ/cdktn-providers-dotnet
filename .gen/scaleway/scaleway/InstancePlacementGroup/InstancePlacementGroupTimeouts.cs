using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstancePlacementGroup
{
    [JsiiByValue(fqn: "scaleway.instancePlacementGroup.InstancePlacementGroupTimeouts")]
    public class InstancePlacementGroupTimeouts : scaleway.InstancePlacementGroup.IInstancePlacementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.74.0/docs/resources/instance_placement_group#default InstancePlacementGroup#default}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Default
        {
            get;
            set;
        }
    }
}
