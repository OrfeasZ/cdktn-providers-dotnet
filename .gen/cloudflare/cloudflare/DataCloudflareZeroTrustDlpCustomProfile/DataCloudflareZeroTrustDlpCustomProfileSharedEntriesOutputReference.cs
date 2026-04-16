using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustDlpCustomProfile
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustDlpCustomProfileSharedEntriesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "caseSensitive", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaseSensitive
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "confidence", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesConfidenceOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesConfidenceOutputReference Confidence
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesConfidenceOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesPatternOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesPatternOutputReference Pattern
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesPatternOutputReference>()!;
        }

        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Secret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "variant", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesVariantOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesVariantOutputReference Variant
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntriesVariantOutputReference>()!;
        }

        [JsiiProperty(name: "wordList", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WordList
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustDlpCustomProfile.DataCloudflareZeroTrustDlpCustomProfileSharedEntries\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustDlpCustomProfile.IDataCloudflareZeroTrustDlpCustomProfileSharedEntries? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustDlpCustomProfile.IDataCloudflareZeroTrustDlpCustomProfileSharedEntries?>();
            set => SetInstanceProperty(value);
        }
    }
}
