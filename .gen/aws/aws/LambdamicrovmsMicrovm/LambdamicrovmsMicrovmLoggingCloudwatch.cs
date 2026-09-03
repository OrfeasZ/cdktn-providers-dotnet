using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiByValue(fqn: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch")]
    public class LambdamicrovmsMicrovmLoggingCloudwatch : aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_group LambdamicrovmsMicrovm#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_stream LambdamicrovmsMicrovm#log_stream}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogStream
        {
            get;
            set;
        }
    }
}
