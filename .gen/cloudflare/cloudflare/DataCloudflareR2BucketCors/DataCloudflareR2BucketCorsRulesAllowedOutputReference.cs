using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareR2BucketCors
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowedOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowedOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareR2BucketCorsRulesAllowedOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareR2BucketCorsRulesAllowedOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareR2BucketCorsRulesAllowedOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareR2BucketCorsRulesAllowedOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "headers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Headers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "methods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Methods
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "origins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Origins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareR2BucketCors.DataCloudflareR2BucketCorsRulesAllowed\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareR2BucketCors.IDataCloudflareR2BucketCorsRulesAllowed? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareR2BucketCors.IDataCloudflareR2BucketCorsRulesAllowed?>();
            set => SetInstanceProperty(value);
        }
    }
}
