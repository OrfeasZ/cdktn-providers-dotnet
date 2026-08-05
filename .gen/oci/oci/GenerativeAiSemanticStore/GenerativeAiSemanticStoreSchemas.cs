using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GenerativeAiSemanticStore
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemas")]
    public class GenerativeAiSemanticStoreSchemas : oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemas
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_semantic_store#connection_type GenerativeAiSemanticStore#connection_type}.</summary>
        [JsiiProperty(name: "connectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConnectionType
        {
            get;
            set;
        }

        private object _schemas;

        /// <summary>schemas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.26.0/docs/resources/generative_ai_semantic_store#schemas GenerativeAiSemanticStore#schemas}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "schemas", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.generativeAiSemanticStore.GenerativeAiSemanticStoreSchemasSchemas\"},\"kind\":\"array\"}}]}}")]
        public object Schemas
        {
            get => _schemas;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.GenerativeAiSemanticStore.IGenerativeAiSemanticStoreSchemasSchemas).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schemas = value;
            }
        }
    }
}
