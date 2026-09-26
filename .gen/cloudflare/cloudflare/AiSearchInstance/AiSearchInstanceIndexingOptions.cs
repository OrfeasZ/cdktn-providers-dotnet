using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.AiSearchInstance
{
    [JsiiByValue(fqn: "cloudflare.aiSearchInstance.AiSearchInstanceIndexingOptions")]
    public class AiSearchInstanceIndexingOptions : cloudflare.AiSearchInstance.IAiSearchInstanceIndexingOptions
    {
        /// <summary>Tokenizer used for keyword search indexing.</summary>
        /// <remarks>
        /// porter provides word-level tokenization with Porter stemming (good for natural language queries). trigram enables character-level substring matching (good for partial matches, code, identifiers). Changing this triggers a full re-index. Defaults to porter.
        /// Available values: "porter", "trigram".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/ai_search_instance#keyword_tokenizer AiSearchInstance#keyword_tokenizer}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keywordTokenizer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeywordTokenizer
        {
            get;
            set;
        }

        private object? _useOcr;

        /// <summary>Enables OCR ingestion for PDFs and images. Changing this triggers a full re-index. Defaults to false.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.26.0/docs/resources/ai_search_instance#use_ocr AiSearchInstance#use_ocr}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "useOcr", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? UseOcr
        {
            get => _useOcr;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _useOcr = value;
            }
        }
    }
}
