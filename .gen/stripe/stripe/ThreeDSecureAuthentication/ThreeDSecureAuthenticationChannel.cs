using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel")]
    public class ThreeDSecureAuthenticationChannel : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel
    {
        /// <summary>Type of channel you would prefer to use for this 3DS Authentication. Only browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Contains details on the browser for a standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#browser ThreeDSecureAuthentication#browser}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "browser", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser? Browser
        {
            get;
            set;
        }

        /// <summary>Contains details for a 3RI standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#three_r_i ThreeDSecureAuthentication#three_r_i}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "threeRI", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI? ThreeRI
        {
            get;
            set;
        }
    }
}
