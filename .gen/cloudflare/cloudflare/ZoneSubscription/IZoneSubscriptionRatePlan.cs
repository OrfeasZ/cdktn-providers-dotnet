using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.ZoneSubscription
{
    [JsiiInterface(nativeType: typeof(IZoneSubscriptionRatePlan), fullyQualifiedName: "cloudflare.zoneSubscription.ZoneSubscriptionRatePlan")]
    public interface IZoneSubscriptionRatePlan
    {
        /// <summary>The ID of the rate plan. Available values: "free", "lite", "pro", "pro_plus", "business", "enterprise", "partners_free", "partners_pro", "partners_business", "partners_enterprise", "partners_ent".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#id ZoneSubscription#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>The scope that this rate plan applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#scope ZoneSubscription#scope}
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IZoneSubscriptionRatePlan), fullyQualifiedName: "cloudflare.zoneSubscription.ZoneSubscriptionRatePlan")]
        internal sealed class _Proxy : DeputyBase, cloudflare.ZoneSubscription.IZoneSubscriptionRatePlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ID of the rate plan. Available values: "free", "lite", "pro", "pro_plus", "business", "enterprise", "partners_free", "partners_pro", "partners_business", "partners_enterprise", "partners_ent".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#id ZoneSubscription#id}
            ///
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The scope that this rate plan applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/zone_subscription#scope ZoneSubscription#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
