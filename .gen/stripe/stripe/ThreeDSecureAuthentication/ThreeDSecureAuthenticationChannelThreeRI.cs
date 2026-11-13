using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI")]
    public class ThreeDSecureAuthenticationChannelThreeRI : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI
    {
        /// <summary>ID of the previous initial authenticated 3DS Authentication object.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#previous_authentication ThreeDSecureAuthentication#previous_authentication}
        /// </remarks>
        [JsiiProperty(name: "previousAuthentication", typeJson: "{\"primitive\":\"string\"}")]
        public string PreviousAuthentication
        {
            get;
            set;
        }

        /// <summary>Type of the 3RI Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
