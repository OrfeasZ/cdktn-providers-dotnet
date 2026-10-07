using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseCustomerContactsToSendToOci), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseCustomerContactsToSendToOci")]
    public interface IOdbAutonomousDatabaseCustomerContactsToSendToOci
    {
        /// <summary>Email address of the customer contact.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#email OdbAutonomousDatabase#email}
        /// </remarks>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        string Email
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseCustomerContactsToSendToOci), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseCustomerContactsToSendToOci")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseCustomerContactsToSendToOci
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Email address of the customer contact.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#email OdbAutonomousDatabase#email}
            /// </remarks>
            [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
            public string Email
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
