using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventBus
{
    [JsiiByValue(fqn: "aws.cloudwatchEventBus.CloudwatchEventBusLogConfig")]
    public class CloudwatchEventBusLogConfig : aws.CloudwatchEventBus.ICloudwatchEventBusLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_event_bus#include_detail CloudwatchEventBus#include_detail}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "includeDetail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IncludeDetail
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/cloudwatch_event_bus#level CloudwatchEventBus#level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Level
        {
            get;
            set;
        }
    }
}
