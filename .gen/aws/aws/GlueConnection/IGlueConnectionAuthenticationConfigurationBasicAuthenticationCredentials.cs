using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueConnection
{
    [JsiiInterface(nativeType: typeof(IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials")]
    public interface IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#password GlueConnection#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#username GlueConnection#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials), fullyQualifiedName: "aws.glueConnection.GlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials")]
        internal sealed class _Proxy : DeputyBase, aws.GlueConnection.IGlueConnectionAuthenticationConfigurationBasicAuthenticationCredentials
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#password GlueConnection#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.45.0/docs/resources/glue_connection#username GlueConnection#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
