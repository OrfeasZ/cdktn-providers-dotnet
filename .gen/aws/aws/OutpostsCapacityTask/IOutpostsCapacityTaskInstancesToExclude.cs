using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OutpostsCapacityTask
{
    [JsiiInterface(nativeType: typeof(IOutpostsCapacityTaskInstancesToExclude), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancesToExclude")]
    public interface IOutpostsCapacityTaskInstancesToExclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/outposts_capacity_task#instances OutpostsCapacityTask#instances}.</summary>
        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Instances
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOutpostsCapacityTaskInstancesToExclude), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancesToExclude")]
        internal sealed class _Proxy : DeputyBase, aws.OutpostsCapacityTask.IOutpostsCapacityTaskInstancesToExclude
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/outposts_capacity_task#instances OutpostsCapacityTask#instances}.</summary>
            [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Instances
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
