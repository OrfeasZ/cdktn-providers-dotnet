using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultCorsHeadersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowAllHeaders", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowAllHeaders
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowAllMethods", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowAllMethods
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowAllOrigins", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowAllOrigins
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowCredentials", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowCredentials
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedHeaders
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedMethods
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedOrigins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "maxAge", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxAge
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultCorsHeaders\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultCorsHeaders? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultCorsHeaders?>();
            set => SetInstanceProperty(value);
        }
    }
}
