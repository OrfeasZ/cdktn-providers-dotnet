using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VectorDatabase
{
    [JsiiInterface(nativeType: typeof(IVectorDatabaseConfigA), fullyQualifiedName: "digitalocean.vectorDatabase.VectorDatabaseConfigA")]
    public interface IVectorDatabaseConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#default_quantization VectorDatabase#default_quantization}.</summary>
        [JsiiProperty(name: "defaultQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultQuantization
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#enable_auto_schema VectorDatabase#enable_auto_schema}.</summary>
        /// <remarks>
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "enableAutoSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableAutoSchema
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#weaviate_version VectorDatabase#weaviate_version}.</summary>
        [JsiiProperty(name: "weaviateVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WeaviateVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVectorDatabaseConfigA), fullyQualifiedName: "digitalocean.vectorDatabase.VectorDatabaseConfigA")]
        internal sealed class _Proxy : DeputyBase, digitalocean.VectorDatabase.IVectorDatabaseConfigA
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#default_quantization VectorDatabase#default_quantization}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultQuantization", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultQuantization
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#enable_auto_schema VectorDatabase#enable_auto_schema}.</summary>
            /// <remarks>
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "enableAutoSchema", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? EnableAutoSchema
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.100.0/docs/resources/vector_database#weaviate_version VectorDatabase#weaviate_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weaviateVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WeaviateVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
