using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataBillingDetails), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails")]
    public interface IThreeDSecureAuthenticationPaymentMethodDataBillingDetails
    {
        /// <summary>Billing address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#address ThreeDSecureAuthentication#address}
        /// </remarks>
        [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress? Address
        {
            get
            {
                return null;
            }
        }

        /// <summary>Email address.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#email ThreeDSecureAuthentication#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        /// <summary>Full name.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#name ThreeDSecureAuthentication#name}
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Billing phone number (including extension).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#phone ThreeDSecureAuthentication#phone}
        /// </remarks>
        [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Phone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationPaymentMethodDataBillingDetails), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetails")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Billing address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#address ThreeDSecureAuthentication#address}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "address", typeJson: "{\"fqn\":\"stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress\"}", isOptional: true)]
            public stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress? Address
            {
                get => GetInstanceProperty<stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationPaymentMethodDataBillingDetailsAddress?>();
            }

            /// <summary>Email address.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#email ThreeDSecureAuthentication#email}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Full name.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#name ThreeDSecureAuthentication#name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Billing phone number (including extension).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#phone ThreeDSecureAuthentication#phone}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "phone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Phone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
