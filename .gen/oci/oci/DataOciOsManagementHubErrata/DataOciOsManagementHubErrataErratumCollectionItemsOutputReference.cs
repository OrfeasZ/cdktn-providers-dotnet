using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciOsManagementHubErrata
{
    [JsiiClass(nativeType: typeof(oci.DataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItemsOutputReference), fullyQualifiedName: "oci.dataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciOsManagementHubErrataErratumCollectionItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciOsManagementHubErrataErratumCollectionItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciOsManagementHubErrataErratumCollectionItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciOsManagementHubErrataErratumCollectionItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "advisorySeverity", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvisorySeverity
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "advisoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdvisoryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "classificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClassificationType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "from", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string From
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osFamilies", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] OsFamilies
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "packages", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItemsPackagesList\"}")]
        public virtual oci.DataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItemsPackagesList Packages
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItemsPackagesList>()!;
        }

        [JsiiProperty(name: "references", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string References
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedCves", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RelatedCves
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "repositories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Repositories
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "solution", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Solution
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "synopsis", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Synopsis
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeIssued", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeIssued
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciOsManagementHubErrata.DataOciOsManagementHubErrataErratumCollectionItems\"}", isOptional: true)]
        public virtual oci.DataOciOsManagementHubErrata.IDataOciOsManagementHubErrataErratumCollectionItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciOsManagementHubErrata.IDataOciOsManagementHubErrataErratumCollectionItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
