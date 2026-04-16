using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    [JsiiInterface(nativeType: typeof(ISyntheticsCanaryScheduleRetryConfig), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryScheduleRetryConfig")]
    public interface ISyntheticsCanaryScheduleRetryConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/synthetics_canary#max_retries SyntheticsCanary#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRetries
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISyntheticsCanaryScheduleRetryConfig), fullyQualifiedName: "aws.syntheticsCanary.SyntheticsCanaryScheduleRetryConfig")]
        internal sealed class _Proxy : DeputyBase, aws.SyntheticsCanary.ISyntheticsCanaryScheduleRetryConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/synthetics_canary#max_retries SyntheticsCanary#max_retries}.</summary>
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRetries
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
