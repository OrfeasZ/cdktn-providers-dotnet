using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.PaymentIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "stripe.paymentIntent.PaymentIntentAutomaticPaymentMethods")]
    public class PaymentIntentAutomaticPaymentMethods : stripe.PaymentIntent.IPaymentIntentAutomaticPaymentMethods
    {
        private object _enabled;

        /// <summary>Automatically calculates compatible payment methods.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#enabled PaymentIntent#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Controls whether this PaymentIntent will accept redirect-based payment methods.</summary>
        /// <remarks>
        /// Redirect-based payment methods may require your customer to be redirected to a payment method's app or site for authentication or additional steps. To <a href="https://docs.stripe.com/api/payment_intents/confirm">confirm</a> this PaymentIntent, you may be required to provide a <c>return_url</c> to redirect customers back to your site after they authenticate or complete the payment.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/payment_intent#allow_redirects PaymentIntent#allow_redirects}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowRedirects", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllowRedirects
        {
            get;
            set;
        }
    }
}
