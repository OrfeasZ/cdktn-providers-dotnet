using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VectorDatabase
{
    [JsiiInterface(nativeType: typeof(IVectorDatabaseTimeouts), fullyQualifiedName: "digitalocean.vectorDatabase.VectorDatabaseTimeouts")]
    public interface IVectorDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/vector_database#create VectorDatabase#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVectorDatabaseTimeouts), fullyQualifiedName: "digitalocean.vectorDatabase.VectorDatabaseTimeouts")]
        internal sealed class _Proxy : DeputyBase, digitalocean.VectorDatabase.IVectorDatabaseTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.98.0/docs/resources/vector_database#create VectorDatabase#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
