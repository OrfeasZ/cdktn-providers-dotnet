using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiClass(nativeType: typeof(stripe.Product.ProductPackageDimensionsOutputReference), fullyQualifiedName: "stripe.product.ProductPackageDimensionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ProductPackageDimensionsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ProductPackageDimensionsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductPackageDimensionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ProductPackageDimensionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "heightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? HeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lengthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LengthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weightInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WeightInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "widthInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? WidthInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Height
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Length
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Weight
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Width
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"stripe.product.ProductPackageDimensions\"}", isOptional: true)]
        public virtual stripe.Product.IProductPackageDimensions? InternalValue
        {
            get => GetInstanceProperty<stripe.Product.IProductPackageDimensions?>();
            set => SetInstanceProperty(value);
        }
    }
}
