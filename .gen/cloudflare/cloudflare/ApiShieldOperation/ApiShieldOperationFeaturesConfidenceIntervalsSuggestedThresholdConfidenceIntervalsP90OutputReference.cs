using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.ApiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference), fullyQualifiedName: "cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "lower", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Lower
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "upper", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Upper
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.apiShieldOperation.ApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90\"}", isOptional: true)]
        public virtual cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ApiShieldOperation.IApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90?>();
            set => SetInstanceProperty(value);
        }
    }
}
