using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiInterface(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2Properties), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties")]
    public interface IGlueConnectionAuthenticationConfigurationOauth2Properties
    {
        /// <summary>authorization_code_properties block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#authorization_code_properties GlueConnection#authorization_code_properties}
        /// </remarks>
        [JsiiProperty(name: "authorizationCodeProperties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth2_client_application block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_client_application GlueConnection#oauth2_client_application}
        /// </remarks>
        [JsiiProperty(name: "oauth2ClientApplication", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication
        {
            get
            {
                return null;
            }
        }

        /// <summary>oauth2_credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_credentials GlueConnection#oauth2_credentials}
        /// </remarks>
        [JsiiProperty(name: "oauth2Credentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_grant_type GlueConnection#oauth2_grant_type}.</summary>
        [JsiiProperty(name: "oauth2GrantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Oauth2GrantType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#token_url GlueConnection#token_url}.</summary>
        [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TokenUrl
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#token_url_parameters_map GlueConnection#token_url_parameters_map}.</summary>
        [JsiiProperty(name: "tokenUrlParametersMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TokenUrlParametersMap
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2Properties), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2Properties")]
        internal sealed class _Proxy : DeputyBase, aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2Properties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>authorization_code_properties block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#authorization_code_properties GlueConnection#authorization_code_properties}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationCodeProperties", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties\"}", isOptional: true)]
            public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties? AuthorizationCodeProperties
            {
                get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesAuthorizationCodeProperties?>();
            }

            /// <summary>oauth2_client_application block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_client_application GlueConnection#oauth2_client_application}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2ClientApplication", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication\"}", isOptional: true)]
            public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication? Oauth2ClientApplication
            {
                get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication?>();
            }

            /// <summary>oauth2_credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_credentials GlueConnection#oauth2_credentials}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2Credentials", typeJson: "{\"fqn\":\"aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials\"}", isOptional: true)]
            public aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials? Oauth2Credentials
            {
                get => GetInstanceProperty<aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2Credentials?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#oauth2_grant_type GlueConnection#oauth2_grant_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "oauth2GrantType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Oauth2GrantType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#token_url GlueConnection#token_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TokenUrl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.44.0/docs/resources/glue_connection#token_url_parameters_map GlueConnection#token_url_parameters_map}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tokenUrlParametersMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TokenUrlParametersMap
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
