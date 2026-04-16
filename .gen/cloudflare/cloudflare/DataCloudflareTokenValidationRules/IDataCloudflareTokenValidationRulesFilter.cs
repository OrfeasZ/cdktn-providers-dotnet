using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.DataCloudflareTokenValidationRules
{
    [JsiiInterface(nativeType: typeof(IDataCloudflareTokenValidationRulesFilter), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesFilter")]
    public interface IDataCloudflareTokenValidationRulesFilter
    {
        /// <summary>Action to take on requests that match operations included in `selector` and fail `expression`. Available values: "log", "block".</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#action DataCloudflareTokenValidationRules#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>Toggle rule on or off.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#enabled DataCloudflareTokenValidationRules#enabled}
        /// </remarks>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select rules with this host in `include`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#host DataCloudflareTokenValidationRules#host}
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select rules with this host in `include`.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#hostname DataCloudflareTokenValidationRules#hostname}
        /// </remarks>
        [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Hostname
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select rules with these IDs.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#id DataCloudflareTokenValidationRules#id}
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

        /// <summary>Select rules using any of these token configurations.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#token_configuration DataCloudflareTokenValidationRules#token_configuration}
        /// </remarks>
        [JsiiProperty(name: "tokenConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TokenConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataCloudflareTokenValidationRulesFilter), fullyQualifiedName: "cloudflare.dataCloudflareTokenValidationRules.DataCloudflareTokenValidationRulesFilter")]
        internal sealed class _Proxy : DeputyBase, cloudflare.DataCloudflareTokenValidationRules.IDataCloudflareTokenValidationRulesFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Action to take on requests that match operations included in `selector` and fail `expression`. Available values: "log", "block".</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#action DataCloudflareTokenValidationRules#action}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Toggle rule on or off.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#enabled DataCloudflareTokenValidationRules#enabled}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Select rules with this host in `include`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#host DataCloudflareTokenValidationRules#host}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Select rules with this host in `include`.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#hostname DataCloudflareTokenValidationRules#hostname}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostname", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Hostname
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Select rules with these IDs.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#id DataCloudflareTokenValidationRules#id}
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

            /// <summary>Select rules using any of these token configurations.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/data-sources/token_validation_rules#token_configuration DataCloudflareTokenValidationRules#token_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tokenConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TokenConfiguration
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
