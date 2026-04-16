using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "p90", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference P90
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP90OutputReference>()!;
        }

        [JsiiProperty(name: "p95", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference P95
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP95OutputReference>()!;
        }

        [JsiiProperty(name: "p99", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference P99
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsP99OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervals?>();
            set => SetInstanceProperty(value);
        }
    }
}
