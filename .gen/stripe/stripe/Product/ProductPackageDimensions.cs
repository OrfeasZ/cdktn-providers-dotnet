using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Product
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.product.ProductPackageDimensions")]
    public class ProductPackageDimensions : stripe.Product.IProductPackageDimensions
    {
        /// <summary>Height, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#height Product#height}
        /// </remarks>
        [JsiiProperty(name: "height", typeJson: "{\"primitive\":\"number\"}")]
        public double Height
        {
            get;
            set;
        }

        /// <summary>Length, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#length Product#length}
        /// </remarks>
        [JsiiProperty(name: "length", typeJson: "{\"primitive\":\"number\"}")]
        public double Length
        {
            get;
            set;
        }

        /// <summary>Weight, in ounces. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#weight Product#weight}
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }

        /// <summary>Width, in inches. Maximum precision is 2 decimal places.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/product#width Product#width}
        /// </remarks>
        [JsiiProperty(name: "width", typeJson: "{\"primitive\":\"number\"}")]
        public double Width
        {
            get;
            set;
        }
    }
}
