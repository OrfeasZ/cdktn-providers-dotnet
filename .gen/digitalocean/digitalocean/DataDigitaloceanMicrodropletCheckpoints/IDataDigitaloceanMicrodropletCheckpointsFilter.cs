using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.DataDigitaloceanMicrodropletCheckpoints
{
    [JsiiInterface(nativeType: typeof(IDataDigitaloceanMicrodropletCheckpointsFilter), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodropletCheckpoints.DataDigitaloceanMicrodropletCheckpointsFilter")]
    public interface IDataDigitaloceanMicrodropletCheckpointsFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#key DataDigitaloceanMicrodropletCheckpoints#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#values DataDigitaloceanMicrodropletCheckpoints#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#all DataDigitaloceanMicrodropletCheckpoints#all}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? All
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#match_by DataDigitaloceanMicrodropletCheckpoints#match_by}.</summary>
        [JsiiProperty(name: "matchBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchBy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataDigitaloceanMicrodropletCheckpointsFilter), fullyQualifiedName: "digitalocean.dataDigitaloceanMicrodropletCheckpoints.DataDigitaloceanMicrodropletCheckpointsFilter")]
        internal sealed class _Proxy : DeputyBase, digitalocean.DataDigitaloceanMicrodropletCheckpoints.IDataDigitaloceanMicrodropletCheckpointsFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#key DataDigitaloceanMicrodropletCheckpoints#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#values DataDigitaloceanMicrodropletCheckpoints#values}.</summary>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#all DataDigitaloceanMicrodropletCheckpoints#all}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "all", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? All
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.97.0/docs/data-sources/microdroplet_checkpoints#match_by DataDigitaloceanMicrodropletCheckpoints#match_by}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "matchBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchBy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
