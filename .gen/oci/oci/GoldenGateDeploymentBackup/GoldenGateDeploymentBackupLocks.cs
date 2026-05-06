using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeploymentBackup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateDeploymentBackup.GoldenGateDeploymentBackupLocks")]
    public class GoldenGateDeploymentBackupLocks : oci.GoldenGateDeploymentBackup.IGoldenGateDeploymentBackupLocks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment_backup#type GoldenGateDeploymentBackup#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment_backup#message GoldenGateDeploymentBackup#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
