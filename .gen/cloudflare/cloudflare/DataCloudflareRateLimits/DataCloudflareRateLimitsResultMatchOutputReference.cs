using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareRateLimits
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareRateLimitsResultMatchOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareRateLimitsResultMatchOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareRateLimitsResultMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareRateLimitsResultMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchHeadersList\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchHeadersList Headers
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchHeadersList>()!;
        }

        [JsiiProperty(name: "request", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchRequestOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchRequestOutputReference Request
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchRequestOutputReference>()!;
        }

        [JsiiProperty(name: "response", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchResponseOutputReference\"}")]
        public virtual cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchResponseOutputReference Response
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.DataCloudflareRateLimitsResultMatchResponseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareRateLimits.DataCloudflareRateLimitsResultMatch\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareRateLimits.IDataCloudflareRateLimitsResultMatch? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareRateLimits.IDataCloudflareRateLimitsResultMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
