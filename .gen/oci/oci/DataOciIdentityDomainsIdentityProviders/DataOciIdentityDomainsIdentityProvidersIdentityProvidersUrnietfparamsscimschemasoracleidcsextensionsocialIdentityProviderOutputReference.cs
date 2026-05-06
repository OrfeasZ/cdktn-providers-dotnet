using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityProviders
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accessTokenUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccessTokenUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "accountLinkingEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AccountLinkingEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "adminScope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AdminScope
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authzUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthzUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoRedirectEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AutoRedirectEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clientCredentialInPayload", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable ClientCredentialInPayload
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "clockSkewInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClockSkewInSeconds
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "consumerKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerKey
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "consumerSecret", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConsumerSecret
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "discoveryUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DiscoveryUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "jitProvAssignedGroups", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroupsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroupsList JitProvAssignedGroups
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProviderJitProvAssignedGroupsList>()!;
        }

        [JsiiProperty(name: "jitProvGroupStaticListEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable JitProvGroupStaticListEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "profileUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProfileUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "redirectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RedirectUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "registrationEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable RegistrationEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "scope", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Scope
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "serviceProviderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceProviderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "socialJitProvisioningEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable SocialJitProvisioningEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProviders.DataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentityProviders.IDataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProviders.IDataOciIdentityDomainsIdentityProvidersIdentityProvidersUrnietfparamsscimschemasoracleidcsextensionsocialIdentityProvider?>();
            set => SetInstanceProperty(value);
        }
    }
}
