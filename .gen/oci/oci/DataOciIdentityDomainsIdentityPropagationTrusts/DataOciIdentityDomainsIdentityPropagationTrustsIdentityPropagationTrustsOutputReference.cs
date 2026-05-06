using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityPropagationTrusts
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "active", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Active
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "allowImpersonation", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable AllowImpersonation
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "attributes", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Attributes
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "attributeSets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AttributeSets
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "authorization", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Authorization
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientClaimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "clientClaimValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ClientClaimValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "clockSkewSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ClockSkewSeconds
        {
            get => GetInstanceProperty<double>()!;
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

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "domainOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "impersonationServiceUsers", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsImpersonationServiceUsersList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsImpersonationServiceUsersList ImpersonationServiceUsers
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsImpersonationServiceUsersList>()!;
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "keytab", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsKeytabList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsKeytabList Keytab
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsKeytabList>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsMetaList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "oauthClients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OauthClients
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicCertificate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicCertificate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicKeyEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicKeyEndpoint
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

        [JsiiProperty(name: "subjectClaimName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectClaimName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectMappingAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectMappingAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subjectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrustsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityPropagationTrusts.DataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrusts\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentityPropagationTrusts.IDataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrusts? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityPropagationTrusts.IDataOciIdentityDomainsIdentityPropagationTrustsIdentityPropagationTrusts?>();
            set => SetInstanceProperty(value);
        }
    }
}
