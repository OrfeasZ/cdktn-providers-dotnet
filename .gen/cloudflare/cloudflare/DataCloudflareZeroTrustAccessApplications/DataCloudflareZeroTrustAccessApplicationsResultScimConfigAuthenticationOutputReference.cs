using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareZeroTrustAccessApplications
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorizationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthorizationUrl
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

        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Password
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Token
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string User
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareZeroTrustAccessApplications.DataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthentication\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthentication? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareZeroTrustAccessApplications.IDataCloudflareZeroTrustAccessApplicationsResultScimConfigAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
