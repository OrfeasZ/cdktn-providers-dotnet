using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDatabaseManagementCloudExadataStorageServerIormPlan
{
    [JsiiClass(nativeType: typeof(oci.DataOciDatabaseManagementCloudExadataStorageServerIormPlan.DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference), fullyQualifiedName: "oci.dataOciDatabaseManagementCloudExadataStorageServerIormPlan.DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "allocation", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Allocation
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "asmCluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AsmCluster
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flashCacheLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlashCacheLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flashCacheMin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlashCacheMin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "flashCacheSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FlashCacheSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isFlashCacheOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFlashCacheOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFlashLogOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFlashLogOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPmemCacheOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPmemCacheOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isPmemLogOn", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsPmemLogOn
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Level
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pmemCacheLimit", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmemCacheLimit
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pmemCacheMin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmemCacheMin
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pmemCacheSize", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PmemCacheSize
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Role
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "share", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Share
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciDatabaseManagementCloudExadataStorageServerIormPlan.DataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItems\"}", isOptional: true)]
        public virtual oci.DataOciDatabaseManagementCloudExadataStorageServerIormPlan.IDataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciDatabaseManagementCloudExadataStorageServerIormPlan.IDataOciDatabaseManagementCloudExadataStorageServerIormPlanDbPlanItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
