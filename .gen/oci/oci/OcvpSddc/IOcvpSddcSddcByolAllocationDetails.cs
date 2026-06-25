using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OcvpSddc
{
    [JsiiInterface(nativeType: typeof(IOcvpSddcSddcByolAllocationDetails), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcSddcByolAllocationDetails")]
    public interface IOcvpSddcSddcByolAllocationDetails
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/ocvp_sddc#load_balancer_byol_allocation_id OcvpSddc#load_balancer_byol_allocation_id}.</summary>
        [JsiiProperty(name: "loadBalancerByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LoadBalancerByolAllocationId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/ocvp_sddc#load_balancer_instance_count OcvpSddc#load_balancer_instance_count}.</summary>
        [JsiiProperty(name: "loadBalancerInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? LoadBalancerInstanceCount
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOcvpSddcSddcByolAllocationDetails), fullyQualifiedName: "oci.ocvpSddc.OcvpSddcSddcByolAllocationDetails")]
        internal sealed class _Proxy : DeputyBase, oci.OcvpSddc.IOcvpSddcSddcByolAllocationDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/ocvp_sddc#load_balancer_byol_allocation_id OcvpSddc#load_balancer_byol_allocation_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerByolAllocationId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LoadBalancerByolAllocationId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/oracle/oci/8.19.0/docs/resources/ocvp_sddc#load_balancer_instance_count OcvpSddc#load_balancer_instance_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "loadBalancerInstanceCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? LoadBalancerInstanceCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
