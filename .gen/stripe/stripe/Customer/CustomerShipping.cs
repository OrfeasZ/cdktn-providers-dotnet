using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Customer
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.customer.CustomerShipping")]
    public class CustomerShipping : stripe.Customer.ICustomerShipping
    {
        /// <summary>address block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#address Customer#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.customer.CustomerShippingAddress\"}")]
        public stripe.Customer.ICustomerShippingAddress Address
        {
            get;
            set;
        }

        /// <summary>Customer name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#name Customer#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Customer phone (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/customer#phone Customer#phone}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Phone
        {
            get;
            set;
        }
    }
}
