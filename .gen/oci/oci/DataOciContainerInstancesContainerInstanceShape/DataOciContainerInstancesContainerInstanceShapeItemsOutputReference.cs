using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciContainerInstancesContainerInstanceShape
{
    [JsiiClass(nativeType: typeof(oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsOutputReference), fullyQualifiedName: "oci.dataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciContainerInstancesContainerInstanceShapeItemsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciContainerInstancesContainerInstanceShapeItemsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataOciContainerInstancesContainerInstanceShapeItemsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciContainerInstancesContainerInstanceShapeItemsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "memoryOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsMemoryOptionsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsMemoryOptionsList MemoryOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsMemoryOptionsList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "networkingBandwidthOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsNetworkingBandwidthOptionsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsNetworkingBandwidthOptionsList NetworkingBandwidthOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsNetworkingBandwidthOptionsList>()!;
        }

        [JsiiProperty(name: "ocpuOptions", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsOcpuOptionsList\"}")]
        public virtual oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsOcpuOptionsList OcpuOptions
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItemsOcpuOptionsList>()!;
        }

        [JsiiProperty(name: "processorDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ProcessorDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciContainerInstancesContainerInstanceShape.DataOciContainerInstancesContainerInstanceShapeItems\"}", isOptional: true)]
        public virtual oci.DataOciContainerInstancesContainerInstanceShape.IDataOciContainerInstancesContainerInstanceShapeItems? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciContainerInstancesContainerInstanceShape.IDataOciContainerInstancesContainerInstanceShapeItems?>();
            set => SetInstanceProperty(value);
        }
    }
}
