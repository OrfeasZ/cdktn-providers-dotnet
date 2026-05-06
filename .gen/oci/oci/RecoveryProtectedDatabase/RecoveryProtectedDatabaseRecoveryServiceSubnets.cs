using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RecoveryProtectedDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.recoveryProtectedDatabase.RecoveryProtectedDatabaseRecoveryServiceSubnets")]
    public class RecoveryProtectedDatabaseRecoveryServiceSubnets : oci.RecoveryProtectedDatabase.IRecoveryProtectedDatabaseRecoveryServiceSubnets
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_protected_database#recovery_service_subnet_id RecoveryProtectedDatabase#recovery_service_subnet_id}.</summary>
        [JsiiProperty(name: "recoveryServiceSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public string RecoveryServiceSubnetId
        {
            get;
            set;
        }
    }
}
