using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OutpostsCapacityTask
{
    [JsiiInterface(nativeType: typeof(IOutpostsCapacityTaskInstancePool), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancePool")]
    public interface IOutpostsCapacityTaskInstancePool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#count OutpostsCapacityTask#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instance_type OutpostsCapacityTask#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        string InstanceType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOutpostsCapacityTaskInstancePool), fullyQualifiedName: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancePool")]
        internal sealed class _Proxy : DeputyBase, aws.OutpostsCapacityTask.IOutpostsCapacityTaskInstancePool
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#count OutpostsCapacityTask#count}.</summary>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/outposts_capacity_task#instance_type OutpostsCapacityTask#instance_type}.</summary>
            [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
            public string InstanceType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
