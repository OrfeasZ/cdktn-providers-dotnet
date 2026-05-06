using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsApps
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assertionConsumerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssertionConsumerUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptAssertion", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable EncryptAssertion
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "encryptionCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EncryptionCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "federationProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FederationProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "groupAssertionAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributesList GroupAssertionAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppGroupAssertionAttributesList>()!;
        }

        [JsiiProperty(name: "hokAcsUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HokAcsUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hokRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable HokRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "includeSigningCertInSignature", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IncludeSigningCertInSignature
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "keyEncryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyEncryptionAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastNotificationSentTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastNotificationSentTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutBinding", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutBinding
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable LogoutEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "logoutRequestUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutRequestUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logoutResponseUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogoutResponseUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "metadata", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Metadata
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameIdFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdFormat
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "nameIdUserstoreAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NameIdUserstoreAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "outboundAssertionAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutboundAssertionAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutboundAssertionAttributesList OutboundAssertionAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppOutboundAssertionAttributesList>()!;
        }

        [JsiiProperty(name: "partnerProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "partnerProviderPattern", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PartnerProviderPattern
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signatureHashAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignatureHashAlgorithm
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signingCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SigningCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "signResponseOrAssertion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignResponseOrAssertion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "succinctId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccinctId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantProviderId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantProviderId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userAssertionAttributes", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributesList\"}")]
        public virtual oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributesList UserAssertionAttributes
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderAppUserAssertionAttributesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsApps.DataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsApps.IDataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsApps.IDataOciIdentityDomainsAppsAppsUrnietfparamsscimschemasoracleidcsextensionsamlServiceProviderApp?>();
            set => SetInstanceProperty(value);
        }
    }
}
