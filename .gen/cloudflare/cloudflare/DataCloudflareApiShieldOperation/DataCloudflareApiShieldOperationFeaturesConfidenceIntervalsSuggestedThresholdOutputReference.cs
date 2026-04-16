using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperation
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "confidenceIntervals", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference ConfidenceIntervals
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference>()!;
        }

        [JsiiProperty(name: "mean", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Mean
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperation.DataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperation.IDataCloudflareApiShieldOperationFeaturesConfidenceIntervalsSuggestedThreshold?>();
            set => SetInstanceProperty(value);
        }
    }
}
