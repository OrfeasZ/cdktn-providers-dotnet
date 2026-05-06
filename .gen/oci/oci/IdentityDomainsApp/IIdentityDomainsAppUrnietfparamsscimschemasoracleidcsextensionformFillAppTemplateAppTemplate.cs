using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#configuration IdentityDomainsApp#configuration}.</summary>
        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Configuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_credential_sharing_group_id IdentityDomainsApp#form_credential_sharing_group_id}.</summary>
        [JsiiProperty(name: "formCredentialSharingGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormCredentialSharingGroupId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_cred_method IdentityDomainsApp#form_cred_method}.</summary>
        [JsiiProperty(name: "formCredMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormCredMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>form_fill_url_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_fill_url_match IdentityDomainsApp#form_fill_url_match}
        /// </remarks>
        [JsiiProperty(name: "formFillUrlMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FormFillUrlMatch
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_type IdentityDomainsApp#form_type}.</summary>
        [JsiiProperty(name: "formType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FormType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#reveal_password_on_form IdentityDomainsApp#reveal_password_on_form}.</summary>
        [JsiiProperty(name: "revealPasswordOnForm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RevealPasswordOnForm
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sync_from_template IdentityDomainsApp#sync_from_template}.</summary>
        [JsiiProperty(name: "syncFromTemplate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? SyncFromTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_expression IdentityDomainsApp#user_name_form_expression}.</summary>
        [JsiiProperty(name: "userNameFormExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserNameFormExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_template IdentityDomainsApp#user_name_form_template}.</summary>
        [JsiiProperty(name: "userNameFormTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserNameFormTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#configuration IdentityDomainsApp#configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Configuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_credential_sharing_group_id IdentityDomainsApp#form_credential_sharing_group_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formCredentialSharingGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormCredentialSharingGroupId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_cred_method IdentityDomainsApp#form_cred_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formCredMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormCredMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>form_fill_url_match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_fill_url_match IdentityDomainsApp#form_fill_url_match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "formFillUrlMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? FormFillUrlMatch
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_type IdentityDomainsApp#form_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FormType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#reveal_password_on_form IdentityDomainsApp#reveal_password_on_form}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "revealPasswordOnForm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? RevealPasswordOnForm
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sync_from_template IdentityDomainsApp#sync_from_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "syncFromTemplate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? SyncFromTemplate
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_expression IdentityDomainsApp#user_name_form_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userNameFormExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserNameFormExpression
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_template IdentityDomainsApp#user_name_form_template}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userNameFormTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserNameFormTemplate
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
