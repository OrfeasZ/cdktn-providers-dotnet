using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespace")]
    public class DatabaseAutonomousDatabaseTransportableTablespace : oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseTransportableTablespace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.21.0/docs/resources/database_autonomous_database#tts_bundle_url DatabaseAutonomousDatabase#tts_bundle_url}.</summary>
        [JsiiProperty(name: "ttsBundleUrl", typeJson: "{\"primitive\":\"string\"}")]
        public string TtsBundleUrl
        {
            get;
            set;
        }
    }
}
