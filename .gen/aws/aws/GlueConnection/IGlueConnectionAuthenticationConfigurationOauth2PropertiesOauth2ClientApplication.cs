using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiInterface(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication")]
    public interface IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_connection#aws_managed_client_application_reference GlueConnection#aws_managed_client_application_reference}.</summary>
        [JsiiProperty(name: "awsManagedClientApplicationReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AwsManagedClientApplicationReference
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_connection#user_managed_client_application_client_id GlueConnection#user_managed_client_application_client_id}.</summary>
        [JsiiProperty(name: "userManagedClientApplicationClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserManagedClientApplicationClientId
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication")]
        internal sealed class _Proxy : DeputyBase, aws.GlueConnection.IGlueConnectionAuthenticationConfigurationOauth2PropertiesOauth2ClientApplication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_connection#aws_managed_client_application_reference GlueConnection#aws_managed_client_application_reference}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "awsManagedClientApplicationReference", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AwsManagedClientApplicationReference
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.46.0/docs/resources/glue_connection#user_managed_client_application_client_id GlueConnection#user_managed_client_application_client_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userManagedClientApplicationClientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserManagedClientApplicationClientId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
