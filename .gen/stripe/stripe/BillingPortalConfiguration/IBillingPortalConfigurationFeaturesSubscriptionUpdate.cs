using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.BillingPortalConfiguration
{
    [JsiiInterface(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdate), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate")]
    public interface IBillingPortalConfigurationFeaturesSubscriptionUpdate
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

        /// <summary>Determines the value to use for the billing cycle anchor on subscription updates.</summary>
        /// <remarks>
        /// Valid values are <c>now</c> or <c>unchanged</c>, and the default value is <c>unchanged</c>. Setting the value to <c>now</c> resets the subscription's billing cycle anchor to the current time (in UTC). For more information, see the billing cycle <a href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#billing_cycle_anchor BillingPortalConfiguration#billing_cycle_anchor}
        /// </remarks>
        [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? BillingCycleAnchor
        {
            get
            {
                return null;
            }
        }

        /// <summary>The types of subscription updates that are supported for items listed in the `products` attribute.</summary>
        /// <remarks>
        /// When empty, subscriptions are not updateable.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#default_allowed_updates BillingPortalConfiguration#default_allowed_updates}
        /// </remarks>
        [JsiiProperty(name: "defaultAllowedUpdates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DefaultAllowedUpdates
        {
            get
            {
                return null;
            }
        }

        /// <summary>The list of up to 10 products that support subscription updates.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#products BillingPortalConfiguration#products}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateProducts" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "products", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Products
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how to handle prorations resulting from subscription updates.</summary>
        /// <remarks>
        /// Valid values are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>. Defaults to a value of <c>none</c> if you don't set it during creation.
        ///
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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#schedule_at_period_end BillingPortalConfiguration#schedule_at_period_end}.</summary>
        [JsiiProperty(name: "scheduleAtPeriodEnd", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd? ScheduleAtPeriodEnd
        {
            get
            {
                return null;
            }
        }

        /// <summary>Determines how handle updates to trialing subscriptions.</summary>
        /// <remarks>
        /// Valid values are <c>end_trial</c> and <c>continue_trial</c>. Defaults to a value of <c>end_trial</c> if you don't set it during creation.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#trial_update_behavior BillingPortalConfiguration#trial_update_behavior}
        /// </remarks>
        [JsiiProperty(name: "trialUpdateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrialUpdateBehavior
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBillingPortalConfigurationFeaturesSubscriptionUpdate), fullyQualifiedName: "stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdate")]
        internal sealed class _Proxy : DeputyBase, stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdate
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

            /// <summary>Determines the value to use for the billing cycle anchor on subscription updates.</summary>
            /// <remarks>
            /// Valid values are <c>now</c> or <c>unchanged</c>, and the default value is <c>unchanged</c>. Setting the value to <c>now</c> resets the subscription's billing cycle anchor to the current time (in UTC). For more information, see the billing cycle <a href="https://docs.stripe.com/billing/subscriptions/billing-cycle">documentation</a>.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#billing_cycle_anchor BillingPortalConfiguration#billing_cycle_anchor}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "billingCycleAnchor", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? BillingCycleAnchor
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The types of subscription updates that are supported for items listed in the `products` attribute.</summary>
            /// <remarks>
            /// When empty, subscriptions are not updateable.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#default_allowed_updates BillingPortalConfiguration#default_allowed_updates}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultAllowedUpdates", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DefaultAllowedUpdates
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>The list of up to 10 products that support subscription updates.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#products BillingPortalConfiguration#products}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateProducts" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "products", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateProducts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Products
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Determines how to handle prorations resulting from subscription updates.</summary>
            /// <remarks>
            /// Valid values are <c>none</c>, <c>create_prorations</c>, and <c>always_invoice</c>. Defaults to a value of <c>none</c> if you don't set it during creation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#proration_behavior BillingPortalConfiguration#proration_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "prorationBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ProrationBehavior
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#schedule_at_period_end BillingPortalConfiguration#schedule_at_period_end}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleAtPeriodEnd", typeJson: "{\"fqn\":\"stripe.billingPortalConfiguration.BillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd\"}", isOptional: true)]
            public stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd? ScheduleAtPeriodEnd
            {
                get => GetInstanceProperty<stripe.BillingPortalConfiguration.IBillingPortalConfigurationFeaturesSubscriptionUpdateScheduleAtPeriodEnd?>();
            }

            /// <summary>Determines how handle updates to trialing subscriptions.</summary>
            /// <remarks>
            /// Valid values are <c>end_trial</c> and <c>continue_trial</c>. Defaults to a value of <c>end_trial</c> if you don't set it during creation.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.0/docs/resources/billing_portal_configuration#trial_update_behavior BillingPortalConfiguration#trial_update_behavior}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "trialUpdateBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrialUpdateBehavior
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
