using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsGrants
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsGrantsGrantsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsGrantsGrantsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsGrantsGrantsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsGrantsGrantsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "app", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppList App
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppList>()!;
        }

        [JsiiProperty(name: "appEntitlementCollection", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppEntitlementCollectionList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppEntitlementCollectionList AppEntitlementCollection
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsAppEntitlementCollectionList>()!;
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

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "compositeKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompositeKey
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

        [JsiiProperty(name: "entitlement", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsEntitlementList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsEntitlementList Entitlement
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsEntitlementList>()!;
        }

        [JsiiProperty(name: "grantedAttributeValuesJson", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantedAttributeValuesJson
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantee", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGranteeList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGranteeList Grantee
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGranteeList>()!;
        }

        [JsiiProperty(name: "grantMechanism", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GrantMechanism
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "grantor", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGrantorList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGrantorList Grantor
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsGrantorList>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "isFulfilled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFulfilled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsMetaList>()!;
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrantsTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsGrants.DataOciIdentityDomainsGrantsGrants\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsGrants.IDataOciIdentityDomainsGrantsGrants? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsGrants.IDataOciIdentityDomainsGrantsGrants?>();
            set => SetInstanceProperty(value);
        }
    }
}
