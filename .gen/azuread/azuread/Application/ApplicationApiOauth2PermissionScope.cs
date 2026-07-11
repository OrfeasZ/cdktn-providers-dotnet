using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.Application
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azuread.application.ApplicationApiOauth2PermissionScope")]
    public class ApplicationApiOauth2PermissionScope : azuread.Application.IApplicationApiOauth2PermissionScope
    {
        /// <summary>The unique identifier of the delegated permission.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#id Application#id}
        ///
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public string Id
        {
            get;
            set;
        }

        /// <summary>Delegated permission description that appears in all tenant-wide admin consent experiences, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#admin_consent_description Application#admin_consent_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminConsentDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminConsentDescription
        {
            get;
            set;
        }

        /// <summary>Display name for the delegated permission, intended to be read by an administrator granting the permission on behalf of all users.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#admin_consent_display_name Application#admin_consent_display_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminConsentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdminConsentDisplayName
        {
            get;
            set;
        }

        private object? _enabled;

        /// <summary>Determines if the permission scope is enabled.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#enabled Application#enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }

        /// <summary>Whether this delegated permission should be considered safe for non-admin users to consent to on behalf of themselves, or whether an administrator should be required for consent to the permissions.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#type Application#type}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>Delegated permission description that appears in the end user consent experience, intended to be read by a user consenting on their own behalf.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#user_consent_description Application#user_consent_description}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userConsentDescription", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserConsentDescription
        {
            get;
            set;
        }

        /// <summary>Display name for the delegated permission that appears in the end user consent experience.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#user_consent_display_name Application#user_consent_display_name}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userConsentDisplayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserConsentDisplayName
        {
            get;
            set;
        }

        /// <summary>The value that is used for the `scp` claim in OAuth 2.0 access tokens.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application#value Application#value}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
