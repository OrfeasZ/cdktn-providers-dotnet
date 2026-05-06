using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AccountSubscription
{
    [JsiiInterface(nativeType: typeof(IAccountSubscriptionRatePlan), fullyQualifiedName: "cloudflare.accountSubscription.AccountSubscriptionRatePlan")]
    public interface IAccountSubscriptionRatePlan
    {
        /// <summary>The currency applied to the rate plan subscription.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#currency AccountSubscription#currency}
        /// </remarks>
        [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Currency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Whether this rate plan is managed externally from Cloudflare.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#externally_managed AccountSubscription#externally_managed}
        /// </remarks>
        [JsiiProperty(name: "externallyManaged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExternallyManaged
        {
            get
            {
                return null;
            }
        }

        /// <summary>The ID of the rate plan. Available values: "free", "lite", "pro", "pro_plus", "business", "enterprise", "partners_free", "partners_pro", "partners_business", "partners_enterprise".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#id AccountSubscription#id}
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

        /// <summary>Whether a rate plan is enterprise-based (or newly adopted term contract).</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#is_contract AccountSubscription#is_contract}
        /// </remarks>
        [JsiiProperty(name: "isContract", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsContract
        {
            get
            {
                return null;
            }
        }

        /// <summary>The full name of the rate plan.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#public_name AccountSubscription#public_name}
        /// </remarks>
        [JsiiProperty(name: "publicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PublicName
        {
            get
            {
                return null;
            }
        }

        /// <summary>The scope that this rate plan applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#scope AccountSubscription#scope}
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

        /// <summary>The list of sets this rate plan applies to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#sets AccountSubscription#sets}
        /// </remarks>
        [JsiiProperty(name: "sets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Sets
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAccountSubscriptionRatePlan), fullyQualifiedName: "cloudflare.accountSubscription.AccountSubscriptionRatePlan")]
        internal sealed class _Proxy : DeputyBase, cloudflare.AccountSubscription.IAccountSubscriptionRatePlan
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The currency applied to the rate plan subscription.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#currency AccountSubscription#currency}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "currency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Currency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Whether this rate plan is managed externally from Cloudflare.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#externally_managed AccountSubscription#externally_managed}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externallyManaged", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? ExternallyManaged
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The ID of the rate plan. Available values: "free", "lite", "pro", "pro_plus", "business", "enterprise", "partners_free", "partners_pro", "partners_business", "partners_enterprise".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#id AccountSubscription#id}
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

            /// <summary>Whether a rate plan is enterprise-based (or newly adopted term contract).</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#is_contract AccountSubscription#is_contract}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "isContract", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? IsContract
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The full name of the rate plan.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#public_name AccountSubscription#public_name}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "publicName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PublicName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The scope that this rate plan applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#scope AccountSubscription#scope}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The list of sets this rate plan applies to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.7.1/docs/resources/account_subscription#sets AccountSubscription#sets}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Sets
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
