using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciIdentityDomainsIdentityProofingProviders
{
    [JsiiClass(nativeType: typeof(oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference), fullyQualifiedName: "oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersOutputReference(DeputyProps props): base(props)
        {
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

        [JsiiProperty(name: "claimMapping", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersClaimMappingList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersClaimMappingList ClaimMapping
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersClaimMappingList>()!;
        }

        [JsiiProperty(name: "compartmentOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "configuration", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersConfigurationList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersConfigurationList Configuration
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersConfigurationList>()!;
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

        [JsiiProperty(name: "idcsCreatedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsCreatedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsCreatedByList IdcsCreatedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsCreatedByList>()!;
        }

        [JsiiProperty(name: "idcsEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsEndpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLastModifiedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLastModifiedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLastModifiedByList IdcsLastModifiedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLastModifiedByList>()!;
        }

        [JsiiProperty(name: "idcsLastUpgradedInRelease", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLastUpgradedInRelease
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLockedBy", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLockedByList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLockedByList IdcsLockedBy
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersIdcsLockedByList>()!;
        }

        [JsiiProperty(name: "idcsLockedOn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdcsLockedOn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "idcsLockedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsLockedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "idcsPreventedOperations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IdcsPreventedOperations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "identityProofingProviderProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityProofingProviderProvider
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "meta", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersMetaList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersMetaList Meta
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersMetaList>()!;
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

        [JsiiProperty(name: "resourceTypeSchemaVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceTypeSchemaVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "runtimeData", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersRuntimeDataList\"}")]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersRuntimeDataList RuntimeData
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProvidersRuntimeDataList>()!;
        }

        [JsiiProperty(name: "schemas", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Schemas
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenancyOcid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenancyOcid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciIdentityDomainsIdentityProofingProviders.DataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProviders\"}", isOptional: true)]
        public virtual oci.DataOciIdentityDomainsIdentityProofingProviders.IDataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProviders? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciIdentityDomainsIdentityProofingProviders.IDataOciIdentityDomainsIdentityProofingProvidersIdentityProofingProviders?>();
            set => SetInstanceProperty(value);
        }
    }
}
