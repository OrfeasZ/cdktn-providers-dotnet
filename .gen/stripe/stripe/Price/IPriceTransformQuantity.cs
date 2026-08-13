using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Price
{
    [JsiiInterface(nativeType: typeof(IPriceTransformQuantity), fullyQualifiedName: "stripe.price.PriceTransformQuantity")]
    public interface IPriceTransformQuantity
    {
        /// <summary>Divide usage by this number.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#divide_by Price#divide_by}
        /// </remarks>
        [JsiiProperty(name: "divideBy", typeJson: "{\"primitive\":\"number\"}")]
        double DivideBy
        {
            get;
        }

        /// <summary>After division, either round the result `up` or `down`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#round Price#round}
        /// </remarks>
        [JsiiProperty(name: "round", typeJson: "{\"primitive\":\"string\"}")]
        string Round
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPriceTransformQuantity), fullyQualifiedName: "stripe.price.PriceTransformQuantity")]
        internal sealed class _Proxy : DeputyBase, stripe.Price.IPriceTransformQuantity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Divide usage by this number.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#divide_by Price#divide_by}
            /// </remarks>
            [JsiiProperty(name: "divideBy", typeJson: "{\"primitive\":\"number\"}")]
            public double DivideBy
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>After division, either round the result `up` or `down`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/price#round Price#round}
            /// </remarks>
            [JsiiProperty(name: "round", typeJson: "{\"primitive\":\"string\"}")]
            public string Round
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
