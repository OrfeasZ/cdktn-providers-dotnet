using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig")]
    public interface ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_resource SagemakerHyperParameterTuningJob#max_resource}.</summary>
        [JsiiProperty(name: "maxResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_resource SagemakerHyperParameterTuningJob#min_resource}.</summary>
        [JsiiProperty(name: "minResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinResource
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigStrategyConfigHyperbandStrategyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_resource SagemakerHyperParameterTuningJob#max_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxResource
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_resource SagemakerHyperParameterTuningJob#min_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minResource", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinResource
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
