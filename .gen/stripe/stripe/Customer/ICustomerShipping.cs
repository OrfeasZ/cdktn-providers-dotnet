using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    [JsiiInterface(nativeType: typeof(ICustomerShipping), fullyQualifiedName: "stripe.customer.CustomerShipping")]
    public interface ICustomerShipping
    {
        /// <summary>address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingAddress\"}")]
        stripe.Customer.ICustomerShippingAddress Address
        {
            get;
        }

        /// <summary>Customer name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Customer phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
        /// </remarks>
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICustomerShipping), fullyQualifiedName: "stripe.customer.CustomerShipping")]
        internal sealed class _Proxy : DeputyBase, stripe.Customer.ICustomerShipping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>address block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
            /// </remarks>
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingAddress\"}")]
            public stripe.Customer.ICustomerShippingAddress Address
            {
                get => GetInstanceProperty<stripe.Customer.ICustomerShippingAddress>()!;
            }

            /// <summary>Customer name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Customer phone (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
