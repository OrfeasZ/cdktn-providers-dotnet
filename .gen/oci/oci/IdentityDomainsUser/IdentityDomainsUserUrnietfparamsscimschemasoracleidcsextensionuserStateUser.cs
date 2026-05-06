using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiByValue(fqn: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser")]
    public class IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser : oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser
    {
        /// <summary>locked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locked IdentityDomainsUser#locked}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "locked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked? Locked
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#max_concurrent_sessions IdentityDomainsUser#max_concurrent_sessions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxConcurrentSessions
        {
            get;
            set;
        }

        /// <summary>recovery_locked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#recovery_locked IdentityDomainsUser#recovery_locked}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recoveryLocked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked\"}", isOptional: true)]
        public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked? RecoveryLocked
        {
            get;
            set;
        }
    }
}
