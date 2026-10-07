using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiInterface(nativeType: typeof(IOdbAutonomousDatabaseAdminPasswordSource), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSource")]
    public interface IOdbAutonomousDatabaseAdminPasswordSource
    {
        /// <summary>customer_managed_aws_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#customer_managed_aws_secret OdbAutonomousDatabase#customer_managed_aws_secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "customerManagedAwsSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CustomerManagedAwsSecret
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOdbAutonomousDatabaseAdminPasswordSource), fullyQualifiedName: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSource")]
        internal sealed class _Proxy : DeputyBase, aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>customer_managed_aws_secret block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#customer_managed_aws_secret OdbAutonomousDatabase#customer_managed_aws_secret}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customerManagedAwsSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? CustomerManagedAwsSecret
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
