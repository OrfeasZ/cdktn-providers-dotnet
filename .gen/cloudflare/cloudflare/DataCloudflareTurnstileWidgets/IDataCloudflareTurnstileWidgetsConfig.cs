using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTurnstileWidgets
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareTurnstileWidgetsConfig), fullyQualifiedName: "cloudflare.dataCloudflareTurnstileWidgets.DataCloudflareTurnstileWidgetsConfig")]
    public interface IDataCloudflareTurnstileWidgetsConfig : Io.Cdktn.ITerraformMetaArguments
    {
        /// <summary>Identifier.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#account_id DataCloudflareTurnstileWidgets#account_id}
        /// </remarks>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#direction DataCloudflareTurnstileWidgets#direction}
        /// </remarks>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Direction
        {
            get
            {
                return null;
            }
        }

        /// <summary>Filter widgets by field using case-insensitive substring matching. Format: `field:value`.</summary>
        /// <remarks>
        /// Supported fields:
        ///
        /// <list type="bullet">
        /// <description><c>name</c> - Filter by widget name (e.g., <c>filter=name:login-form</c>)</description>
        /// <description><c>sitekey</c> - Filter by sitekey (e.g., <c>filter=sitekey:0x4AAA</c>)</description>
        /// </list>
        ///
        /// Returns 400 Bad Request if the field is unsupported or format is invalid.
        /// An empty filter value returns all results.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#filter DataCloudflareTurnstileWidgets#filter}
        /// </remarks>
        [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Filter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Max items to fetch, default: 1000.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#max_items DataCloudflareTurnstileWidgets#max_items}
        /// </remarks>
        [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxItems
        {
            get
            {
                return null;
            }
        }

        /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#order DataCloudflareTurnstileWidgets#order}
        /// </remarks>
        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Order
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareTurnstileWidgetsConfig), fullyQualifiedName: "cloudflare.dataCloudflareTurnstileWidgets.DataCloudflareTurnstileWidgetsConfig")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareTurnstileWidgets.IDataCloudflareTurnstileWidgetsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Identifier.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#account_id DataCloudflareTurnstileWidgets#account_id}
            /// </remarks>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Direction to order widgets. Available values: "asc", "desc".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#direction DataCloudflareTurnstileWidgets#direction}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Direction
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Filter widgets by field using case-insensitive substring matching. Format: `field:value`.</summary>
            /// <remarks>
            /// Supported fields:
            ///
            /// <list type="bullet">
            /// <description><c>name</c> - Filter by widget name (e.g., <c>filter=name:login-form</c>)</description>
            /// <description><c>sitekey</c> - Filter by sitekey (e.g., <c>filter=sitekey:0x4AAA</c>)</description>
            /// </list>
            ///
            /// Returns 400 Bad Request if the field is unsupported or format is invalid.
            /// An empty filter value returns all results.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#filter DataCloudflareTurnstileWidgets#filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Filter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Max items to fetch, default: 1000.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#max_items DataCloudflareTurnstileWidgets#max_items}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxItems", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxItems
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Field to order widgets by. Available values: "id", "sitekey", "name", "created_on", "modified_on".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/turnstile_widgets#order DataCloudflareTurnstileWidgets#order}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Order
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.SSHProvisionerConnection\"},{\"fqn\":\"cdktn.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktn.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktn.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public Io.Cdktn.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktn.ITerraformIterator\"}", isOptional: true)]
            public Io.Cdktn.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktn.TerraformResourceLifecycle\"}", isOptional: true)]
            public Io.Cdktn.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<Io.Cdktn.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktn.TerraformProvider\"}", isOptional: true)]
            public Io.Cdktn.TerraformProvider? Provider
            {
                get => GetInstanceProperty<Io.Cdktn.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.FileProvisioner\"},{\"fqn\":\"cdktn.LocalExecProvisioner\"},{\"fqn\":\"cdktn.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
