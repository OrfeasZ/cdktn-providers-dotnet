using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationChannel), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel")]
    public interface IThreeDSecureAuthenticationChannel
    {
        /// <summary>Type of channel you would prefer to use for this 3DS Authentication. Only browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Contains details on the browser for a standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#browser ThreeDSecureAuthentication#browser}
        /// </remarks>
        [JsiiProperty(name: "browser", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser? Browser
        {
            get
            {
                return null;
            }
        }

        /// <summary>Contains details for a 3RI standalone 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#three_r_i ThreeDSecureAuthentication#three_r_i}
        /// </remarks>
        [JsiiProperty(name: "threeRI", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI? ThreeRI
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationChannel), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannel")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of channel you would prefer to use for this 3DS Authentication. Only browser.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Contains details on the browser for a standalone 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#browser ThreeDSecureAuthentication#browser}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "browser", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser? Browser
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser?>();
            }

            /// <summary>Contains details for a 3RI standalone 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#three_r_i ThreeDSecureAuthentication#three_r_i}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "threeRI", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelThreeRI\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI? ThreeRI
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelThreeRI?>();
            }
        }
    }
}
