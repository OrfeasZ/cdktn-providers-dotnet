using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#default_encryption_salt_type IdentityDomainsApp#default_encryption_salt_type}.</summary>
        [JsiiProperty(name: "defaultEncryptionSaltType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultEncryptionSaltType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#master_key IdentityDomainsApp#master_key}.</summary>
        [JsiiProperty(name: "masterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MasterKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_renewable_age IdentityDomainsApp#max_renewable_age}.</summary>
        [JsiiProperty(name: "maxRenewableAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxRenewableAge
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_ticket_life IdentityDomainsApp#max_ticket_life}.</summary>
        [JsiiProperty(name: "maxTicketLife", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxTicketLife
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#realm_name IdentityDomainsApp#realm_name}.</summary>
        [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RealmName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#supported_encryption_salt_types IdentityDomainsApp#supported_encryption_salt_types}.</summary>
        [JsiiProperty(name: "supportedEncryptionSaltTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SupportedEncryptionSaltTypes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ticket_flags IdentityDomainsApp#ticket_flags}.</summary>
        [JsiiProperty(name: "ticketFlags", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TicketFlags
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionkerberosRealmApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#default_encryption_salt_type IdentityDomainsApp#default_encryption_salt_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEncryptionSaltType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultEncryptionSaltType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#master_key IdentityDomainsApp#master_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "masterKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MasterKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_renewable_age IdentityDomainsApp#max_renewable_age}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxRenewableAge", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxRenewableAge
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#max_ticket_life IdentityDomainsApp#max_ticket_life}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxTicketLife", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxTicketLife
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#realm_name IdentityDomainsApp#realm_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "realmName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RealmName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#supported_encryption_salt_types IdentityDomainsApp#supported_encryption_salt_types}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "supportedEncryptionSaltTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SupportedEncryptionSaltTypes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#ticket_flags IdentityDomainsApp#ticket_flags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ticketFlags", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TicketFlags
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
