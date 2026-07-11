using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azuread.ApplicationFlexibleFederatedIdentityCredential
{
    [JsiiByValue(fqn: "azuread.applicationFlexibleFederatedIdentityCredential.ApplicationFlexibleFederatedIdentityCredentialTimeouts")]
    public class ApplicationFlexibleFederatedIdentityCredentialTimeouts : azuread.ApplicationFlexibleFederatedIdentityCredential.IApplicationFlexibleFederatedIdentityCredentialTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#create ApplicationFlexibleFederatedIdentityCredential#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#delete ApplicationFlexibleFederatedIdentityCredential#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#read ApplicationFlexibleFederatedIdentityCredential#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azuread/3.9.0/docs/resources/application_flexible_federated_identity_credential#update ApplicationFlexibleFederatedIdentityCredential#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
