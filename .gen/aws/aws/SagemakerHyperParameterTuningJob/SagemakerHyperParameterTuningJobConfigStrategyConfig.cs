using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiByValue(fqn: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig")]
    public class SagemakerHyperParameterTuningJobConfigStrategyConfig : aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfig
    {
        private object? _hyperbandStrategyConfig;

        /// <summary>hyperband_strategy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hyperband_strategy_config SagemakerHyperParameterTuningJob#hyperband_strategy_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "hyperbandStrategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? HyperbandStrategyConfig
        {
            get => _hyperbandStrategyConfig;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _hyperbandStrategyConfig = value;
            }
        }
    }
}
