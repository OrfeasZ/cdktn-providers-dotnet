using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessIdentityProviders
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessIdentityProvidersResultConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "appsDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppsDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Attributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authorizationServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationServerId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "centrifyAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CentrifyAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "centrifyAppId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CentrifyAppId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Claims
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conditionalAccessEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ConditionalAccessEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailAttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailClaimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "headerAttributes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfigHeaderAttributesList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfigHeaderAttributesList HeaderAttributes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfigHeaderAttributesList>()!;
        }

        [JsiiProperty(name: "idpPublicCerts", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdpPublicCerts
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "issuerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oktaAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OktaAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oneloginAccount", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OneloginAccount
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pingEnvId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PingEnvId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pkceEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable PkceEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "prompt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prompt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "signRequest", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SignRequest
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "ssoTargetUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsoTargetUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportGroups", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SupportGroups
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessIdentityProviders.DataCloudflareZeroTrustAccessIdentityProvidersResultConfig\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessIdentityProviders.IDataCloudflareZeroTrustAccessIdentityProvidersResultConfig? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessIdentityProviders.IDataCloudflareZeroTrustAccessIdentityProvidersResultConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
