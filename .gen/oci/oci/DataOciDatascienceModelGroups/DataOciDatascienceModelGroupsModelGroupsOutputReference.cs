using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatascienceModelGroups
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsOutputReference), fullyQualifiedName: "oci.dataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatascienceModelGroupsModelGroupsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatascienceModelGroupsModelGroupsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatascienceModelGroupsModelGroupsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatascienceModelGroupsModelGroupsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compartmentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompartmentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "createType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definedTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap DefinedTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "freeformTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap FreeformTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lifecycleDetails", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LifecycleDetails
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memberModelEntries", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsMemberModelEntriesList\"}")]
        public virtual oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsMemberModelEntriesList MemberModelEntries
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsMemberModelEntriesList>()!;
        }

        [JsiiProperty(name: "modelGroupCloneSourceDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupCloneSourceDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupCloneSourceDetailsList ModelGroupCloneSourceDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupCloneSourceDetailsList>()!;
        }

        [JsiiProperty(name: "modelGroupDetails", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupDetailsList\"}")]
        public virtual oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupDetailsList ModelGroupDetails
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroupsModelGroupDetailsList>()!;
        }

        [JsiiProperty(name: "modelGroupVersionHistoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelGroupVersionHistoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "modelGroupVersionHistoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelGroupVersionHistoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "projectId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProjectId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "sourceModelGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceModelGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "state", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string State
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "systemTags", typeJson: "{\"fqn\":\"cdktn.StringMap\"}")]
        public virtual Io.Cdktn.StringMap SystemTags
        {
            get => GetInstanceProperty<Io.Cdktn.StringMap>()!;
        }

        [JsiiProperty(name: "timeCreated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeCreated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeUpdated", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeUpdated
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "versionLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VersionLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatascienceModelGroups.DataOciDatascienceModelGroupsModelGroups\"}", isOptional: true)]
        public virtual oci.DataOciDatascienceModelGroups.IDataOciDatascienceModelGroupsModelGroups? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatascienceModelGroups.IDataOciDatascienceModelGroupsModelGroups?>();
            set => SetInstanceProperty(value);
        }
    }
}
