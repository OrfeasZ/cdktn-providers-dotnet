using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.VectorDatabase
{
    [JsiiByValue(fqn: "digitalocean.vectorDatabase.VectorDatabaseTimeouts")]
    public class VectorDatabaseTimeouts : digitalocean.VectorDatabase.IVectorDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.99.1/docs/resources/vector_database#create VectorDatabase#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
