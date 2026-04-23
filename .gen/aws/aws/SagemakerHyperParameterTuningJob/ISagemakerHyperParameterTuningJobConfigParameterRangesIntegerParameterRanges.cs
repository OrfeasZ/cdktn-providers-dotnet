using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerHyperParameterTuningJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges")]
    public interface ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_value SagemakerHyperParameterTuningJob#max_value}.</summary>
        [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}")]
        string MaxValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_value SagemakerHyperParameterTuningJob#min_value}.</summary>
        [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}")]
        string MinValue
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#name SagemakerHyperParameterTuningJob#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#scaling_type SagemakerHyperParameterTuningJob#scaling_type}.</summary>
        [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScalingType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges), fullyQualifiedName: "aws.sagemakerHyperParameterTuningJob.SagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerHyperParameterTuningJob.ISagemakerHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#max_value SagemakerHyperParameterTuningJob#max_value}.</summary>
            [JsiiProperty(name: "maxValue", typeJson: "{\"primitive\":\"string\"}")]
            public string MaxValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#min_value SagemakerHyperParameterTuningJob#min_value}.</summary>
            [JsiiProperty(name: "minValue", typeJson: "{\"primitive\":\"string\"}")]
            public string MinValue
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#name SagemakerHyperParameterTuningJob#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_hyper_parameter_tuning_job#scaling_type SagemakerHyperParameterTuningJob#scaling_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scalingType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScalingType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
