using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "confidenceIntervals", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference ConfidenceIntervals
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference>()!;
        }

        [JsiiProperty(name: "mean", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Mean
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold?>();
            set => SetInstanceProperty(value);
        }
    }
}
