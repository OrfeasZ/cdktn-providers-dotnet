using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudwatchEventBus
{
    [JsiiInterface(nativeType: typeof(ICloudwatchEventBusLogConfig), fullyQualifiedName: "aws.cloudwatchEventBus.CloudwatchEventBusLogConfig")]
    public interface ICloudwatchEventBusLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_bus#include_detail CloudwatchEventBus#include_detail}.</summary>
        [JsiiProperty(name: "includeDetail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IncludeDetail
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_bus#level CloudwatchEventBus#level}.</summary>
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Level
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudwatchEventBusLogConfig), fullyQualifiedName: "aws.cloudwatchEventBus.CloudwatchEventBusLogConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CloudwatchEventBus.ICloudwatchEventBusLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_bus#include_detail CloudwatchEventBus#include_detail}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeDetail", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IncludeDetail
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/cloudwatch_event_bus#level CloudwatchEventBus#level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Level
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
