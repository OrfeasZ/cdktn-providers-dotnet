using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZeroTrustAccessIdentityProvider
{
    [JsiiClass(nativeType: typeof(cloudflare.ZeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference), fullyQualifiedName: "cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ZeroTrustAccessIdentityProviderSamlCertificateSetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentCertificate", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSetCurrentCertificateOutputReference\"}")]
        public virtual cloudflare.ZeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSetCurrentCertificateOutputReference CurrentCertificate
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSetCurrentCertificateOutputReference>()!;
        }

        [JsiiProperty(name: "previousCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreviousCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.zeroTrustAccessIdentityProvider.ZeroTrustAccessIdentityProviderSamlCertificateSet\"}", isOptional: true)]
        public virtual cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderSamlCertificateSet? InternalValue
        {
            get => GetInstanceProperty<cloudflare.ZeroTrustAccessIdentityProvider.IZeroTrustAccessIdentityProviderSamlCertificateSet?>();
            set => SetInstanceProperty(value);
        }
    }
}
