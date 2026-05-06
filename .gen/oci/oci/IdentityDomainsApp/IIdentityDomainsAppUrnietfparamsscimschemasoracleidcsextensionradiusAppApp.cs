using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp")]
    public interface IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip IdentityDomainsApp#client_ip}.</summary>
        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        string ClientIp
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_group_in_response IdentityDomainsApp#include_group_in_response}.</summary>
        [JsiiProperty(name: "includeGroupInResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object IncludeGroupInResponse
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#port IdentityDomainsApp#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        string Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secret_key IdentityDomainsApp#secret_key}.</summary>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        string SecretKey
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#capture_client_ip IdentityDomainsApp#capture_client_ip}.</summary>
        [JsiiProperty(name: "captureClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CaptureClientIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#country_code_response_attribute_id IdentityDomainsApp#country_code_response_attribute_id}.</summary>
        [JsiiProperty(name: "countryCodeResponseAttributeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CountryCodeResponseAttributeId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#end_user_ip_attribute IdentityDomainsApp#end_user_ip_attribute}.</summary>
        [JsiiProperty(name: "endUserIpAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EndUserIpAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_radius_attribute IdentityDomainsApp#group_membership_radius_attribute}.</summary>
        [JsiiProperty(name: "groupMembershipRadiusAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupMembershipRadiusAttribute
        {
            get
            {
                return null;
            }
        }

        /// <summary>group_membership_to_return block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_to_return IdentityDomainsApp#group_membership_to_return}
        /// </remarks>
        [JsiiProperty(name: "groupMembershipToReturn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? GroupMembershipToReturn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_name_format IdentityDomainsApp#group_name_format}.</summary>
        [JsiiProperty(name: "groupNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GroupNameFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#password_and_otp_together IdentityDomainsApp#password_and_otp_together}.</summary>
        [JsiiProperty(name: "passwordAndOtpTogether", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? PasswordAndOtpTogether
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_vendor_specific_id IdentityDomainsApp#radius_vendor_specific_id}.</summary>
        [JsiiProperty(name: "radiusVendorSpecificId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RadiusVendorSpecificId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format IdentityDomainsApp#response_format}.</summary>
        [JsiiProperty(name: "responseFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseFormat
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format_delimiter IdentityDomainsApp#response_format_delimiter}.</summary>
        [JsiiProperty(name: "responseFormatDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResponseFormatDelimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#type_of_radius_app IdentityDomainsApp#type_of_radius_app}.</summary>
        [JsiiProperty(name: "typeOfRadiusApp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TypeOfRadiusApp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp), fullyQualifiedName: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip IdentityDomainsApp#client_ip}.</summary>
            [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
            public string ClientIp
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_group_in_response IdentityDomainsApp#include_group_in_response}.</summary>
            [JsiiProperty(name: "includeGroupInResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object IncludeGroupInResponse
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#port IdentityDomainsApp#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
            public string Port
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secret_key IdentityDomainsApp#secret_key}.</summary>
            [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#capture_client_ip IdentityDomainsApp#capture_client_ip}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "captureClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? CaptureClientIp
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#country_code_response_attribute_id IdentityDomainsApp#country_code_response_attribute_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "countryCodeResponseAttributeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CountryCodeResponseAttributeId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#end_user_ip_attribute IdentityDomainsApp#end_user_ip_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "endUserIpAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EndUserIpAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_radius_attribute IdentityDomainsApp#group_membership_radius_attribute}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupMembershipRadiusAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupMembershipRadiusAttribute
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>group_membership_to_return block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_to_return IdentityDomainsApp#group_membership_to_return}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groupMembershipToReturn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? GroupMembershipToReturn
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_name_format IdentityDomainsApp#group_name_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "groupNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GroupNameFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#password_and_otp_together IdentityDomainsApp#password_and_otp_together}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwordAndOtpTogether", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? PasswordAndOtpTogether
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_vendor_specific_id IdentityDomainsApp#radius_vendor_specific_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "radiusVendorSpecificId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RadiusVendorSpecificId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format IdentityDomainsApp#response_format}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseFormat
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format_delimiter IdentityDomainsApp#response_format_delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "responseFormatDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResponseFormatDelimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#type_of_radius_app IdentityDomainsApp#type_of_radius_app}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "typeOfRadiusApp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TypeOfRadiusApp
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
