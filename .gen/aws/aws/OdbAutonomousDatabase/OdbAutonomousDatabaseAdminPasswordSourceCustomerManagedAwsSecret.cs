using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OdbAutonomousDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.odbAutonomousDatabase.OdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret")]
    public class OdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret : aws.OdbAutonomousDatabase.IOdbAutonomousDatabaseAdminPasswordSourceCustomerManagedAwsSecret
    {
        /// <summary>Type of OCI identifier supplied as the external ID when OCI assumes the IAM role.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#external_id_type OdbAutonomousDatabase#external_id_type}
        /// </remarks>
        [JsiiProperty(name: "externalIdType", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalIdType
        {
            get;
            set;
        }

        /// <summary>ARN of the customer-managed IAM role OCI assumes to retrieve the secret.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#iam_role_arn OdbAutonomousDatabase#iam_role_arn}
        /// </remarks>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public string IamRoleArn
        {
            get;
            set;
        }

        /// <summary>ARN of the AWS Secrets Manager secret that contains the ADMIN password.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.68.0/docs/resources/odb_autonomous_database#secret_arn OdbAutonomousDatabase#secret_arn}
        /// </remarks>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretArn
        {
            get;
            set;
        }
    }
}
