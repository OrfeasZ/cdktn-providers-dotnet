using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Inspector2Filter
{
    [JsiiInterface(nativeType: typeof(IInspector2FilterFilterCriteriaEcrImageInUseCount), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageInUseCount")]
    public interface IInspector2FilterFilterCriteriaEcrImageInUseCount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_filter#lower_inclusive Inspector2Filter#lower_inclusive}.</summary>
        [JsiiProperty(name: "lowerInclusive", typeJson: "{\"primitive\":\"number\"}")]
        double LowerInclusive
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_filter#upper_inclusive Inspector2Filter#upper_inclusive}.</summary>
        [JsiiProperty(name: "upperInclusive", typeJson: "{\"primitive\":\"number\"}")]
        double UpperInclusive
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IInspector2FilterFilterCriteriaEcrImageInUseCount), fullyQualifiedName: "aws.inspector2Filter.Inspector2FilterFilterCriteriaEcrImageInUseCount")]
        internal sealed class _Proxy : DeputyBase, aws.Inspector2Filter.IInspector2FilterFilterCriteriaEcrImageInUseCount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_filter#lower_inclusive Inspector2Filter#lower_inclusive}.</summary>
            [JsiiProperty(name: "lowerInclusive", typeJson: "{\"primitive\":\"number\"}")]
            public double LowerInclusive
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.41.0/docs/resources/inspector2_filter#upper_inclusive Inspector2Filter#upper_inclusive}.</summary>
            [JsiiProperty(name: "upperInclusive", typeJson: "{\"primitive\":\"number\"}")]
            public double UpperInclusive
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
