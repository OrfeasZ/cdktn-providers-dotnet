using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanGradientaiOpenaiApiKeys
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanGradientaiOpenaiApiKeysFilter), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiOpenaiApiKeys.DataDigitaloceanGradientaiOpenaiApiKeysFilter")]
    public interface IDataDigitaloceanGradientaiOpenaiApiKeysFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#key DataDigitaloceanGradientaiOpenaiApiKeys#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#values DataDigitaloceanGradientaiOpenaiApiKeys#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#all DataDigitaloceanGradientaiOpenaiApiKeys#all}.</summary>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#match_by DataDigitaloceanGradientaiOpenaiApiKeys#match_by}.</summary>
        [JsiiProperty(name: "matchBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchBy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanGradientaiOpenaiApiKeysFilter), fullyQualifiedName: "digitalocean.dataDigitaloceanGradientaiOpenaiApiKeys.DataDigitaloceanGradientaiOpenaiApiKeysFilter")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanGradientaiOpenaiApiKeys.IDataDigitaloceanGradientaiOpenaiApiKeysFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#key DataDigitaloceanGradientaiOpenaiApiKeys#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#values DataDigitaloceanGradientaiOpenaiApiKeys#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#all DataDigitaloceanGradientaiOpenaiApiKeys#all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/data-sources/gradientai_openai_api_keys#match_by DataDigitaloceanGradientaiOpenaiApiKeys#match_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchBy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
