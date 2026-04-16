using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRateLimit
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRateLimit.DataCloudflareRateLimitActionResponseOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRateLimit.DataCloudflareRateLimitActionResponseOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRateLimitActionResponseOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRateLimitActionResponseOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRateLimitActionResponseOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRateLimitActionResponseOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Body
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "contentType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContentType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimit.DataCloudflareRateLimitActionResponse\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRateLimit.IDataCloudflareRateLimitActionResponse? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimit.IDataCloudflareRateLimitActionResponse?>();
            set => SetInstanceProperty(value);
        }
    }
}
