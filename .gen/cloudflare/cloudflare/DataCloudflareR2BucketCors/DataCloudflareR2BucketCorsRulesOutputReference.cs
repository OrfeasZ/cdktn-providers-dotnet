using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2BucketCors
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareR2BucketCorsRulesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareR2BucketCorsRulesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataCloudflareR2BucketCorsRulesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2BucketCorsRulesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowed", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowedOutputReference\"}")]
        public virtual cloudflare.DataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowedOutputReference Allowed
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowedOutputReference>()!;
        }

        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ExposeHeaders
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAgeSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRules\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2BucketCors.IDataCloudflareR2BucketCorsRules? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketCors.IDataCloudflareR2BucketCorsRules?>();
            set => SetInstanceProperty(value);
        }
    }
}
