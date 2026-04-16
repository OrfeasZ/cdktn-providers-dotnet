using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.Coupon
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.coupon.CouponScript")]
    public class CouponScript : stripe.Coupon.ICouponScript
    {
        /// <summary>The configuration values of the script. The keys and values are specific to the script implementation.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#configuration Coupon#configuration}
        /// </remarks>
        [JsiiProperty(name: "configuration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Configuration
        {
            get;
            set;
        }

        /// <summary>The script implementation ID for this coupon.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.2.2/docs/resources/coupon#id Coupon#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }
    }
}
