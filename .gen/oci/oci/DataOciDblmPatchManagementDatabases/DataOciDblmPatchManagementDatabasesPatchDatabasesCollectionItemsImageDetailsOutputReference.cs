using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDblmPatchManagementDatabases
{
    [JsiiClass(nativeType: typeof(oci.DataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference), fullyQualifiedName: "oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "createdBy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedBy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "currentVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrentVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "imageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subscribedImage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscribedImage
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeImageCreation", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeImageCreation
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "upToDateImageVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpToDateImageVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDblmPatchManagementDatabases.DataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetails\"}", isOptional: true)]
        public virtual oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetails? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDblmPatchManagementDatabases.IDataOciDblmPatchManagementDatabasesPatchDatabasesCollectionItemsImageDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
