using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#configuration IdentityDomainsApp#configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "configuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Configuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_credential_sharing_group_id IdentityDomainsApp#form_credential_sharing_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formCredentialSharingGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FormCredentialSharingGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_cred_method IdentityDomainsApp#form_cred_method}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formCredMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FormCredMethod
        {
            get;
            set;
        }

        private object? _formFillUrlMatch;

        /// <summary>form_fill_url_match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_fill_url_match IdentityDomainsApp#form_fill_url_match}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "formFillUrlMatch", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatch\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? FormFillUrlMatch
        {
            get => _formFillUrlMatch;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatch[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionformFillAppTemplateAppTemplateFormFillUrlMatch).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _formFillUrlMatch = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#form_type IdentityDomainsApp#form_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FormType
        {
            get;
            set;
        }

        private object? _revealPasswordOnForm;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#reveal_password_on_form IdentityDomainsApp#reveal_password_on_form}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "revealPasswordOnForm", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? RevealPasswordOnForm
        {
            get => _revealPasswordOnForm;
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
                _revealPasswordOnForm = value;
            }
        }

        private object? _syncFromTemplate;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#sync_from_template IdentityDomainsApp#sync_from_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "syncFromTemplate", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? SyncFromTemplate
        {
            get => _syncFromTemplate;
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
                _syncFromTemplate = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_expression IdentityDomainsApp#user_name_form_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userNameFormExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserNameFormExpression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#user_name_form_template IdentityDomainsApp#user_name_form_template}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userNameFormTemplate", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserNameFormTemplate
        {
            get;
            set;
        }
    }
}
