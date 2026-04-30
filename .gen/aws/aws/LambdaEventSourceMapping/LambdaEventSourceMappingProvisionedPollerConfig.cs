using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaEventSourceMapping
{
    [JsiiByValue(fqn: "aws.lambdaEventSourceMapping.LambdaEventSourceMappingProvisionedPollerConfig")]
    public class LambdaEventSourceMappingProvisionedPollerConfig : aws.LambdaEventSourceMapping.ILambdaEventSourceMappingProvisionedPollerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#maximum_pollers LambdaEventSourceMapping#maximum_pollers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaximumPollers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#minimum_pollers LambdaEventSourceMapping#minimum_pollers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimumPollers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinimumPollers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.43.0/docs/resources/lambda_event_source_mapping#poller_group_name LambdaEventSourceMapping#poller_group_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pollerGroupName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PollerGroupName
        {
            get;
            set;
        }
    }
}
