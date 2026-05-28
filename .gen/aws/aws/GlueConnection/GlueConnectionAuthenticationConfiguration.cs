using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueConnection.GlueConnectionAuthenticationConfiguration")]
    public class GlueConnectionAuthenticationConfiguration : aws.GlueConnection.IGlueConnectionAuthenticationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#authentication_type GlueConnection#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>basic_authentication_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#basic_authentication_credentials GlueConnection#basic_authentication_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuthenticationCredentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials\"}", isOptional: true)]
        public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials? BasicAuthenticationCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#custom_authentication_credentials GlueConnection#custom_authentication_credentials}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customAuthenticationCredentials", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? CustomAuthenticationCredentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#kms_key_arn GlueConnection#kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyArn
        {
            get;
            set;
        }

        /// <summary>oauth2_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#oauth2_properties GlueConnection#oauth2_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2Properties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties\"}", isOptional: true)]
        public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties? Oauth2Properties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.47.0/docs/resources/glue_connection#secret_arn GlueConnection#secret_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretArn
        {
            get;
            set;
        }
    }
}
