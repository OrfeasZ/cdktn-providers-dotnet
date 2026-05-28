using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials")]
    public class GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials : aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#password GlueConnection#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#username GlueConnection#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
