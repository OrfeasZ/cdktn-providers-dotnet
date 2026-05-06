using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RecoveryProtectedDatabase
{
    [JsiiInterface(nativeType: typeof(IRecoveryProtectedDatabaseRecoveryServiceSubnets), fullyQualifiedName: "oci.recoveryProtectedDatabase.RecoveryProtectedDatabaseRecoveryServiceSubnets")]
    public interface IRecoveryProtectedDatabaseRecoveryServiceSubnets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_protected_database#recovery_service_subnet_id RecoveryProtectedDatabase#recovery_service_subnet_id}.</summary>
        [JsiiProperty(name: "recoveryServiceSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        string RecoveryServiceSubnetId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRecoveryProtectedDatabaseRecoveryServiceSubnets), fullyQualifiedName: "oci.recoveryProtectedDatabase.RecoveryProtectedDatabaseRecoveryServiceSubnets")]
        internal sealed class _Proxy : DeputyBase, oci.RecoveryProtectedDatabase.IRecoveryProtectedDatabaseRecoveryServiceSubnets
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_protected_database#recovery_service_subnet_id RecoveryProtectedDatabase#recovery_service_subnet_id}.</summary>
            [JsiiProperty(name: "recoveryServiceSubnetId", typeJson: "{\"primitive\":\"string\"}")]
            public string RecoveryServiceSubnetId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
