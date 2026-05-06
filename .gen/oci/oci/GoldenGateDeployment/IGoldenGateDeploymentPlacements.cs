using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.GoldenGateDeployment
{
    [JsiiInterface(nativeType: typeof(IGoldenGateDeploymentPlacements), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentPlacements")]
    public interface IGoldenGateDeploymentPlacements
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#availability_domain GoldenGateDeployment#availability_domain}.</summary>
        [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AvailabilityDomain
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#fault_domain GoldenGateDeployment#fault_domain}.</summary>
        [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FaultDomain
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGoldenGateDeploymentPlacements), fullyQualifiedName: "oci.goldenGateDeployment.GoldenGateDeploymentPlacements")]
        internal sealed class _Proxy : DeputyBase, oci.GoldenGateDeployment.IGoldenGateDeploymentPlacements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#availability_domain GoldenGateDeployment#availability_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "availabilityDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AvailabilityDomain
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/7.23.0/docs/resources/golden_gate_deployment#fault_domain GoldenGateDeployment#fault_domain}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "faultDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FaultDomain
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
