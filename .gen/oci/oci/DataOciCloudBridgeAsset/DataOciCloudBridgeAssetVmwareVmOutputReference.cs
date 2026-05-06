using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCloudBridgeAsset
{
    [JsiiClass(nativeType: typeof(oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmOutputReference), fullyQualifiedName: "oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCloudBridgeAssetVmwareVmOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCloudBridgeAssetVmwareVmOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCloudBridgeAssetVmwareVmOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCloudBridgeAssetVmwareVmOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cluster", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Cluster
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerFields", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] CustomerFields
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "customerTags", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmCustomerTagsList\"}")]
        public virtual oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmCustomerTagsList CustomerTags
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVmCustomerTagsList>()!;
        }

        [JsiiProperty(name: "faultToleranceBandwidth", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FaultToleranceBandwidth
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "faultToleranceSecondaryLatency", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double FaultToleranceSecondaryLatency
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "faultToleranceState", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FaultToleranceState
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "instanceUuid", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceUuid
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "isDisksCbtEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisksCbtEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isDisksUuidEnabled", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsDisksUuidEnabled
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Path
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vmwareToolsStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VmwareToolsStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCloudBridgeAsset.DataOciCloudBridgeAssetVmwareVm\"}", isOptional: true)]
        public virtual oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetVmwareVm? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCloudBridgeAsset.IDataOciCloudBridgeAssetVmwareVm?>();
            set => SetInstanceProperty(value);
        }
    }
}
