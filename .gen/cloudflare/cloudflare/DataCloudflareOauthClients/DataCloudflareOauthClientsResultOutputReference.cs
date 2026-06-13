using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareOauthClients
{
    [JsiiClass(nativeType: typeof(cloudflare.DataCloudflareOauthClients.DataCloudflareOauthClientsResultOutputReference), fullyQualifiedName: "cloudflare.dataCloudflareOauthClients.DataCloudflareOauthClientsResultOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataCloudflareOauthClientsResultOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataCloudflareOauthClientsResultOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOauthClientsResultOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataCloudflareOauthClientsResultOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allowedCorsOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedCorsOrigins
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientUriVerification", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOauthClients.DataCloudflareOauthClientsResultClientUriVerificationOutputReference\"}")]
        public virtual cloudflare.DataCloudflareOauthClients.DataCloudflareOauthClientsResultClientUriVerificationOutputReference ClientUriVerification
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOauthClients.DataCloudflareOauthClientsResultClientUriVerificationOutputReference>()!;
        }

        [JsiiProperty(name: "createdAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] GrantTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "hasRotatedSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HasRotatedSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logoUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "policyUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PolicyUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "postLogoutRedirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PostLogoutRedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "promotedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PromotedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUris", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RedirectUris
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "responseTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResponseTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scopes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tokenEndpointAuthMethod", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TokenEndpointAuthMethod
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tosUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TosUri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "visibility", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Visibility
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"cloudflare.dataCloudflareOauthClients.DataCloudflareOauthClientsResult\"}", isOptional: true)]
        public virtual cloudflare.DataCloudflareOauthClients.IDataCloudflareOauthClientsResult? InternalValue
        {
            get => GetInstanceProperty<cloudflare.DataCloudflareOauthClients.IDataCloudflareOauthClientsResult?>();
            set => SetInstanceProperty(value);
        }
    }
}
