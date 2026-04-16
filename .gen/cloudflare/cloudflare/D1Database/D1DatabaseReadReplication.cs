using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.D1Database
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "cloudflare.d1Database.D1DatabaseReadReplication")]
    public class D1DatabaseReadReplication : cloudflare.D1Database.ID1DatabaseReadReplication
    {
        /// <summary>The read replication mode for the database.</summary>
        /// <remarks>
        /// Use 'auto' to create replicas and allow D1 automatically place them around the world, or 'disabled' to not use any database replicas (it can take a few hours for all replicas to be deleted).
        /// Available values: "auto", "disabled".
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/cloudflare/cloudflare/5.18.0/docs/resources/d1_database#mode D1Database#mode}
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public string Mode
        {
            get;
            set;
        }
    }
}
