using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OutpostsCapacityTask
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.outpostsCapacityTask.OutpostsCapacityTaskInstancesToExclude")]
    public class OutpostsCapacityTaskInstancesToExclude : aws.OutpostsCapacityTask.IOutpostsCapacityTaskInstancesToExclude
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/outposts_capacity_task#instances OutpostsCapacityTask#instances}.</summary>
        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Instances
        {
            get;
            set;
        }
    }
}
