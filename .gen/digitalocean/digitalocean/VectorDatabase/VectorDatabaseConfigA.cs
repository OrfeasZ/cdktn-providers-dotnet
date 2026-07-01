using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VectorDatabase
{
    [JsiiByValue(fqn: "digitalocean.vectorDatabase.VectorDatabaseConfigA")]
    public class VectorDatabaseConfigA : digitalocean.VectorDatabase.IVectorDatabaseConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/vector_database#default_quantization VectorDatabase#default_quantization}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultQuantization
        {
            get;
            set;
        }

        private object? _enableAutoSchema;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/vector_database#enable_auto_schema VectorDatabase#enable_auto_schema}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enableAutoSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? EnableAutoSchema
        {
            get => _enableAutoSchema;
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
                _enableAutoSchema = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.93.0/docs/resources/vector_database#weaviate_version VectorDatabase#weaviate_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weaviateVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? WeaviateVersion
        {
            get;
            set;
        }
    }
}
