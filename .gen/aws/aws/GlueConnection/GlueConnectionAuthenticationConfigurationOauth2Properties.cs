using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiByValue(fqn: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties")]
    public class GlueConnectionAuthenticationConfigurationOauth2Properties : aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties
    {
        /// <summary>authorization_code_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#authorization_code_properties GlueConnection#authorization_code_properties}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationCodeProperties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties\"}", isOptional: true)]
        public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties
        {
            get;
            set;
        }

        /// <summary>oauth2_client_application block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#oauth2_client_application GlueConnection#oauth2_client_application}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2ClientApplication", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}", isOptional: true)]
        public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication
        {
            get;
            set;
        }

        /// <summary>oauth2_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#oauth2_credentials GlueConnection#oauth2_credentials}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2Credentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}", isOptional: true)]
        public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#oauth2_grant_type GlueConnection#oauth2_grant_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "oauth2GrantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Oauth2GrantType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#token_url GlueConnection#token_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TokenUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#token_url_parameters_map GlueConnection#token_url_parameters_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tokenUrlParametersMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TokenUrlParametersMap
        {
            get;
            set;
        }
    }
}
