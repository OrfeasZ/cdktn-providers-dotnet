using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudMigrationsTargetAssets
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference), fullyQualifiedName: "oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostComputeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "gpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gpuPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GpuPerHour
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "gpuPerHourBySubscription", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double GpuPerHourBySubscription
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryAmountGb", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryAmountGb
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryGbPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryGbPerHour
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryGbPerHourBySubscription", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryGbPerHourBySubscription
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuCount
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuPerHour
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuPerHourBySubscription", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double OcpuPerHourBySubscription
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalPerHour", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalPerHour
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalPerHourBySubscription", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalPerHourBySubscription
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAssets.DataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostCompute\"}", isOptional: true)]
        public virtual oci.DataOciCloudMigrationsTargetAssets.IDataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostCompute? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAssets.IDataOciCloudMigrationsTargetAssetsTargetAssetCollectionItemsEstimatedCostCompute?>();
            set => SetInstanceProperty(value);
        }
    }
}
