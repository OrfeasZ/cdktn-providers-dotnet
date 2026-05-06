using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.RecoveryRecoveryServiceSubnet
{
    [JsiiByValue(fqn: "oci.recoveryRecoveryServiceSubnet.RecoveryRecoveryServiceSubnetTimeouts")]
    public class RecoveryRecoveryServiceSubnetTimeouts : oci.RecoveryRecoveryServiceSubnet.IRecoveryRecoveryServiceSubnetTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#create RecoveryRecoveryServiceSubnet#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#delete RecoveryRecoveryServiceSubnet#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/recovery_recovery_service_subnet#update RecoveryRecoveryServiceSubnet#update}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Update
        {
            get;
            set;
        }
    }
}
