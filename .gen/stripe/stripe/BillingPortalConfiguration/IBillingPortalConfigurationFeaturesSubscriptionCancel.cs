using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionCancel), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionCancel
    {
        /// <summary>Whether the feature is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object Enabled
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#cancellation_reason BillingPortalConfiguration#cancellation_reason}.</summary>
        [JsiiProperty(name: "cancellationReason", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancelCancellationReason\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancelCancellationReason? CancellationReason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to cancel subscriptions immediately or at the end of the billing period.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#mode BillingPortalConfiguration#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether to create prorations when canceling subscriptions. Possible values are `none` and `create_prorations`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#proration_behavior BillingPortalConfiguration#proration_behavior}
        /// </remarks>
        [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ProrationBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionCancel), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancel")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancel
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Whether the feature is enabled.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#enabled BillingPortalConfiguration#enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object Enabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#cancellation_reason BillingPortalConfiguration#cancellation_reason}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cancellationReason", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionCancelCancellationReason\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancelCancellationReason? CancellationReason
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionCancelCancellationReason?>();
            }

            /// <summary>Whether to cancel subscriptions immediately or at the end of the billing period.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#mode BillingPortalConfiguration#mode}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether to create prorations when canceling subscriptions. Possible values are `none` and `create_prorations`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#proration_behavior BillingPortalConfiguration#proration_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
