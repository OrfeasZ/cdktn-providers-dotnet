using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiInterface(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties")]
    public interface IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#authorization_code GlueConnection#authorization_code}.</summary>
        [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
        string AuthorizationCode
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#redirect_uri GlueConnection#redirect_uri}.</summary>
        [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectUri
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties")]
        internal sealed class _Proxy : DeputyBase, aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#authorization_code GlueConnection#authorization_code}.</summary>
            [JsiiProperty(name: "authorizationCode", typeJson: "{\"primitive\":\"string\"}")]
            public string AuthorizationCode
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#redirect_uri GlueConnection#redirect_uri}.</summary>
            [JsiiProperty(name: "redirectUri", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectUri
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
