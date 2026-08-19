using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MailmanagerRelay
{
    [JsiiInterface(nativeType: typeof(IMailmanagerRelayAuthentication), fullyQualifiedName: "aws.mailmanagerRelay.MailmanagerRelayAuthentication")]
    public interface IMailmanagerRelayAuthentication
    {
        /// <summary>no_authentication block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_relay#no_authentication MailmanagerRelay#no_authentication}
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRelay.IMailmanagerRelayAuthenticationNoAuthentication" />)[]</para>
        /// </remarks>
        [JsiiProperty(name: "noAuthentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRelay.MailmanagerRelayAuthenticationNoAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? NoAuthentication
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_relay#secret_arn MailmanagerRelay#secret_arn}.</summary>
        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMailmanagerRelayAuthentication), fullyQualifiedName: "aws.mailmanagerRelay.MailmanagerRelayAuthentication")]
        internal sealed class _Proxy : DeputyBase, aws.MailmanagerRelay.IMailmanagerRelayAuthentication
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>no_authentication block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_relay#no_authentication MailmanagerRelay#no_authentication}
            /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="aws.MailmanagerRelay.IMailmanagerRelayAuthenticationNoAuthentication" />)[]</para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "noAuthentication", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.mailmanagerRelay.MailmanagerRelayAuthenticationNoAuthentication\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? NoAuthentication
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.61.0/docs/resources/mailmanager_relay#secret_arn MailmanagerRelay#secret_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
