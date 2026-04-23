using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigStrategyConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig")]
    public interface ISagemakerHyperParameterTuningJobConfigStrategyConfig
    {
        /// <summary>hyperband_strategy_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hyperband_strategy_config SagemakerHyperParameterTuningJob#hyperband_strategy_config}
        /// </remarks>
        [JsiiProperty(name: "hyperbandStrategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? HyperbandStrategyConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigStrategyConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>hyperband_strategy_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#hyperband_strategy_config SagemakerHyperParameterTuningJob#hyperband_strategy_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hyperbandStrategyConfig", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? HyperbandStrategyConfig
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
