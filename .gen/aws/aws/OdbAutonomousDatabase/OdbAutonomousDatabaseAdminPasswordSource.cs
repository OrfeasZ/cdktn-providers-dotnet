using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSource")]
    public class OdbAutonomousDatabaseAdminPasswordSource : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSource
    {
        private object? _customerManagedAwsSecret;

        /// <summary>customer_managed_aws_secret block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#customer_managed_aws_secret OdbAutonomousDatabase#customer_managed_aws_secret}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customerManagedAwsSecret", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CustomerManagedAwsSecret
        {
            get => _customerManagedAwsSecret;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _customerManagedAwsSecret = value;
            }
        }
    }
}
