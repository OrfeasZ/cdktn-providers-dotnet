using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerAlgorithm
{
    [JsiiByValue(fqn: "aws.sagemakerAlgorithm.SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig")]
    public class SagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig : aws.SagemakerAlgorithm.ISagemakerAlgorithmInferenceSpecificationContainersModelDataSourceS3DataSourceModelAccessConfig
    {
        private object? _acceptEula;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_algorithm#accept_eula SagemakerAlgorithm#accept_eula}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "acceptEula", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? AcceptEula
        {
            get => _acceptEula;
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
                _acceptEula = value;
            }
        }
    }
}
