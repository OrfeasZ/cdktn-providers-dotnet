using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdamicrovmsMicrovm
{
    [JsiiInterface(nativeType: typeof(ILambdamicrovmsMicrovmLoggingCloudwatch), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch")]
    public interface ILambdamicrovmsMicrovmLoggingCloudwatch
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_group LambdamicrovmsMicrovm#log_group}.</summary>
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_stream LambdamicrovmsMicrovm#log_stream}.</summary>
        [JsiiProperty(name: "logStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LogStream
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdamicrovmsMicrovmLoggingCloudwatch), fullyQualifiedName: "aws.lambdamicrovmsMicrovm.LambdamicrovmsMicrovmLoggingCloudwatch")]
        internal sealed class _Proxy : DeputyBase, aws.LambdamicrovmsMicrovm.ILambdamicrovmsMicrovmLoggingCloudwatch
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_group LambdamicrovmsMicrovm#log_group}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.63.0/docs/resources/lambdamicrovms_microvm#log_stream LambdamicrovmsMicrovm#log_stream}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "logStream", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LogStream
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
