using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference")]
    public class ThreeDSecureAuthenticationFlowPreference : stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference
    {
        /// <summary>Type of flow you requested for this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#challenge ThreeDSecureAuthentication#challenge}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallenge\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge? Challenge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#data_share ThreeDSecureAuthentication#data_share}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataShare", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShare\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare? DataShare
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#frictionless ThreeDSecureAuthentication#frictionless}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "frictionless", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless\"}", isOptional: true)]
        public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless? Frictionless
        {
            get;
            set;
        }
    }
}
