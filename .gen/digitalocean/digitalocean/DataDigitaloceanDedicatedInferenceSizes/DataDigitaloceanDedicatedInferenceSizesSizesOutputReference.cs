using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanDedicatedInferenceSizes
{
    [JsiiClass(nativeType: typeof(digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesOutputReference), fullyQualifiedName: "digitalocean.dataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataDigitaloceanDedicatedInferenceSizesSizesOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataDigitaloceanDedicatedInferenceSizesSizesOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataDigitaloceanDedicatedInferenceSizesSizesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataDigitaloceanDedicatedInferenceSizesSizesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Cpu
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Currency
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "disks", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesDisksList\"}")]
        public virtual digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesDisksList Disks
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesDisksList>()!;
        }

        [JsiiProperty(name: "gpu", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesGpuList\"}")]
        public virtual digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesGpuList Gpu
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesGpuList>()!;
        }

        [JsiiProperty(name: "gpuSlug", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string GpuSlug
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Memory
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "pricePerHour", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PricePerHour
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "regions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Regions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "sizeCategory", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesSizeCategoryList\"}")]
        public virtual digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesSizeCategoryList SizeCategory
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizesSizeCategoryList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"digitalocean.dataDigitaloceanDedicatedInferenceSizes.DataDigitaloceanDedicatedInferenceSizesSizes\"}", isOptional: true)]
        public virtual digitalocean.DataDigitaloceanDedicatedInferenceSizes.IDataDigitaloceanDedicatedInferenceSizesSizes? InternalValue
        {
            get => GetInstanceProperty<digitalocean.DataDigitaloceanDedicatedInferenceSizes.IDataDigitaloceanDedicatedInferenceSizesSizes?>();
            set => SetInstanceProperty(value);
        }
    }
}
