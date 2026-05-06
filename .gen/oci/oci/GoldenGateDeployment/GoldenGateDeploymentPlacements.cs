using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiByValue(fqn: "oci.goldenGateDeployment.GoldenGateDeploymentPlacements")]
    public class GoldenGateDeploymentPlacements : oci.GoldenGateDeployment.IGoldenGateDeploymentPlacements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#availability_domain GoldenGateDeployment#availability_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AvailabilityDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#fault_domain GoldenGateDeployment#fault_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FaultDomain
        {
            get;
            set;
        }
    }
}
