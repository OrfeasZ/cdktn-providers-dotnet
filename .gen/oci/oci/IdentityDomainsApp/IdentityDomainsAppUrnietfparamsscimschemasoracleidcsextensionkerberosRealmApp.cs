using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#default_encryption_salt_type IdentityDomainsApp#default_encryption_salt_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultEncryptionSaltType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultEncryptionSaltType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#master_key IdentityDomainsApp#master_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "masterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MasterKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_renewable_age IdentityDomainsApp#max_renewable_age}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxRenewableAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxRenewableAge
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_ticket_life IdentityDomainsApp#max_ticket_life}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxTicketLife", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxTicketLife
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#realm_name IdentityDomainsApp#realm_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RealmName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#supported_encryption_salt_types IdentityDomainsApp#supported_encryption_salt_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "supportedEncryptionSaltTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SupportedEncryptionSaltTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ticket_flags IdentityDomainsApp#ticket_flags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ticketFlags", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TicketFlags
        {
            get;
            set;
        }
    }
}
