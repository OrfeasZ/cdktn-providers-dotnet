using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultSaasAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessTokenLifetime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTokenLifetime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "allowPkceWithoutClientSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowPkceWithoutClientSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "appLauncherUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AppLauncherUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthType
        {
            get => GetInstanceProperty<string>()!;
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

        [JsiiProperty(name: "consumerServiceUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerServiceUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customAttributes", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomAttributesList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomAttributesList CustomAttributes
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomAttributesList>()!;
        }

        [JsiiProperty(name: "customClaims", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomClaimsList\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomClaimsList CustomClaims
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppCustomClaimsList>()!;
        }

        [JsiiProperty(name: "defaultRelayState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultRelayState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "groupFilterRegex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GroupFilterRegex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hybridAndImplicitOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppHybridAndImplicitOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppHybridAndImplicitOptionsOutputReference HybridAndImplicitOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppHybridAndImplicitOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "idpEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdpEntityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameIdTransformJsonata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdTransformJsonata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "refreshTokenOptions", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppRefreshTokenOptionsOutputReference\"}")]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppRefreshTokenOptionsOutputReference RefreshTokenOptions
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasAppRefreshTokenOptionsOutputReference>()!;
        }

        [JsiiProperty(name: "samlAttributeTransformJsonata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SamlAttributeTransformJsonata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "spEntityId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SpEntityId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ssoEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SsoEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultSaasApp\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultSaasApp? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultSaasApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
