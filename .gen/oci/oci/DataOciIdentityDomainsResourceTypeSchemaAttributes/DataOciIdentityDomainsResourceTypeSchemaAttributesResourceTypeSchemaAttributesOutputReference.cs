using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsResourceTypeSchemaAttributes
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "canonicalValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CanonicalValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "caseExact", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable CaseExact
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
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

        [JsiiProperty(name: "endUserMutability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EndUserMutability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "endUserMutabilityAllowedValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] EndUserMutabilityAllowedValues
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsAddedSinceReleaseNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAddedSinceReleaseNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsAddedSinceVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsAddedSinceVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsAttributeCacheable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsAttributeCacheable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsAttributeMappable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsAttributeMappable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsAuditable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsAuditable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsAutoIncrementSeqName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsAutoIncrementSeqName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCanonicalValueSourceFilter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsCanonicalValueSourceFilter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCanonicalValueSourceResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsCanonicalValueSourceResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCompositeKey", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsCompositeKey
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsCsvColumnHeaderName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsCsvColumnHeaderName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsCustomAttribute", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsCustomAttribute
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsDeprecatedSinceReleaseNumber", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsDeprecatedSinceReleaseNumber
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsDeprecatedSinceVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsDeprecatedSinceVersion
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsDisplayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsDisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsDisplayNameMessageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsDisplayNameMessageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsFetchComplexAttributeValues", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsFetchComplexAttributeValues
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsFromTargetMapper", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsFromTargetMapper
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsFullyQualifiedName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsFullyQualifiedName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsGenerated", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsGenerated
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsIcfAttributeType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsIcfAttributeType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsIcfBundleAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsIcfBundleAttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsIcfRequired", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsIcfRequired
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsIndirectRefResourceAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsIndirectRefResourceAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsInternal", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsInternal
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsMaxLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsMaxLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsMaxValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsMaxValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsMinLength", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsMinLength
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsMinValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IdcsMinValue
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "idcsMultiLanguage", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsMultiLanguage
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsRefResourceAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsRefResourceAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsRefResourceAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsRefResourceAttributes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsSchemaUrn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsSchemaUrn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsScimCompliant", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsScimCompliant
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsSearchable", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsSearchable
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsSensitive", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsSensitive
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsTargetAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsTargetAttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsTargetAttributeNameToMigrateFrom", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsTargetAttributeNameToMigrateFrom
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsTargetNormAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsTargetNormAttributeName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsTargetUniqueConstraintName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsTargetUniqueConstraintName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsToTargetMapper", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsToTargetMapper
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsTrimStringValue", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsTrimStringValue
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsValidateReference", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsValidateReference
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "idcsValuePersisted", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IdcsValuePersisted
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesMetaList>()!;
        }

        [JsiiProperty(name: "multiValued", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable MultiValued
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "mutability", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mutability
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "referenceTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ReferenceTypes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable Required
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "resourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "returned", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Returned
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributesTagsList>()!;
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

        [JsiiProperty(name: "uniqueness", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uniqueness
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsResourceTypeSchemaAttributes.DataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributes\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.IDataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsResourceTypeSchemaAttributes.IDataOciIdentityDomainsResourceTypeSchemaAttributesResourceTypeSchemaAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
