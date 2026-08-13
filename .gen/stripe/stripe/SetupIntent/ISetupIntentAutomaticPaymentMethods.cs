using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.SetupIntent
{
    [JsiiInterface(nativeType: typeof(ISetupIntentAutomaticPaymentMethods), fullyQualifiedName: "stripe.setupIntent.SetupIntentAutomaticPaymentMethods")]
    public interface ISetupIntentAutomaticPaymentMethods
    {
        /// <summary>Automatically calculates compatible payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#enabled SetupIntent#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Controls whether this SetupIntent will accept redirect-based payment methods.</summary>
        /// <remarks>
        /// Redirect-based payment methods may require your customer to be redirected to a payment method's app or site for authentication or additional steps. To <a href="https://docs.stripe.com/api/setup_intents/confirm">confirm</a> this SetupIntent, you may be required to provide a <c>return_url</c> to redirect customers back to your site after they authenticate or complete the setup.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#allow_redirects SetupIntent#allow_redirects}
        /// </remarks>
        [JsiiProperty(name: "allowRedirects", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AllowRedirects
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISetupIntentAutomaticPaymentMethods), fullyQualifiedName: "stripe.setupIntent.SetupIntentAutomaticPaymentMethods")]
        internal sealed class _Proxy : DeputyBase, stripe.SetupIntent.ISetupIntentAutomaticPaymentMethods
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Automatically calculates compatible payment methods.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#enabled SetupIntent#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Controls whether this SetupIntent will accept redirect-based payment methods.</summary>
            /// <remarks>
            /// Redirect-based payment methods may require your customer to be redirected to a payment method's app or site for authentication or additional steps. To <a href="https://docs.stripe.com/api/setup_intents/confirm">confirm</a> this SetupIntent, you may be required to provide a <c>return_url</c> to redirect customers back to your site after they authenticate or complete the setup.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/setup_intent#allow_redirects SetupIntent#allow_redirects}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowRedirects", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AllowRedirects
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
