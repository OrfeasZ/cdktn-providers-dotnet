using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseTransportableTablespace")]
    public class OdbAutonomousDatabaseTransportableTablespace : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseTransportableTablespace
    {
        /// <summary>URL of the transportable tablespace bundle.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#tts_bundle_url OdbAutonomousDatabase#tts_bundle_url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ttsBundleUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TtsBundleUrl
        {
            get;
            set;
        }
    }
}
