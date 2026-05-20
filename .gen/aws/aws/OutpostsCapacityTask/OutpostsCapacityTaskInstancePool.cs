using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OutpostsCapacityTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancePool")]
    public class OutpostsCapacityTaskInstancePool : aws.OutpostsCapacityTask.IOutpostsCapacityTaskInstancePool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/outposts_capacity_task#count OutpostsCapacityTask#count}.</summary>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/outposts_capacity_task#instance_type OutpostsCapacityTask#instance_type}.</summary>
        [JsiiProperty(name: "instanceType", typeJson: "{\"primitive\":\"string\"}")]
        public string InstanceType
        {
            get;
            set;
        }
    }
}
