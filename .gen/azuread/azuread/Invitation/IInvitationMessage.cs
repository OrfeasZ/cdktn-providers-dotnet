using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Invitation
{
    [JsiiInterface(nativeType: typeof(IInvitationMessage), fullyQualifiedName: "azuread.invitation.InvitationMessage")]
    public interface IInvitationMessage
    {
        /// <summary>Email addresses of additional recipients the invitation message should be sent to.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#additional_recipients Invitation#additional_recipients}
        /// </remarks>
        [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AdditionalRecipients
        {
            get
            {
                return null;
            }
        }

        /// <summary>Customized message body you want to send if you don't want to send the default message.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#body Invitation#body}
        /// </remarks>
        [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Body
        {
            get
            {
                return null;
            }
        }

        /// <summary>The language you want to send the default message in.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#language Invitation#language}
        /// </remarks>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Language
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IInvitationMessage), fullyQualifiedName: "azuread.invitation.InvitationMessage")]
        internal sealed class _Proxy : DeputyBase, azuread.Invitation.IInvitationMessage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Email addresses of additional recipients the invitation message should be sent to.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#additional_recipients Invitation#additional_recipients}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "additionalRecipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AdditionalRecipients
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Customized message body you want to send if you don't want to send the default message.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#body Invitation#body}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "body", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Body
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The language you want to send the default message in.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/invitation#language Invitation#language}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Language
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
