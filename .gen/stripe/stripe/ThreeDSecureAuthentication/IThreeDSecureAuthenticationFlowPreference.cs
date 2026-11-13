using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationFlowPreference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference")]
    public interface IThreeDSecureAuthenticationFlowPreference
    {
        /// <summary>Type of flow you requested for this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#challenge ThreeDSecureAuthentication#challenge}.</summary>
        [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallenge\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge? Challenge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#data_share ThreeDSecureAuthentication#data_share}.</summary>
        [JsiiProperty(name: "dataShare", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShare\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare? DataShare
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#frictionless ThreeDSecureAuthentication#frictionless}.</summary>
        [JsiiProperty(name: "frictionless", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless? Frictionless
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationFlowPreference), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreference")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of flow you requested for this 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#challenge ThreeDSecureAuthentication#challenge}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "challenge", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceChallenge\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge? Challenge
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceChallenge?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#data_share ThreeDSecureAuthentication#data_share}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataShare", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceDataShare\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare? DataShare
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceDataShare?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#frictionless ThreeDSecureAuthentication#frictionless}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "frictionless", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless? Frictionless
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless?>();
            }
        }
    }
}
