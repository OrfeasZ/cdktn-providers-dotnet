using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    [JsiiInterface(nativeType: typeof(IProductPackageDimensions), fullyQualifiedName: "stripe.product.ProductPackageDimensions")]
    public interface IProductPackageDimensions
    {
        /// <summary>Height, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#height Product#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        double Height
        {
            get;
        }

        /// <summary>Length, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#length Product#length}
        /// </remarks>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        double Length
        {
            get;
        }

        /// <summary>Weight, in ounces. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#weight Product#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        /// <summary>Width, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#width Product#width}
        /// </remarks>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        double Width
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IProductPackageDimensions), fullyQualifiedName: "stripe.product.ProductPackageDimensions")]
        internal sealed class _Proxy : DeputyBase, stripe.Product.IProductPackageDimensions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Height, in inches. Maximum precision is 2 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#height Product#height}
            /// </remarks>
            [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
            public double Height
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Length, in inches. Maximum precision is 2 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#length Product#length}
            /// </remarks>
            [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
            public double Length
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Weight, in ounces. Maximum precision is 2 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#weight Product#weight}
            /// </remarks>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Width, in inches. Maximum precision is 2 decimal places.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#width Product#width}
            /// </remarks>
            [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
            public double Width
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
