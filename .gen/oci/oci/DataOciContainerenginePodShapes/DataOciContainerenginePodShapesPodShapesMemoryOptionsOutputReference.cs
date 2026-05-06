using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerenginePodShapes
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference), fullyQualifiedName: "oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerenginePodShapesPodShapesMemoryOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "defaultPerOcpuInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultPerOcpuInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "maxPerOcpuInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxPerOcpuInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "minPerOcpuInGbs", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinPerOcpuInGbs
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerenginePodShapes.DataOciContainerenginePodShapesPodShapesMemoryOptions\"}", isOptional: true)]
        public virtual oci.DataOciContainerenginePodShapes.IDataOciContainerenginePodShapesPodShapesMemoryOptions? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerenginePodShapes.IDataOciContainerenginePodShapesPodShapesMemoryOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
