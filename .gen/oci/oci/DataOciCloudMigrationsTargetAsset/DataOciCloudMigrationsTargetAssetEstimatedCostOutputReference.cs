using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudMigrationsTargetAsset
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference), fullyQualifiedName: "oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudMigrationsTargetAssetEstimatedCostOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "compute", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostComputeList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostComputeList Compute
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostComputeList>()!;
        }

        [JsiiProperty(name: "currencyCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CurrencyCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "osImage", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostOsImageList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostOsImageList OsImage
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostOsImageList>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostStorageList\"}")]
        public virtual oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostStorageList Storage
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCostStorageList>()!;
        }

        [JsiiProperty(name: "subscriptionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubscriptionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "totalEstimationPerMonth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalEstimationPerMonth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "totalEstimationPerMonthBySubscription", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TotalEstimationPerMonthBySubscription
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudMigrationsTargetAsset.DataOciCloudMigrationsTargetAssetEstimatedCost\"}", isOptional: true)]
        public virtual oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetEstimatedCost? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudMigrationsTargetAsset.IDataOciCloudMigrationsTargetAssetEstimatedCost?>();
            set => SetInstanceProperty(value);
        }
    }
}
