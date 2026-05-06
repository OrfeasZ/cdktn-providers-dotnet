using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authentication_method IdentityDomainsUser#authentication_method}.</summary>
        [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthenticationMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display IdentityDomainsUser#display}.</summary>
        [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Display
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_status IdentityDomainsUser#factor_status}.</summary>
        [JsiiProperty(name: "factorStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FactorStatus
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_type IdentityDomainsUser#factor_type}.</summary>
        [JsiiProperty(name: "factorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FactorType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#last_sync_time IdentityDomainsUser#last_sync_time}.</summary>
        [JsiiProperty(name: "lastSyncTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LastSyncTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#status IdentityDomainsUser#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#third_party_vendor_name IdentityDomainsUser#third_party_vendor_name}.</summary>
        [JsiiProperty(name: "thirdPartyVendorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ThirdPartyVendorName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionmfaUserDevices
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#authentication_method IdentityDomainsUser#authentication_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthenticationMethod
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#display IdentityDomainsUser#display}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "display", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Display
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_status IdentityDomainsUser#factor_status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "factorStatus", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FactorStatus
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#factor_type IdentityDomainsUser#factor_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "factorType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FactorType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#last_sync_time IdentityDomainsUser#last_sync_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lastSyncTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LastSyncTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#status IdentityDomainsUser#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#third_party_vendor_name IdentityDomainsUser#third_party_vendor_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "thirdPartyVendorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ThirdPartyVendorName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
