using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiByValue(fqn: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication")]
    public class GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication : aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#aws_managed_client_application_reference GlueConnection#aws_managed_client_application_reference}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "awsManagedClientApplicationReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AwsManagedClientApplicationReference
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#user_managed_client_application_client_id GlueConnection#user_managed_client_application_client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userManagedClientApplicationClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserManagedClientApplicationClientId
        {
            get;
            set;
        }
    }
}
