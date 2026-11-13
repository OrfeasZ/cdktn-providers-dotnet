using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataCard), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard")]
    public interface IThreeDSecureAuthenticationPaymentMethodDataCard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#cvc ThreeDSecureAuthentication#cvc}.</summary>
        [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Cvc
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_month ThreeDSecureAuthentication#exp_month}.</summary>
        [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_year ThreeDSecureAuthentication#exp_year}.</summary>
        [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpYear
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#number ThreeDSecureAuthentication#number}.</summary>
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Number
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#token ThreeDSecureAuthentication#token}.</summary>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataCard), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataCard")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataCard
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#cvc ThreeDSecureAuthentication#cvc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cvc", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Cvc
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_month ThreeDSecureAuthentication#exp_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expMonth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpMonth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#exp_year ThreeDSecureAuthentication#exp_year}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expYear", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpYear
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#number ThreeDSecureAuthentication#number}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Number
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#token ThreeDSecureAuthentication#token}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
