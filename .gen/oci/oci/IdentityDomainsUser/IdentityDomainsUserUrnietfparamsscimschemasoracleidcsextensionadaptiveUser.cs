using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_level IdentityDomainsUser#risk_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RiskLevel
        {
            get;
            set;
        }

        private object? _riskScores;

        /// <summary>risk_scores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_scores IdentityDomainsUser#risk_scores}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "riskScores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RiskScores
        {
            get => _riskScores;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _riskScores = value;
            }
        }
    }
}
