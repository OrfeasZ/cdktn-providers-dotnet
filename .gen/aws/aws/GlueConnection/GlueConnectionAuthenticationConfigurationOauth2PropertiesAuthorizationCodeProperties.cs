using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties")]
    public class GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties : aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#authorization_code GlueConnection#authorization_code}.</summary>
        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        public string AuthorizationCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#redirect_uri GlueConnection#redirect_uri}.</summary>
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectUri
        {
            get;
            set;
        }
    }
}
