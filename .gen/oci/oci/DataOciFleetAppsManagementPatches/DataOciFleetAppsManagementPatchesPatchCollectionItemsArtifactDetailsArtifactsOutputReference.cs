using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciFleetAppsManagementPatches
{
    [JsiiClass(nativeType: typeof(oci.DataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference), fullyQualifiedName: "oci.dataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "architecture", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Architecture
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "content", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsContentList\"}")]
        public virtual oci.DataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsContentList Content
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifactsContentList>()!;
        }

        [JsiiProperty(name: "osType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OsType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciFleetAppsManagementPatches.DataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifacts\"}", isOptional: true)]
        public virtual oci.DataOciFleetAppsManagementPatches.IDataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifacts? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciFleetAppsManagementPatches.IDataOciFleetAppsManagementPatchesPatchCollectionItemsArtifactDetailsArtifacts?>();
            set => SetInstanceProperty(value);
        }
    }
}
