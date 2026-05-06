using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerenginePodShapes
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesOutputReference), fullyQualifiedName: "oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerenginePodShapesPodShapesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerenginePodShapesPodShapesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerenginePodShapesPodShapesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerenginePodShapesPodShapesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "memoryOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptionsList\"}")]
        public virtual oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptionsList MemoryOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptionsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkBandwidthOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesNetworkBandwidthOptionsList\"}")]
        public virtual oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesNetworkBandwidthOptionsList NetworkBandwidthOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesNetworkBandwidthOptionsList>()!;
        }

        [JsiiProperty(name: "ocpuOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesOcpuOptionsList\"}")]
        public virtual oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesOcpuOptionsList OcpuOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesOcpuOptionsList>()!;
        }

        [JsiiProperty(name: "processorDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapes\"}", isOptional: true)]
        public virtual oci.DataOciContainerenginePodShapes.IDataOciContainerenginePodShapesPodShapes? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerenginePodShapes.IDataOciContainerenginePodShapesPodShapes?>();
            set => SetInstanceProperty(value);
        }
    }
}
