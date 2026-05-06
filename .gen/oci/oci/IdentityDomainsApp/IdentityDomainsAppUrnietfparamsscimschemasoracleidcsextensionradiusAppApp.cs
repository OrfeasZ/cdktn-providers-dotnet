using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp")]
    public class IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp : oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppApp
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#client_ip IdentityDomainsApp#client_ip}.</summary>
        [JsiiProperty(name: "clientIp", typeJson: "{\"primitive\":\"string\"}")]
        public string ClientIp
        {
            get;
            set;
        }

        private object _includeGroupInResponse;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#include_group_in_response IdentityDomainsApp#include_group_in_response}.</summary>
        [JsiiProperty(name: "includeGroupInResponse", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public object IncludeGroupInResponse
        {
            get => _includeGroupInResponse;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeGroupInResponse = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#port IdentityDomainsApp#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public string Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#secret_key IdentityDomainsApp#secret_key}.</summary>
        [JsiiProperty(name: "secretKey", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretKey
        {
            get;
            set;
        }

        private object? _captureClientIp;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#capture_client_ip IdentityDomainsApp#capture_client_ip}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "captureClientIp", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? CaptureClientIp
        {
            get => _captureClientIp;
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
                _captureClientIp = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#country_code_response_attribute_id IdentityDomainsApp#country_code_response_attribute_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "countryCodeResponseAttributeId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CountryCodeResponseAttributeId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#end_user_ip_attribute IdentityDomainsApp#end_user_ip_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "endUserIpAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EndUserIpAttribute
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_radius_attribute IdentityDomainsApp#group_membership_radius_attribute}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupMembershipRadiusAttribute", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupMembershipRadiusAttribute
        {
            get;
            set;
        }

        private object? _groupMembershipToReturn;

        /// <summary>group_membership_to_return block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_membership_to_return IdentityDomainsApp#group_membership_to_return}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groupMembershipToReturn", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsApp.IdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? GroupMembershipToReturn
        {
            get => _groupMembershipToReturn;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturn[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsApp.IIdentityDomainsAppUrnietfparamsscimschemasoracleidcsextensionradiusAppAppGroupMembershipToReturn).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groupMembershipToReturn = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#group_name_format IdentityDomainsApp#group_name_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupNameFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupNameFormat
        {
            get;
            set;
        }

        private object? _passwordAndOtpTogether;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#password_and_otp_together IdentityDomainsApp#password_and_otp_together}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "passwordAndOtpTogether", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public object? PasswordAndOtpTogether
        {
            get => _passwordAndOtpTogether;
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
                _passwordAndOtpTogether = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#radius_vendor_specific_id IdentityDomainsApp#radius_vendor_specific_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "radiusVendorSpecificId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RadiusVendorSpecificId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format IdentityDomainsApp#response_format}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseFormat", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#response_format_delimiter IdentityDomainsApp#response_format_delimiter}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseFormatDelimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResponseFormatDelimiter
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_app#type_of_radius_app IdentityDomainsApp#type_of_radius_app}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "typeOfRadiusApp", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TypeOfRadiusApp
        {
            get;
            set;
        }
    }
}
