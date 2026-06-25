using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsMappedAttributes
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsMappedAttributesMappedAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attributeMappings", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesAttributeMappingsList\"}")]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesAttributeMappingsList AttributeMappings
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesAttributeMappingsList>()!;
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

        [JsiiProperty(name: "deleteInProgress", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable DeleteInProgress
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Direction
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesIdcsLastModifiedByList>()!;
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

        [JsiiProperty(name: "idcsResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsResourceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "mappedAttributeId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MappedAttributeId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesMetaList>()!;
        }

        [JsiiProperty(name: "ocid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Ocid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refResourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "refResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RefResourceType
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

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesTagsList\"}")]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesTagsList Tags
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributesTagsList>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsMappedAttributes.DataOciIdentityDomainsMappedAttributesMappedAttributes\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsMappedAttributes.IDataOciIdentityDomainsMappedAttributesMappedAttributes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsMappedAttributes.IDataOciIdentityDomainsMappedAttributesMappedAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
