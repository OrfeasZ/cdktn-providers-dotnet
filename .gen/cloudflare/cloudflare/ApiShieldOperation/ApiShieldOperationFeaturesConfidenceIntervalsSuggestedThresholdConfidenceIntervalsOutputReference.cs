using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "p90", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference P90
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference>()!;
        }

        [JsiiProperty(name: "p95", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference P95
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference>()!;
        }

        [JsiiProperty(name: "p99", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference\"}")]
        public virtual cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference P99
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals?>();
            set => SetInstanceProperty(value);
        }
    }
}
