using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationFutureUsageInstallmentExpiry), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallmentExpiry")]
    public interface IThreeDSecureAuthenticationFutureUsageInstallmentExpiry
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#date ThreeDSecureAuthentication#date}.</summary>
        [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Date
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationFutureUsageInstallmentExpiry), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationFutureUsageInstallmentExpiry")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationFutureUsageInstallmentExpiry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#type ThreeDSecureAuthentication#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#date ThreeDSecureAuthentication#date}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "date", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Date
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
