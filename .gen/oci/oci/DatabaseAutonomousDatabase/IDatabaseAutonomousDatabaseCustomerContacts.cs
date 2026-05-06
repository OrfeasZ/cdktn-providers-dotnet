using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DatabaseAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IDatabaseAutonomousDatabaseCustomerContacts), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseCustomerContacts")]
    public interface IDatabaseAutonomousDatabaseCustomerContacts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#email DatabaseAutonomousDatabase#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Email
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatabaseAutonomousDatabaseCustomerContacts), fullyQualifiedName: "oci.databaseAutonomousDatabase.DatabaseAutonomousDatabaseCustomerContacts")]
        internal sealed class _Proxy : DeputyBase, oci.DatabaseAutonomousDatabase.IDatabaseAutonomousDatabaseCustomerContacts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/database_autonomous_database#email DatabaseAutonomousDatabase#email}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Email
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
