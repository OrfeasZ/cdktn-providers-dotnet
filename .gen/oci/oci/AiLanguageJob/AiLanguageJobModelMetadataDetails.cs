using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.AiLanguageJob
{
    [JsiiByValue(fqn: "oci.aiLanguageJob.AiLanguageJobModelMetadataDetails")]
    public class AiLanguageJobModelMetadataDetails : oci.AiLanguageJob.IAiLanguageJobModelMetadataDetails
    {
        private object? _configuration;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#configuration AiLanguageJob#configuration}.</summary>
        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or Dictionary&lt;string, Dictionary&lt;string, string&gt;&gt;</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},\"kind\":\"map\"}}]}}", isOptional: true)]
        public object? Configuration
        {
            get => _configuration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>> cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, System.Collections.Generic.IDictionary<string, System.Collections.Generic.IDictionary<string, string>>; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _configuration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#endpoint_id AiLanguageJob#endpoint_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endpointId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndpointId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#language_code AiLanguageJob#language_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "languageCode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LanguageCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#model_id AiLanguageJob#model_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.29.0/docs/resources/ai_language_job#model_type AiLanguageJob#model_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modelType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModelType
        {
            get;
            set;
        }
    }
}
