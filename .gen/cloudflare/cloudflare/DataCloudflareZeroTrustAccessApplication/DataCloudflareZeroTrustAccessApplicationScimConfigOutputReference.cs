using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplication
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationScimConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authentication", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigAuthenticationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigAuthenticationOutputReference Authentication
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigAuthenticationOutputReference>()!;
        }

        [JsiiProperty(name: "deactivateOnDelete", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeactivateOnDelete
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idpUid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpUid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mappings", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigMappingsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigMappingsList Mappings
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfigMappingsList>()!;
        }

        [JsiiProperty(name: "remoteUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RemoteUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplication.DataCloudflareZeroTrustAccessApplicationScimConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationScimConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplication.IDataCloudflareZeroTrustAccessApplicationScimConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
