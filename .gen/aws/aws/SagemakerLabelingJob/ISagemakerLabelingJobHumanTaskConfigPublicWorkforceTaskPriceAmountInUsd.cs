using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerLabelingJob
{
    [JsiiInterface(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd")]
    public interface ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#cents SagemakerLabelingJob#cents}.</summary>
        [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Cents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#dollars SagemakerLabelingJob#dollars}.</summary>
        [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Dollars
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#tenth_fractions_of_a_cent SagemakerLabelingJob#tenth_fractions_of_a_cent}.</summary>
        [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TenthFractionsOfACent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd), fullyQualifiedName: "aws.sagemakerLabelingJob.SagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerLabelingJob.ISagemakerLabelingJobHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#cents SagemakerLabelingJob#cents}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cents", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Cents
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#dollars SagemakerLabelingJob#dollars}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dollars", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Dollars
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.42.0/docs/resources/sagemaker_labeling_job#tenth_fractions_of_a_cent SagemakerLabelingJob#tenth_fractions_of_a_cent}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tenthFractionsOfACent", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TenthFractionsOfACent
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
