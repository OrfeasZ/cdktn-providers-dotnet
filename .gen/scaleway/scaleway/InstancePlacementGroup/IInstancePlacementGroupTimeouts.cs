using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.InstancePlacementGroup
{
    [JsiiInterface(nativeType: typeof(IInstancePlacementGroupTimeouts), fullyQualifiedName: "scaleway.instancePlacementGroup.InstancePlacementGroupTimeouts")]
    public interface IInstancePlacementGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_placement_group#default InstancePlacementGroup#default}.</summary>
        [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Default
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInstancePlacementGroupTimeouts), fullyQualifiedName: "scaleway.instancePlacementGroup.InstancePlacementGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, scaleway.InstancePlacementGroup.IInstancePlacementGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/scaleway/scaleway/2.73.0/docs/resources/instance_placement_group#default InstancePlacementGroup#default}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "default", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Default
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
