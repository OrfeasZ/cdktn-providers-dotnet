using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsOauthPartnerCertificates
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certEndDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertEndDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateAlias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certStartDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertStartDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExternalId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "keyStoreId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStoreName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStoreName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keyStorePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyStorePassword
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "map", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Map
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesMetaList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sha1Thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha1Thumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sha256Thumbprint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sha256Thumbprint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificatesTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "x509Base64Certificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string X509Base64Certificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsOauthPartnerCertificates.DataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificates\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsOauthPartnerCertificates.IDataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificates? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsOauthPartnerCertificates.IDataOciIdentityDomainsOauthPartnerCertificatesOauthPartnerCertificates?>();
            set => SetInstanceProperty(value);
        }
    }
}
