using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciCoreShapes
{
    [JsiiClass(nativeType: typeof(oci.DataOciCoreShapes.DataOciCoreShapesShapesOutputReference), fullyQualifiedName: "oci.dataOciCoreShapes.DataOciCoreShapesShapesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciCoreShapesShapesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciCoreShapesShapesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciCoreShapesShapesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciCoreShapesShapesOutputReference(DeputyProps props): base(props)
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

        [JsiiProperty(name: "maxVnicAttachmentOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesMaxVnicAttachmentOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesMaxVnicAttachmentOptionsList MaxVnicAttachmentOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesMaxVnicAttachmentOptionsList>()!;
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

        [JsiiProperty(name: "memoryOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesMemoryOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesMemoryOptionsList MemoryOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesMemoryOptionsList>()!;
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

        [JsiiProperty(name: "networkingBandwidthOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesNetworkingBandwidthOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesNetworkingBandwidthOptionsList NetworkingBandwidthOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesNetworkingBandwidthOptionsList>()!;
        }

        [JsiiProperty(name: "networkPorts", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double NetworkPorts
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "ocpuOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesOcpuOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesOcpuOptionsList OcpuOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesOcpuOptionsList>()!;
        }

        [JsiiProperty(name: "ocpus", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Ocpus
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "platformConfigOptions", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsList PlatformConfigOptions
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesPlatformConfigOptionsList>()!;
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

        [JsiiProperty(name: "recommendedAlternatives", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapesRecommendedAlternativesList\"}")]
        public virtual oci.DataOciCoreShapes.DataOciCoreShapesShapesRecommendedAlternativesList RecommendedAlternatives
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.DataOciCoreShapesShapesRecommendedAlternativesList>()!;
        }

        [JsiiProperty(name: "resizeCompatibleShapes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] ResizeCompatibleShapes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciCoreShapes.DataOciCoreShapesShapes\"}", isOptional: true)]
        public virtual oci.DataOciCoreShapes.IDataOciCoreShapesShapes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciCoreShapes.IDataOciCoreShapesShapes?>();
            set => SetInstanceProperty(value);
        }
    }
}
