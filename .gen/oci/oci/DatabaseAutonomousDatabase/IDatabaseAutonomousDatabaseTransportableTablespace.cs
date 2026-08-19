using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseTransportableTablespace), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespace")]
    public interface IDatabaseAutonomousDatabaseTransportableTablespace
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_database#tts_bundle_url DatabaseAutonomousDatabase#tts_bundle_url}.</summary>
        [JsiiProperty(name: "ttsBundleUrl", typeJson: "{\"primitive\":\"string\"}")]
        string TtsBundleUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseTransportableTablespace), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseTransportableTablespace")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseTransportableTablespace
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.28.0/docs/resources/database_autonomous_database#tts_bundle_url DatabaseAutonomousDatabase#tts_bundle_url}.</summary>
            [JsiiProperty(name: "ttsBundleUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string TtsBundleUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
