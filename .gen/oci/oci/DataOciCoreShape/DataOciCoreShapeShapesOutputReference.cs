using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreShape
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreShape.DataOciCoreShapeShapesOutputReference), fullyQualifiedName: "oci.dataOciCoreShape.DataOciCoreShapeShapesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreShapeShapesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreShapeShapesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreShapeShapesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreShapeShapesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "baselineOcpuUtilizations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] BaselineOcpuUtilizations
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "billingType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BillingType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpuDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpuDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "gpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Gpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "isBilledForStoppedInstance", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsBilledForStoppedInstance
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isFlexible", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsFlexible
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isLiveMigrationSupported", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsLiveMigrationSupported
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSubcore", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSubcore
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "localDiskDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LocalDiskDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "localDisks", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalDisks
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "localDisksTotalSizeInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LocalDisksTotalSizeInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxVnicAttachmentOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesMaxVnicAttachmentOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesMaxVnicAttachmentOptionsList MaxVnicAttachmentOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesMaxVnicAttachmentOptionsList>()!;
        }

        [JsiiProperty(name: "maxVnicAttachments", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxVnicAttachments
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MemoryInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "memoryOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesMemoryOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesMemoryOptionsList MemoryOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesMemoryOptionsList>()!;
        }

        [JsiiProperty(name: "minTotalBaselineOcpusRequired", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinTotalBaselineOcpusRequired
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkingBandwidthInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkingBandwidthInGbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "networkingBandwidthOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesNetworkingBandwidthOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesNetworkingBandwidthOptionsList NetworkingBandwidthOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesNetworkingBandwidthOptionsList>()!;
        }

        [JsiiProperty(name: "networkPorts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkPorts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesOcpuOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesOcpuOptionsList OcpuOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesOcpuOptionsList>()!;
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "platformConfigOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsList PlatformConfigOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesPlatformConfigOptionsList>()!;
        }

        [JsiiProperty(name: "processorDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "quotaNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] QuotaNames
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "rdmaBandwidthInGbps", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RdmaBandwidthInGbps
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "rdmaPorts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RdmaPorts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "recommendedAlternatives", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapesRecommendedAlternativesList\"}")]
        public virtual oci.DataOciCoreShape.DataOciCoreShapeShapesRecommendedAlternativesList RecommendedAlternatives
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.DataOciCoreShapeShapesRecommendedAlternativesList>()!;
        }

        [JsiiProperty(name: "resizeCompatibleShapes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResizeCompatibleShapes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreShape.DataOciCoreShapeShapes\"}", isOptional: true)]
        public virtual oci.DataOciCoreShape.IDataOciCoreShapeShapes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreShape.IDataOciCoreShapeShapes?>();
            set => SetInstanceProperty(value);
        }
    }
}
