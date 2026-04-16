using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareApiShieldOperations
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "confidenceIntervals", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference ConfidenceIntervals
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThresholdConfidenceIntervalsOutputReference>()!;
        }

        [JsiiProperty(name: "mean", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Mean
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareApiShieldOperations.DataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThreshold\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThreshold? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareApiShieldOperations.IDataCloudflareApiShieldOperationsResultFeaturesConfidenceIntervalsSuggestedThreshold?>();
            set => SetInstanceProperty(value);
        }
    }
}
