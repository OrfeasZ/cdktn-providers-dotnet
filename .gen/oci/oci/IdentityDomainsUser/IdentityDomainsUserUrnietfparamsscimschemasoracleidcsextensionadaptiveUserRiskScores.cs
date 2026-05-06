using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#last_update_timestamp IdentityDomainsUser#last_update_timestamp}.</summary>
        [JsiiProperty(name: "lastUpdateTimestamp", typeJson: "{\"primitive\":\"string\"}")]
        public string LastUpdateTimestamp
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_level IdentityDomainsUser#risk_level}.</summary>
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}")]
        public string RiskLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#score IdentityDomainsUser#score}.</summary>
        [JsiiProperty(name: "score", typeJson: "{\"primitive\":\"number\"}")]
        public double Score
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#value IdentityDomainsUser#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#source IdentityDomainsUser#source}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Source
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#status IdentityDomainsUser#status}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Status
        {
            get;
            set;
        }
    }
}
