using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiInterface(nativeType: typeof(IGoldenGateDeploymentMaintenanceWindow), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceWindow")]
    public interface IGoldenGateDeploymentMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#day GoldenGateDeployment#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        string Day
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#start_hour GoldenGateDeployment#start_hour}.</summary>
        [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
        double StartHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateDeploymentMaintenanceWindow), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateDeployment.IGoldenGateDeploymentMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#day GoldenGateDeployment#day}.</summary>
            [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
            public string Day
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#start_hour GoldenGateDeployment#start_hour}.</summary>
            [JsiiProperty(name: "startHour", typeJson: "{\"primitive\":\"number\"}")]
            public double StartHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
