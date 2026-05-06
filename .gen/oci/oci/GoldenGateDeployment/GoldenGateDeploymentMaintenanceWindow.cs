using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceWindow")]
    public class GoldenGateDeploymentMaintenanceWindow : oci.GoldenGateDeployment.IGoldenGateDeploymentMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#day GoldenGateDeployment#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public string Day
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#start_hour GoldenGateDeployment#start_hour}.</summary>
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
        public double StartHour
        {
            get;
            set;
        }
    }
}
