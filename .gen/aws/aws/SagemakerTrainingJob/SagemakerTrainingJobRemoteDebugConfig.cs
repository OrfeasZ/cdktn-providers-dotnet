using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerTrainingJob
{
    [JsiiByValue(fqn: "aws.sagemakerTrainingJob.SagemakerTrainingJobRemoteDebugConfig")]
    public class SagemakerTrainingJobRemoteDebugConfig : aws.SagemakerTrainingJob.ISagemakerTrainingJobRemoteDebugConfig
    {
        private object? _enableRemoteDebug;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_training_job#enable_remote_debug SagemakerTrainingJob#enable_remote_debug}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableRemoteDebug", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableRemoteDebug
        {
            get => _enableRemoteDebug;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enableRemoteDebug = value;
            }
        }
    }
}
