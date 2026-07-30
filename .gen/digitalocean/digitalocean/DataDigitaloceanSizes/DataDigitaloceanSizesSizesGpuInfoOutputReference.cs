using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanSizes
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfoOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfoOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanSizesSizesGpuInfoOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanSizesSizesGpuInfoOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanSizesSizesGpuInfoOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanSizesSizesGpuInfoOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Count
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "model", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Model
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "supportedPartitionModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SupportedPartitionModes
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "vram", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfoVramList\"}")]
        public virtual digitalocean.DataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfoVramList Vram
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfoVramList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanSizes.DataDigitaloceanSizesSizesGpuInfo\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanSizes.IDataDigitaloceanSizesSizesGpuInfo? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanSizes.IDataDigitaloceanSizesSizesGpuInfo?>();
            set => SetInstanceProperty(value);
        }
    }
}
