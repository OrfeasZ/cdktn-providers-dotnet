using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.IdentityDomainsUser
{
    [JsiiInterface(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser")]
    public interface IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser
    {
        /// <summary>locked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locked IdentityDomainsUser#locked}
        /// </remarks>
        [JsiiProperty(name: "locked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked? Locked
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#max_concurrent_sessions IdentityDomainsUser#max_concurrent_sessions}.</summary>
        [JsiiProperty(name: "maxConcurrentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentSessions
        {
            get
            {
                return null;
            }
        }

        /// <summary>recovery_locked block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#recovery_locked IdentityDomainsUser#recovery_locked}
        /// </remarks>
        [JsiiProperty(name: "recoveryLocked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked? RecoveryLocked
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser), fullyQualifiedName: "oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser")]
        internal sealed class _Proxy : DeputyBase, oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>locked block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#locked IdentityDomainsUser#locked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "locked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked? Locked
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserLocked?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#max_concurrent_sessions IdentityDomainsUser#max_concurrent_sessions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentSessions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>recovery_locked block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/identity_domains_user#recovery_locked IdentityDomainsUser#recovery_locked}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recoveryLocked", typeJson: "{\"fqn\":\"oci.identityDomainsUser.IdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked\"}", isOptional: true)]
            public oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked? RecoveryLocked
            {
                get => GetInstanceProperty<oci.IdentityDomainsUser.IIdentityDomainsUserUrnietfparamsscimschemasoracleidcsextensionuserStateUserRecoveryLocked?>();
            }
        }
    }
}
