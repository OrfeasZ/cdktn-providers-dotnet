using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationLoginPage), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationLoginPage")]
    public interface IBillingPortalConfigurationLoginPage
    {
        /// <summary>If `true`, a shareable `url` will be generated that will take your customers to a hosted login page for the customer portal.</summary>
        /// <remarks>
        /// If <c>false</c>, the previously generated <c>url</c>, if any, will be deactivated.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationLoginPage), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationLoginPage")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationLoginPage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>If `true`, a shareable `url` will be generated that will take your customers to a hosted login page for the customer portal.</summary>
            /// <remarks>
            /// If <c>false</c>, the previously generated <c>url</c>, if any, will be deactivated.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
