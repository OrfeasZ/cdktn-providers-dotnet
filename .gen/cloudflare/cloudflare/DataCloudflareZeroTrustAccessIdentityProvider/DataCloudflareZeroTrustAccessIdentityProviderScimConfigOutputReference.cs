using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessIdentityProvider
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessIdentityProviderScimConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Enabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "identityUpdateBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityUpdateBehavior
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scimBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ScimBaseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "seatDeprovision", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SeatDeprovision
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "secret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Secret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userDeprovision", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable UserDeprovision
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessIdentityProvider.DataCloudflareZeroTrustAccessIdentityProviderScimConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessIdentityProvider.IDataCloudflareZeroTrustAccessIdentityProviderScimConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessIdentityProvider.IDataCloudflareZeroTrustAccessIdentityProviderScimConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
