using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.FieldExtractor
{
    [JsiiInterface(nativeType: typeof(IFieldExtractorRules), fullyQualifiedName: "cloudflare.fieldExtractor.FieldExtractorRules")]
    public interface IFieldExtractorRules
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#fields FieldExtractor#fields}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FieldExtractor.IFieldExtractorRulesFields" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.fieldExtractor.FieldExtractorRulesFields\"},\"kind\":\"array\"}}]}}")]
        object Fields
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#ref FieldExtractor#ref}.</summary>
        [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}")]
        string Ref
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#description FieldExtractor#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFieldExtractorRules), fullyQualifiedName: "cloudflare.fieldExtractor.FieldExtractorRules")]
        internal sealed class _Proxy : DeputyBase, cloudflare.FieldExtractor.IFieldExtractorRules
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#fields FieldExtractor#fields}.</summary>
            /// <remarks>
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="cloudflare.FieldExtractor.IFieldExtractorRulesFields" />)[]</para>
            /// </remarks>
            [JsiiProperty(name: "fields", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"cloudflare.fieldExtractor.FieldExtractorRulesFields\"},\"kind\":\"array\"}}]}}")]
            public object Fields
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#ref FieldExtractor#ref}.</summary>
            [JsiiProperty(name: "ref", typeJson: "{\"primitive\":\"string\"}")]
            public string Ref
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/field_extractor#description FieldExtractor#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
