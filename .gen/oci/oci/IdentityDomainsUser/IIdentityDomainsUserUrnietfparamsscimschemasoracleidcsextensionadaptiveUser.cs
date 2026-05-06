using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_level IdentityDomainsUser#risk_level}.</summary>
        [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RiskLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>risk_scores block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_scores IdentityDomainsUser#risk_scores}
        /// </remarks>
        [JsiiProperty(name: "riskScores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RiskScores
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_level IdentityDomainsUser#risk_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "riskLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RiskLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>risk_scores block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#risk_scores IdentityDomainsUser#risk_scores}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "riskScores", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionadaptiveUserRiskScores\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RiskScores
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
