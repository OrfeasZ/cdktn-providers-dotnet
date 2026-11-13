using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationFlowPreferenceFrictionless), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless")]
    public interface IThreeDSecureAuthenticationFlowPreferenceFrictionless
    {
        /// <summary>Type of frictionless flow you requested for this 3DS Authentication.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationFlowPreferenceFrictionless), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFlowPreferenceFrictionless")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFlowPreferenceFrictionless
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Type of frictionless flow you requested for this 3DS Authentication.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
